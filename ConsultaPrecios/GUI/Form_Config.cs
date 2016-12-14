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
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

                Properties.Settings.Default.Save();

                // ingresar los valores en el microsip
                Microsip.Servidor = this.tbServidor.Text;
                Microsip.Usuario = this.tbUsuario.Text;
                Microsip.Contraseña = this.tbContrasenia.Text;
                Microsip.Puerto = Convert.ToInt16(this.tbPuerto.Text);
                Microsip.BaseDeDatos = this.tbBaseDatos.Text;

                this.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("Configuración", E.Message);
            }
        }
    }
}
