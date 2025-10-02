namespace FormsPEC
{
    partial class frmCadEstados
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
            this.lblPais = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblCodPais = new System.Windows.Forms.Label();
            this.txtCodigoPais = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 6;
            // 
            // txtUltAlt
            // 
            this.txtUltAlt.TabIndex = 16;
            // 
            // txtCodUsu
            // 
            this.txtCodUsu.TabIndex = 17;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Size = new System.Drawing.Size(80, 22);
            this.txtCodigo.TabIndex = 10;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 7;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(471, 9);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 16);
            this.lblPais.TabIndex = 10;
            this.lblPais.Text = "Pais";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(115, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 16);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(322, 9);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(25, 16);
            this.lblUF.TabIndex = 12;
            this.lblUF.Text = "UF";
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Enabled = false;
            this.txtPais.Location = new System.Drawing.Point(474, 24);
            this.txtPais.MaxLength = 55;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(162, 22);
            this.txtPais.TabIndex = 4;
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(118, 24);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(196, 22);
            this.txtEstado.TabIndex = 1;
            // 
            // txtUF
            // 
            this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUF.Location = new System.Drawing.Point(325, 24);
            this.txtUF.MaxLength = 3;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(57, 22);
            this.txtUF.TabIndex = 2;
            // 
            // lblCodPais
            // 
            this.lblCodPais.AutoSize = true;
            this.lblCodPais.Location = new System.Drawing.Point(392, 9);
            this.lblCodPais.Name = "lblCodPais";
            this.lblCodPais.Size = new System.Drawing.Size(51, 16);
            this.lblCodPais.TabIndex = 16;
            this.lblCodPais.Text = "Codigo";
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.Enabled = false;
            this.txtCodigoPais.Location = new System.Drawing.Point(393, 24);
            this.txtCodigoPais.MaxLength = 3;
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.Size = new System.Drawing.Size(66, 22);
            this.txtCodigoPais.TabIndex = 3;
            this.txtCodigoPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(649, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 27);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmCadEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigoPais);
            this.Controls.Add(this.lblCodPais);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPais);
            this.Name = "frmCadEstados";
            this.Text = " Cadastro de Estados";
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
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.lblUF, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.txtUF, 0);
            this.Controls.SetChildIndex(this.lblCodPais, 0);
            this.Controls.SetChildIndex(this.txtCodigoPais, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblCodPais;
        private System.Windows.Forms.TextBox txtCodigoPais;
        private System.Windows.Forms.Button btnBuscar;
    }
}
