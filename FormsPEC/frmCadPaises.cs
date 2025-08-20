using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsPEC
{
    public partial class frmCadPaises : FormsPEC.frmCadastros
    {
        Paises oPais;
        Controller aCtrl;
        public frmCadPaises()
        {
            InitializeComponent();
        }
        public override void Salvar()
        {
            //if(Message("Confirma (S/N)") == "S") { 
                oPais.Codigo = Convert.ToInt32(txtCodigo.Text);
                oPais.Pais = txtPais.Text;
                oPais.Sigla = txtSigla.Text;
                oPais.Ddi = txtDDI.Text;
                oPais.Moeda = txtMoeda.Text;
                //aCtrl.Salvar(oPais);
            //}
        }
        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oPais.Codigo);
            this.txtPais.Text = oPais.Pais;
            this.txtSigla.Text = oPais.Sigla;
            this.txtDDI.Text = oPais.Ddi;
            this.txtMoeda.Text = oPais.Moeda;
        }
        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtPais.Clear();
            this.txtSigla.Clear();
            this.txtDDI.Clear();
            this.txtMoeda.Clear();
        }
        public override void BloquearTxt()
        {
            this.txtPais.Enabled = false;
            this.txtSigla.Enabled = false;
            this.txtDDI.Enabled = false;
            this.txtMoeda.Enabled = false;
        }
        public override void DesbloquearTxt()
        {
            this.txtPais.Enabled = true;
            this.txtSigla.Enabled = true;
            this.txtDDI.Enabled = true;
            this.txtMoeda.Enabled = true;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if(obj != null)
                oPais = (Paises)obj;
            if(ctrl != null)
                aCtrl = (Controller)ctrl;
        }
    }
}
