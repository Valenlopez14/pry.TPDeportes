namespace pry.BaseDeDatos.LopezV
{
    partial class frmConsultaDeportista
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
            this.GrillaConsultaDepor = new System.Windows.Forms.DataGridView();
            this.cmdListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaConsultaDepor)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaConsultaDepor
            // 
            this.GrillaConsultaDepor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaConsultaDepor.Location = new System.Drawing.Point(1, 1);
            this.GrillaConsultaDepor.Name = "GrillaConsultaDepor";
            this.GrillaConsultaDepor.Size = new System.Drawing.Size(393, 335);
            this.GrillaConsultaDepor.TabIndex = 0;
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(308, 344);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(75, 23);
            this.cmdListar.TabIndex = 1;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // frmConsultaDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 379);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.GrillaConsultaDepor);
            this.Name = "frmConsultaDeportista";
            this.Text = "frmConsultaDeportista";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaConsultaDepor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaConsultaDepor;
        private System.Windows.Forms.Button cmdListar;
    }
}