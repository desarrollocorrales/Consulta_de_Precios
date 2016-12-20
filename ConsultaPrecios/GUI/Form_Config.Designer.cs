namespace ConsultaPrecios.GUI
{
    partial class Form_Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbServidor = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.tbPuerto = new System.Windows.Forms.TextBox();
            this.tbBaseDatos = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMayoreo = new System.Windows.Forms.ComboBox();
            this.cbLista = new System.Windows.Forms.ComboBox();
            this.cbAlmacen = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(527, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configuración de Conexión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Servidor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Puerto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label6.Location = new System.Drawing.Point(12, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Base de Datos:";
            // 
            // tbServidor
            // 
            this.tbServidor.Font = new System.Drawing.Font("Tahoma", 20F);
            this.tbServidor.Location = new System.Drawing.Point(207, 60);
            this.tbServidor.Name = "tbServidor";
            this.tbServidor.Size = new System.Drawing.Size(520, 40);
            this.tbServidor.TabIndex = 7;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Tahoma", 20F);
            this.tbUsuario.Location = new System.Drawing.Point(207, 106);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(520, 40);
            this.tbUsuario.TabIndex = 8;
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Font = new System.Drawing.Font("Tahoma", 20F);
            this.tbContrasenia.Location = new System.Drawing.Point(207, 152);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.PasswordChar = '*';
            this.tbContrasenia.Size = new System.Drawing.Size(520, 40);
            this.tbContrasenia.TabIndex = 9;
            // 
            // tbPuerto
            // 
            this.tbPuerto.Font = new System.Drawing.Font("Tahoma", 20F);
            this.tbPuerto.Location = new System.Drawing.Point(207, 198);
            this.tbPuerto.Name = "tbPuerto";
            this.tbPuerto.Size = new System.Drawing.Size(520, 40);
            this.tbPuerto.TabIndex = 10;
            // 
            // tbBaseDatos
            // 
            this.tbBaseDatos.Font = new System.Drawing.Font("Tahoma", 20F);
            this.tbBaseDatos.Location = new System.Drawing.Point(207, 244);
            this.tbBaseDatos.Name = "tbBaseDatos";
            this.tbBaseDatos.Size = new System.Drawing.Size(520, 40);
            this.tbBaseDatos.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 20.25F);
            this.button2.Location = new System.Drawing.Point(527, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 61);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cargar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label7.Location = new System.Drawing.Point(12, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 33);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mayoreo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label8.Location = new System.Drawing.Point(12, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 33);
            this.label8.TabIndex = 14;
            this.label8.Text = "Lista:";
            // 
            // cbMayoreo
            // 
            this.cbMayoreo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMayoreo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMayoreo.FormattingEnabled = true;
            this.cbMayoreo.Location = new System.Drawing.Point(207, 303);
            this.cbMayoreo.Name = "cbMayoreo";
            this.cbMayoreo.Size = new System.Drawing.Size(294, 41);
            this.cbMayoreo.TabIndex = 15;
            // 
            // cbLista
            // 
            this.cbLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLista.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLista.FormattingEnabled = true;
            this.cbLista.Location = new System.Drawing.Point(207, 352);
            this.cbLista.Name = "cbLista";
            this.cbLista.Size = new System.Drawing.Size(294, 41);
            this.cbLista.TabIndex = 16;
            // 
            // cbAlmacen
            // 
            this.cbAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlmacen.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlmacen.FormattingEnabled = true;
            this.cbAlmacen.Location = new System.Drawing.Point(207, 421);
            this.cbAlmacen.Name = "cbAlmacen";
            this.cbAlmacen.Size = new System.Drawing.Size(294, 41);
            this.cbAlmacen.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label9.Location = new System.Drawing.Point(12, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 33);
            this.label9.TabIndex = 17;
            this.label9.Text = "Almacen:";
            // 
            // Form_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 611);
            this.Controls.Add(this.cbAlmacen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbLista);
            this.Controls.Add(this.cbMayoreo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbBaseDatos);
            this.Controls.Add(this.tbPuerto);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbServidor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Config";
            this.Load += new System.EventHandler(this.Form_Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbServidor;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.TextBox tbPuerto;
        private System.Windows.Forms.TextBox tbBaseDatos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMayoreo;
        private System.Windows.Forms.ComboBox cbLista;
        private System.Windows.Forms.ComboBox cbAlmacen;
        private System.Windows.Forms.Label label9;
    }
}