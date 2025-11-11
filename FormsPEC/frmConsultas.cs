using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsPEC
{
    public partial class frmConsultas : FormsPEC.Frm
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        protected virtual void Incluir()
        {

        }
        protected virtual void Alterar()
        {

        }
        protected virtual void Excluir()
        {

        }
        protected virtual void Pesquisar()
        {

        }
        protected virtual void CarregaLV(string chave)
        { 
        
        }
        public virtual void setFrmCadastro(object obj)
        {
        
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}
