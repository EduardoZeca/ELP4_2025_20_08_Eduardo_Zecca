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
        Controller aCtrl;
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
            //if(Message("Confirma (S/N)") == "S") { 
                aCidade.Codigo = Convert.ToInt32(txtCodigo.Text);
                aCidade.Cidade = txtCidade.Text;
                aCidade.Ddd = txtDDD.Text;
                aCidade.OEstado.Estado = txtEstado.Text;
            //aCtrl.Salvar(aCidade);
            //}
        }
        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(aCidade.Codigo);
            this.txtCidade.Text = aCidade.Cidade;
            this.txtDDD.Text = aCidade.Ddd;
            this.txtEstado.Text = aCidade.OEstado.Estado;
        }
        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtCidade.Clear();
            this.txtDDD.Clear();
            this.txtEstado.Clear();
        }
        public override void BloquearTxt()
        {
            this.txtEstado.Enabled = false;
            this.txtCidade.Enabled = false;
            this.txtDDD.Enabled = false;
        }
        public override void DesbloquearTxt()
        {
            this.txtEstado.Enabled = true;
            this.txtCidade.Enabled = true;
            this.txtDDD.Enabled = true;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                aCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }
    }
}
