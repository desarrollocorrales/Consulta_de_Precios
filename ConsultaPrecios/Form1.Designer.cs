namespace ConsultaPrecios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLista = new System.Windows.Forms.TextBox();
            this.tbMayoreo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbArticulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 30F);
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta de Precios";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 22F);
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Articulo";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Tahoma", 22F);
            this.tbCodigo.Location = new System.Drawing.Point(133, 60);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(535, 43);
            this.tbCodigo.TabIndex = 3;
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 32F);
            this.label3.Location = new System.Drawing.Point(28, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 32F);
            this.label4.Location = new System.Drawing.Point(357, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 52);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mayoreo";
            // 
            // tbLista
            // 
            this.tbLista.Font = new System.Drawing.Font("Tahoma", 50F);
            this.tbLista.Location = new System.Drawing.Point(336, 85);
            this.tbLista.Name = "tbLista";
            this.tbLista.ReadOnly = true;
            this.tbLista.Size = new System.Drawing.Size(309, 88);
            this.tbLista.TabIndex = 6;
            this.tbLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMayoreo
            // 
            this.tbMayoreo.Font = new System.Drawing.Font("Tahoma", 50F);
            this.tbMayoreo.Location = new System.Drawing.Point(11, 86);
            this.tbMayoreo.Name = "tbMayoreo";
            this.tbMayoreo.ReadOnly = true;
            this.tbMayoreo.Size = new System.Drawing.Size(309, 88);
            this.tbMayoreo.TabIndex = 7;
            this.tbMayoreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMayoreo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbLista);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 24F);
            this.groupBox1.Location = new System.Drawing.Point(12, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 186);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precios";
            // 
            // lbArticulo
            // 
            this.lbArticulo.Font = new System.Drawing.Font("Tahoma", 36F);
            this.lbArticulo.Location = new System.Drawing.Point(12, 112);
            this.lbArticulo.Name = "lbArticulo";
            this.lbArticulo.Size = new System.Drawing.Size(656, 249);
            this.lbArticulo.TabIndex = 9;
            this.lbArticulo.Text = "ARTICULO_NOMBRE";
            this.lbArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 563);
            this.Controls.Add(this.lbArticulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Precios por Articulos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLista;
        private System.Windows.Forms.TextBox tbMayoreo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbArticulo;

    }
}

