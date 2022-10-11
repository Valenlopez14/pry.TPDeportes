namespace pry.BaseDeDatos.LopezV
{
    partial class frmConsultaEntrenador
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
            this.GrillaConsultaEntr = new System.Windows.Forms.DataGridView();
            this.cmdListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaConsultaEntr)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaConsultaEntr
            // 
            this.GrillaConsultaEntr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaConsultaEntr.Location = new System.Drawing.Point(0, 0);
            this.GrillaConsultaEntr.Name = "GrillaConsultaEntr";
            this.GrillaConsultaEntr.Size = new System.Drawing.Size(393, 335);
            this.GrillaConsultaEntr.TabIndex = 1;
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(308, 353);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(75, 23);
            this.cmdListar.TabIndex = 2;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // frmConsultaEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 388);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.GrillaConsultaEntr);
            this.Name = "frmConsultaEntrenador";
            this.Text = "frmConsultaEntrenador";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaConsultaEntr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaConsultaEntr;
        private System.Windows.Forms.Button cmdListar;
    }
}