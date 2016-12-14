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
                        " select ca.clave_articulo, a.nombre as articulo, mayo.PRECIO precio_mayoreo, lista.precio precio_lista" +
                        " from claves_articulos ca" +
                        " inner join articulos a on (ca.articulo_id = a.articulo_id)" +
                        " left join " +
	                        " (select articulo_id, precio from PRECIOS_ARTICULOS where PRECIO_EMPRESA_id = 243) mayo" +
                            " on (ca.articulo_id = mayo.articulo_id)" +
                        " left join " +
	                        " (select articulo_id, precio from PRECIOS_ARTICULOS where PRECIO_EMPRESA_id = 42) lista" +
                            " on (ca.articulo_id = lista.articulo_id)" +
                        " where CLAVE_ARTICULO = '{0}'";
            
            sql = string.Format(sql, codigo);

            FbComm.CommandText = sql;

            FbAdapter.SelectCommand = FbComm;

            DataTable dtConsulta = new DataTable();
            FbAdapter.Fill(dtConsulta);

            if (dtConsulta.Rows.Count == 0) return null;

            foreach (DataRow fila in dtConsulta.Rows)
            {
                result.articulo = Convert.ToString(fila["articulo"]);
                result.cveArticulo = Convert.ToString(fila["clave_articulo"]);
                result.precioLista = fila["precio_lista"] == DBNull.Value ? 0 : Convert.ToDecimal(fila["precio_lista"]);
                result.precioMay = fila["precio_mayoreo"] == DBNull.Value ? 0 : Convert.ToDecimal(fila["precio_mayoreo"]);
            }

            FbConn.Close();

            return result;
        }
    }
}
