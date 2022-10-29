namespace pry.BaseDeDatos.LopezV
{
    partial class frmModificarEntrenador
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
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.lblCodigoEntrenador = new System.Windows.Forms.Label();
            this.lblCodigoEntrenadorBusq = new System.Windows.Forms.Label();
            this.lblNombreEntr = new System.Windows.Forms.Label();
            this.lblApellidoEntr = new System.Windows.Forms.Label();
            this.lblDireccionEntr = new System.Windows.Forms.Label();
            this.lblProvinciaEntr = new System.Windows.Forms.Label();
            this.lblDeporteEntr = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(194, 55);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 0;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(194, 337);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.TabIndex = 1;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // lblCodigoEntrenador
            // 
            this.lblCodigoEntrenador.AutoSize = true;
            this.lblCodigoEntrenador.BackColor = System.Drawing.Color.White;
            this.lblCodigoEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEntrenador.Location = new System.Drawing.Point(8, 12);
            this.lblCodigoEntrenador.Name = "lblCodigoEntrenador";
            this.lblCodigoEntrenador.Size = new System.Drawing.Size(127, 15);
            this.lblCodigoEntrenador.TabIndex = 2;
            this.lblCodigoEntrenador.Text = "Codigo Entrenador";
            // 
            // lblCodigoEntrenadorBusq
            // 
            this.lblCodigoEntrenadorBusq.AutoSize = true;
            this.lblCodigoEntrenadorBusq.BackColor = System.Drawing.Color.White;
            this.lblCodigoEntrenadorBusq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEntrenadorBusq.Location = new System.Drawing.Point(8, 102);
            this.lblCodigoEntrenadorBusq.Name = "lblCodigoEntrenadorBusq";
            this.lblCodigoEntrenadorBusq.Size = new System.Drawing.Size(127, 15);
            this.lblCodigoEntrenadorBusq.TabIndex = 3;
            this.lblCodigoEntrenadorBusq.Text = "Codigo Entrenador";
            // 
            // lblNombreEntr
            // 
            this.lblNombreEntr.AutoSize = true;
            this.lblNombreEntr.BackColor = System.Drawing.Color.White;
            this.lblNombreEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEntr.Location = new System.Drawing.Point(8, 140);
            this.lblNombreEntr.Name = "lblNombreEntr";
            this.lblNombreEntr.Size = new System.Drawing.Size(58, 15);
            this.lblNombreEntr.TabIndex = 4;
            this.lblNombreEntr.Text = "Nombre";
            // 
            // lblApellidoEntr
            // 
            this.lblApellidoEntr.AutoSize = true;
            this.lblApellidoEntr.BackColor = System.Drawing.Color.White;
            this.lblApellidoEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEntr.Location = new System.Drawing.Point(8, 178);
            this.lblApellidoEntr.Name = "lblApellidoEntr";
            this.lblApellidoEntr.Size = new System.Drawing.Size(59, 15);
            this.lblApellidoEntr.TabIndex = 5;
            this.lblApellidoEntr.Text = "Apellido";
            // 
            // lblDireccionEntr
            // 
            this.lblDireccionEntr.AutoSize = true;
            this.lblDireccionEntr.BackColor = System.Drawing.Color.White;
            this.lblDireccionEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionEntr.Location = new System.Drawing.Point(8, 216);
            this.lblDireccionEntr.Name = "lblDireccionEntr";
            this.lblDireccionEntr.Size = new System.Drawing.Size(68, 15);
            this.lblDireccionEntr.TabIndex = 6;
            this.lblDireccionEntr.Text = "Direccion";
            // 
            // lblProvinciaEntr
            // 
            this.lblProvinciaEntr.AutoSize = true;
            this.lblProvinciaEntr.BackColor = System.Drawing.Color.White;
            this.lblProvinciaEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvinciaEntr.Location = new System.Drawing.Point(8, 254);
            this.lblProvinciaEntr.Name = "lblProvinciaEntr";
            this.lblProvinciaEntr.Size = new System.Drawing.Size(66, 15);
            this.lblProvinciaEntr.TabIndex = 7;
            this.lblProvinciaEntr.Text = "Provincia";
            // 
            // lblDeporteEntr
            // 
            this.lblDeporteEntr.AutoSize = true;
            this.lblDeporteEntr.BackColor = System.Drawing.Color.White;
            this.lblDeporteEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporteEntr.Location = new System.Drawing.Point(8, 292);
            this.lblDeporteEntr.Name = "lblDeporteEntr";
            this.lblDeporteEntr.Size = new System.Drawing.Size(58, 15);
            this.lblDeporteEntr.TabIndex = 8;
            this.lblDeporteEntr.Text = "Deporte";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox1.Location = new System.Drawing.Point(157, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox2.Location = new System.Drawing.Point(157, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox3.Location = new System.Drawing.Point(157, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox4.Location = new System.Drawing.Point(157, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox5.Location = new System.Drawing.Point(157, 212);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox6.Location = new System.Drawing.Point(157, 250);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox7.Location = new System.Drawing.Point(157, 288);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 15;
            // 
            // frmModificarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 372);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDeporteEntr);
            this.Controls.Add(this.lblProvinciaEntr);
            this.Controls.Add(this.lblDireccionEntr);
            this.Controls.Add(this.lblApellidoEntr);
            this.Controls.Add(this.lblNombreEntr);
            this.Controls.Add(this.lblCodigoEntrenadorBusq);
            this.Controls.Add(this.lblCodigoEntrenador);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdBuscar);
            this.Name = "frmModificarEntrenador";
            this.Text = "ModificarEntrenador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label lblCodigoEntrenador;
        private System.Windows.Forms.Label lblCodigoEntrenadorBusq;
        private System.Windows.Forms.Label lblNombreEntr;
        private System.Windows.Forms.Label lblApellidoEntr;
        private System.Windows.Forms.Label lblDireccionEntr;
        private System.Windows.Forms.Label lblProvinciaEntr;
        private System.Windows.Forms.Label lblDeporteEntr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}