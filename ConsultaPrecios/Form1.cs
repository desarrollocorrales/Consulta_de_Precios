using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConsultaPrecios.Controladores;
using ConsultaPrecios.Modelos;

namespace ConsultaPrecios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.lbArticulo.Text = string.Empty;

            // se obtiene la configuracion del archivo setting.settings
            Microsip.Contraseña = Properties.Settings.Default.contrasenia;
            Microsip.Puerto = (string.IsNullOrEmpty(Properties.Settings.Default.puerto) ? 0 : Convert.ToInt16(Properties.Settings.Default.puerto));
            Microsip.Servidor = Properties.Settings.Default.servidor;
            Microsip.Usuario = Properties.Settings.Default.usuario;
            Microsip.BaseDeDatos = Properties.Settings.Default.baseDatos;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // si se presiona la tecla 'enter'
                if (e.KeyChar == (char)13)
                {
                    // valida si hay valores en la cadena de conexion
                    if (string.IsNullOrEmpty(Microsip.Servidor))
                    {
                        throw new Exception("No ha definido las conexiones");
                    }

                    Firebird_Controller fireCon = new Firebird_Controller();

                    string codigo = this.tbCodigo.Text.Substring(0, 2).Equals("20") ? this.tbCodigo.Text.Substring(2, 5) : this.tbCodigo.Text;

                    Precios precio = fireCon.getPrecios(codigo);

                    if (precio != null)
                    {
                        this.tbLista.Text = string.Format("{0:C}", precio.precioLista);
                        this.tbMayoreo.Text = string.Format("{0:C}", precio.precioMay);
                        this.lbArticulo.Text = precio.articulo;
                    }
                    else
                    {
                        this.tbLista.Text = string.Empty;
                        this.tbMayoreo.Text = string.Empty;
                        this.lbArticulo.Text = string.Empty;

                        throw new Exception("Sin información sobre el articulo");
                    }

                    // limpia text_box
                    this.tbCodigo.Text = string.Empty;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message,"Consulta de Precios");
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            // abre el formularion de configuraciones
            GUI.Form_Config form = new GUI.Form_Config();

            form.ShowDialog();
        }
    }
}
