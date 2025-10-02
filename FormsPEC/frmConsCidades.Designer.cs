namespace FormsPEC
{
    partial class frmConsCidades
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
            this.colCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(395, 394);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(491, 394);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(587, 394);
            // 
            // listV
            // 
            this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCidade,
            this.colDdd,
            this.colCodEstado,
            this.colEstado});
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(683, 394);
            this.btnSair.Size = new System.Drawing.Size(92, 30);
            // 
            // colCidade
            // 
            this.colCidade.Text = "Cidade";
            this.colCidade.Width = 200;
            // 
            // colDdd
            // 
            this.colDdd.Text = "DDD";
            this.colDdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colCodEstado
            // 
            this.colCodEstado.Text = "Codigo Estado";
            this.colCodEstado.Width = 110;
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            this.colEstado.Width = 200;
            // 
            // frmConsCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmConsCidades";
            this.Text = "Consulta de Cidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ColumnHeader colCidade;
        protected System.Windows.Forms.ColumnHeader colDdd;
        protected System.Windows.Forms.ColumnHeader colCodEstado;
        protected System.Windows.Forms.ColumnHeader colEstado;
    }
}
