using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using ConsultaPrecios.Modelos;
using System.Data;
using System.IO;

namespace ConsultaPrecios.Controladores
{
    public class Firebird_Controller
    {
        private FbConnection FbConn;
        private FbCommand FbComm;
        private FbDataAdapter FbAdapter;

        public Firebird_Controller()
        {
            FbConn = new FbConnection();
            FbConn.ConnectionString = getConnectionString();
            
            FbComm = new FbCommand();

            FbAdapter = new FbDataAdapter();
        }

        private string getConnectionString()
        {
            StringBuilder sbStringConn = new StringBuilder();
            sbStringConn.Append(string.Format("User={0};", Microsip.Usuario));
            sbStringConn.Append(string.Format("Password={0};", Microsip.Contraseña));
            sbStringConn.Append(string.Format("Database={0};", Microsip.BaseDeDatos));
            sbStringConn.Append(string.Format("DataSource={0};", Microsip.Servidor));
            sbStringConn.Append(string.Format("Port={0};", Microsip.Puerto));

            return (sbStringConn.ToString());
        }

        public Precios getPrecios(string codigo)
        {
            Precios result = new Precios();

            FbConn.Open();
            FbComm.Connection = FbConn;

            string sql = 
                        " select ca.articulo_id, ca.clave_articulo, a.nombre as articulo, mayo.PRECIO precio_mayoreo, lista.precio precio_lista" +
                        " from claves_articulos ca" +
                        " inner join articulos a on (ca.articulo_id = a.articulo_id)" +
                        " left join " +
	                        " (select articulo_id, precio from PRECIOS_ARTICULOS where PRECIO_EMPRESA_id = {0}) mayo" +
                            " on (ca.articulo_id = mayo.articulo_id)" +
                        " left join " +
	                        " (select articulo_id, precio from PRECIOS_ARTICULOS where PRECIO_EMPRESA_id = {1}) lista" +
                            " on (ca.articulo_id = lista.articulo_id)" +
                        " where CLAVE_ARTICULO = '{2}'";

            sql = string.Format(sql, Properties.Settings.Default.idMayoreo, Properties.Settings.Default.idLista, codigo);

            FbComm.CommandText = sql;

            FbAdapter.SelectCommand = FbComm;

            DataTable dtConsulta = new DataTable();
            FbAdapter.Fill(dtConsulta);

            if (dtConsulta.Rows.Count == 0) return null;

            foreach (DataRow fila in dtConsulta.Rows)
            {
                // obtener precio con iva(s)
                decimal precioCons = fila["precio_lista"] == DBNull.Value ? 0 : Convert.ToDecimal(fila["precio_lista"]);
                long articuloId = Convert.ToInt64(fila["articulo_id"]);

                decimal precioLista = this.obtPrecioIvas(precioCons, articuloId);

                decimal existencia = this.obtExistencia(articuloId);

                result.articulo = Convert.ToString(fila["articulo"]);
                result.cveArticulo = Convert.ToString(fila["clave_articulo"]);
                //result.precioLista = fila["precio_lista"] == DBNull.Value ? 0 : Convert.ToDecimal(fila["precio_lista"]);
                result.precioLista = precioLista;
                result.precioMay = fila["precio_mayoreo"] == DBNull.Value ? 0 : Convert.ToDecimal(fila["precio_mayoreo"]);
                result.existencia = existencia;
            }

            FbConn.Close();

            return result;
        }

        private decimal obtExistencia(long articuloId)
        {
            decimal result = 0;

            string sql = "SELECT existencia FROM EXIVAL_ART({0}, {1}, cast('Now' as date), 'S')";

            sql = string.Format(sql, articuloId, Properties.Settings.Default.almacen);

            FbComm.CommandText = sql;

            FbAdapter.SelectCommand = FbComm;

            DataTable dtConsulta = new DataTable();
            FbAdapter.Fill(dtConsulta);

            if (dtConsulta.Rows.Count == 0) return 0;

            foreach (DataRow fila in dtConsulta.Rows)
            {
                result = Convert.ToDecimal(fila["existencia"]);
            }

            return result;

        }

        private decimal obtPrecioIvas(decimal precioCons, long articuloId)
        {
            decimal result = 0;

            if (precioCons <= 0) return 0;

            // obtiene los valores de iva
            List<Decimal> ivas = this.obtIvas(articuloId);

            result = this.calcIvas(precioCons, ivas);

            return result;
        }

        private decimal calcIvas(decimal precioCons, List<Decimal> ivas)
        {
            decimal result = precioCons, sum = 0;

            foreach(decimal d in ivas)
            {
                sum = sum + ((d/100) * precioCons);
            }

            return result + sum;
        }

        // obtiene una lista de ivas que pueda tener un articulo
        // IVA, IEPS
        private List<Decimal> obtIvas(long articuloId)
        {
            List<Decimal> result = new List<Decimal>();

            string sql =
                        " SELECT " +
                        "  IA.ARTICULO_ID, " +
                        "  I.NOMBRE, " +
                        "  I.PCTJE_IMPUESTO, " +
                        "  A.NOMBRE " +
                        "FROM " +
                        "  IMPUESTOS_ARTICULOS IA " +
                        "  INNER JOIN IMPUESTOS I ON (IA.IMPUESTO_ID = I.IMPUESTO_ID) " +
                        "  INNER JOIN ARTICULOS A ON (IA.ARTICULO_ID = A.ARTICULO_ID) " +
                        "WHERE " +
                        "  A.ARTICULO_ID = {0}";

            sql = string.Format(sql, articuloId);

            FbComm.CommandText = sql;

            FbAdapter.SelectCommand = FbComm;

            DataTable dtConsulta = new DataTable();
            FbAdapter.Fill(dtConsulta);

            if (dtConsulta.Rows.Count == 0) return new List<Decimal>();

            foreach (DataRow fila in dtConsulta.Rows)
            {
                result.Add(Convert.ToDecimal(fila["PCTJE_IMPUESTO"]));
            }
            
            return result;
        }

        // obtiene los precios de la empresa
        public List<Combos> getPreciosLM()
        {
            List<Combos> result = new List<Combos>();
            Combos ent;

            FbConn.Open();
            FbComm.Connection = FbConn;

            string sql = " SELECT precio_empresa_id, nombre FROM PRECIOS_EMPRESA";
            
            FbComm.CommandText = sql;

            FbAdapter.SelectCommand = FbComm;

            DataTable dtConsulta = new DataTable();
            FbAdapter.Fill(dtConsulta);

            foreach (DataRow fila in dtConsulta.Rows)
            {
                ent = new Combos();
                ent.nombre = Convert.ToString(fila["nombre"]);
                ent.precioEmpresaId = fila["precio_empresa_id"] == DBNull.Value ? 0 : Convert.ToInt64(fila["precio_empresa_id"]);

                result.Add(ent);
            }

            FbConn.Close();

            return result;
        }

        // obtiene los almacenes de la base
        public List<Almacen> getAlmacen()
        {
            List<Almacen> result = new List<Almacen>();
            Almacen ent;

            FbConn.Open();
            FbComm.Connection = FbConn;

            string sql = "select almacen_id, nombre from ALMACENES";

            FbComm.CommandText = sql;

            FbAdapter.SelectCommand = FbComm;

            DataTable dtConsulta = new DataTable();
            FbAdapter.Fill(dtConsulta);

            foreach (DataRow fila in dtConsulta.Rows)
            {
                ent = new Almacen();
                ent.nombre = Convert.ToString(fila["nombre"]);
                ent.almacenId = fila["almacen_id"] == DBNull.Value ? 0 : Convert.ToInt64(fila["almacen_id"]);

                result.Add(ent);
            }

            FbConn.Close();

            return result;
        }
    }
}
