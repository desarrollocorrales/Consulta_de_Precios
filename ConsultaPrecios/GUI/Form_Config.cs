using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConsultaPrecios.Modelos;

namespace ConsultaPrecios.GUI
{
    public partial class Form_Config : Form
    {
        public Form_Config()
        {
            InitializeComponent();
        }

        private void Form_Config_Load(object sender, EventArgs e)
        {
            // si existe informacion en el archivo setting.settings lo vacia en los textbox
            if (!string.IsNullOrEmpty(Properties.Settings.Default.servidor))
            {
                this.tbContrasenia.Text = Properties.Settings.Default.contrasenia;
                this.tbPuerto.Text = Properties.Settings.Default.puerto;
                this.tbServidor.Text = Properties.Settings.Default.servidor;
                this.tbUsuario.Text = Properties.Settings.Default.usuario;
                this.tbBaseDatos.Text = Properties.Settings.Default.baseDatos;

                cargaCombos();

                var idLista = Properties.Settings.Default.idLista;
                var idMayoreo = Properties.Settings.Default.idMayoreo;
                var almacen = Properties.Settings.Default.almacen;

                this.cbMayoreo.SelectedValue = Convert.ToInt64(string.IsNullOrEmpty(idMayoreo) ? "0" : idMayoreo);
                this.cbLista.SelectedValue = Convert.ToInt64(string.IsNullOrEmpty(idLista) ? "0" : idLista);
                this.cbAlmacen.SelectedValue = Convert.ToInt64(string.IsNullOrEmpty(almacen) ? "0" : almacen);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.cbMayoreo.SelectedIndex == -1)
                throw new Exception("Seleccione una opcion para de Mayoreo");

            if (this.cbLista.SelectedIndex == -1)
                throw new Exception("Seleccione una opcion para de Lista");

            guardaInfo();

            this.Close();
        }

        private void guardaInfo()
        {
            try
            {
                if (string.IsNullOrEmpty(this.tbServidor.Text))
                    throw new Exception("Ingrese el nombre del Servidor");

                if (string.IsNullOrEmpty(this.tbUsuario.Text))
                    throw new Exception("Ingrese el Usuario");

                if (string.IsNullOrEmpty(this.tbContrasenia.Text))
                    throw new Exception("Ingrese la Contraseña ");

                if (string.IsNullOrEmpty(this.tbPuerto.Text))
                    throw new Exception("Ingrese el Puerto");

                if (string.IsNullOrEmpty(this.tbBaseDatos.Text))
                    throw new Exception("Ingrese la Base de Datos");


                // ingresar los valores en el archivo settings.settings
                Properties.Settings.Default.servidor = this.tbServidor.Text;
                Properties.Settings.Default.usuario = this.tbUsuario.Text;
                Properties.Settings.Default.contrasenia = this.tbContrasenia.Text;
                Properties.Settings.Default.puerto = this.tbPuerto.Text;
                Properties.Settings.Default.baseDatos = this.tbBaseDatos.Text;
                Properties.Settings.Default.idLista = Convert.ToString(this.cbLista.SelectedValue);
                Properties.Settings.Default.idMayoreo = Convert.ToString(this.cbMayoreo.SelectedValue);
                Properties.Settings.Default.almacen = Convert.ToString(this.cbAlmacen.SelectedValue);

                Properties.Settings.Default.Save();

                // ingresar los valores en el microsip
                Microsip.Servidor = this.tbServidor.Text;
                Microsip.Usuario = this.tbUsuario.Text;
                Microsip.Contraseña = this.tbContrasenia.Text;
                Microsip.Puerto = Convert.ToInt16(this.tbPuerto.Text);
                Microsip.BaseDeDatos = this.tbBaseDatos.Text;

            }
            catch (Exception E)
            {
                MessageBox.Show("Configuración", E.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // valida y guarda la configuracion de conexion
            guardaInfo();

            // carga informacion en los combos
            cargaCombos();
        }

        private void cargaCombos()
        {
            try
            {

                Controladores.Firebird_Controller control = new Controladores.Firebird_Controller();

                // carga los combos
                this.cbLista.DataSource = control.getPreciosLM();
                this.cbLista.DisplayMember = "nombre";
                this.cbLista.ValueMember = "precioEmpresaId";

                this.cbMayoreo.DataSource = control.getPreciosLM();
                this.cbMayoreo.DisplayMember = "nombre";
                this.cbMayoreo.ValueMember = "precioEmpresaId";

                // carga combo de almacen
                this.cbAlmacen.DataSource = control.getAlmacen();
                this.cbAlmacen.DisplayMember = "nombre";
                this.cbAlmacen.ValueMember = "almacenId";

            }
            catch (Exception E)
            {
                MessageBox.Show("Configuración", E.Message);
            }
        }
    }
}
