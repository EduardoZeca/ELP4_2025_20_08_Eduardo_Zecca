using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsPEC
{
    public partial class frmCadastros : FormsPEC.Frm
    {
        public frmCadastros()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            Sair();
        }
        public virtual void Salvar()
        {
        }
        public virtual void CarregaTxt()
        {
        }
        public virtual void LimpaTxt()
        {
        }
        public virtual void BloquearTxt()
        {
        }
        public virtual void DesbloquearTxt()
        {
        }
    }
}
