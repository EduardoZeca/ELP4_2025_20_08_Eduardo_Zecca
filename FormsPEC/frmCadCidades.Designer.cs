namespace FormsPEC
{
    partial class frmCadCidades
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblDDD = new System.Windows.Forms.Label();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCodEstado = new System.Windows.Forms.Label();
            this.txtCodigoEstado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Size = new System.Drawing.Size(72, 22);
            this.txtCodigo.TabIndex = 10;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(448, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 16);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(110, 9);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(51, 16);
            this.lblCidade.TabIndex = 11;
            this.lblCidade.Text = "Cidade";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(319, 9);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(37, 16);
            this.lblDDD.TabIndex = 12;
            this.lblDDD.Text = "DDD";
            // 
            // txtDDD
            // 
            this.txtDDD.Location = new System.Drawing.Point(321, 24);
            this.txtDDD.MaxLength = 4;
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(48, 22);
            this.txtDDD.TabIndex = 2;
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(450, 24);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(174, 22);
            this.txtEstado.TabIndex = 4;
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(110, 24);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(199, 22);
            this.txtCidade.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(636, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 24);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCodEstado
            // 
            this.lblCodEstado.AutoSize = true;
            this.lblCodEstado.Location = new System.Drawing.Point(377, 9);
            this.lblCodEstado.Name = "lblCodEstado";
            this.lblCodEstado.Size = new System.Drawing.Size(51, 16);
            this.lblCodEstado.TabIndex = 17;
            this.lblCodEstado.Text = "Codigo";
            // 
            // txtCodigoEstado
            // 
            this.txtCodigoEstado.Location = new System.Drawing.Point(380, 24);
            this.txtCodigoEstado.MaxLength = 3;
            this.txtCodigoEstado.Name = "txtCodigoEstado";
            this.txtCodigoEstado.Size = new System.Drawing.Size(59, 22);
            this.txtCodigoEstado.TabIndex = 3;
            this.txtCodigoEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmCadCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigoEstado);
            this.Controls.Add(this.lblCodEstado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEstado);
            this.Name = "frmCadCidades";
            this.Text = " Cadastro de Cidades";
            this.Controls.SetChildIndex(this.txtDatCad, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lbl_Codigo, 0);
            this.Controls.SetChildIndex(this.txtUltAlt, 0);
            this.Controls.SetChildIndex(this.txtCodUsu, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.lblCidade, 0);
            this.Controls.SetChildIndex(this.lblDDD, 0);
            this.Controls.SetChildIndex(this.txtDDD, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.lblCodEstado, 0);
            this.Controls.SetChildIndex(this.txtCodigoEstado, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCodEstado;
        private System.Windows.Forms.TextBox txtCodigoEstado;
    }
}
