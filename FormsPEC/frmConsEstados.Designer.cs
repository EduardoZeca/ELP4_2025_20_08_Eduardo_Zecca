namespace FormsPEC
{
    partial class frmConsEstados
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
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(398, 394);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(494, 394);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(590, 394);
            // 
            // listV
            // 
            this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEstado,
            this.colUF,
            this.colCodPais,
            this.colPais});
            this.listV.SelectedIndexChanged += new System.EventHandler(this.listV_SelectedIndexChanged);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(686, 394);
            this.btnSair.Size = new System.Drawing.Size(89, 30);
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            this.colEstado.Width = 200;
            // 
            // colUF
            // 
            this.colUF.Text = "UF";
            this.colUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colCodPais
            // 
            this.colCodPais.Text = "Codigo Pais";
            this.colCodPais.Width = 90;
            // 
            // colPais
            // 
            this.colPais.Text = "Pais";
            this.colPais.Width = 200;
            // 
            // frmConsEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmConsEstados";
            this.Text = "Consulta de Estados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ColumnHeader colEstado;
        protected System.Windows.Forms.ColumnHeader colUF;
        protected System.Windows.Forms.ColumnHeader colCodPais;
        protected System.Windows.Forms.ColumnHeader colPais;
    }
}
