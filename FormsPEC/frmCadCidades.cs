using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsPEC
{
    public partial class frmCadCidades : FormsPEC.frmCadastros
    {
        Cidades aCidade;
        frmConsEstados oFrmConsEstados;
        CtrlCidades aCtrlCidades;
        public frmCadCidades()
        {
            InitializeComponent();
        }
        public void setFrmConsEstados(object obj)
        {
            if (obj != null)
                oFrmConsEstados = (frmConsEstados)obj;
        }
        public override void Salvar()
        { 
            aCidade.Codigo = Convert.ToInt32(txtCodigo.Text);
            aCidade.Cidade = txtCidade.Text;
            aCidade.Ddd = txtDDD.Text;
            aCidade.OEstado.Estado = txtEstado.Text;
            aCidade.OEstado.Codigo = Convert.ToInt32(txtCodigoEstado.Text);
            if (this.btnSalvar.Text == "Excluir")
            {
                MessageBox.Show("Deseja realmente excluir a cidade " + aCidade.Cidade + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                MessageBox.Show(aCtrlCidades.Excluir(aCidade));
            }
            else
                //aCtrlPaises.Salvar(oPais);
                MessageBox.Show(aCtrlCidades.Salvar(aCidade.Clone()));
        }
        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(aCidade.Codigo);
            this.txtCidade.Text = aCidade.Cidade;
            this.txtDDD.Text = aCidade.Ddd;
            this.txtEstado.Text = aCidade.OEstado.Estado;
            this.txtCodigoEstado.Text = Convert.ToString(aCidade.OEstado.Codigo);
        }
        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtCidade.Clear();
            this.txtDDD.Clear();
            this.txtEstado.Clear();
            this.txtCodigoEstado.Text = "0";
        }
        public override void BloquearTxt()
        {
            this.txtEstado.Enabled = false;
            this.txtCidade.Enabled = false;
            this.txtDDD.Enabled = false;
            this.btnBuscar.Enabled = false;
            this.txtCodigoEstado.Enabled = false;
            this.txtEstado.Enabled = false;
        }
        public override void DesbloquearTxt()
        {
            this.txtEstado.Enabled = true;
            this.txtCidade.Enabled = true;
            this.txtDDD.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.txtCodigoEstado.Enabled = true;
            this.txtCodigoEstado.Enabled = true;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                aCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrlCidades = (CtrlCidades)ctrl;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string btnSair = oFrmConsEstados.btnSair.Text;
            oFrmConsEstados.btnSair.Text = "Selecionar";
            oFrmConsEstados.ConhecaObj(aCidade.OEstado, aCtrlCidades.ACtrlEstados);
            oFrmConsEstados.ShowDialog();
            this.txtCodigoEstado.Text = Convert.ToString(aCidade.OEstado.Codigo);
            this.txtEstado.Text = Convert.ToString(aCidade.OEstado.Estado);
            oFrmConsEstados.btnSair.Text = btnSair;
        }
    }
}
