using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsPEC
{
    public partial class frmCadEstados : FormsPEC.frmCadastros
    {
        Estados oEstado;
        frmConsPaises oFrmConsPaises;
        Controller aCtrl;
        public frmCadEstados()
        {
            InitializeComponent();
        }
        public void setFrmConsPaises(object obj)
        {
            if (obj != null)
                oFrmConsPaises = (frmConsPaises)obj;
        }
        public override void Salvar()
        {
            //if(Message("Confirma (S/N)") == "S") { 
                oEstado.Codigo = Convert.ToInt32(txtCodigo.Text);
                oEstado.Estado = txtEstado.Text;
                oEstado.Uf = txtUF.Text;
                oEstado.OPais.Pais = txtPais.Text;
                //aCtrl.Salvar(oEstado);
            //}
        }
        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oEstado.Codigo);
            this.txtPais.Text = oEstado.OPais.Pais;
            this.txtEstado.Text = oEstado.Estado;
            this.txtUF.Text = oEstado.Uf;
        }
        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtPais.Clear();
            this.txtEstado.Clear();
            this.txtUF.Clear();
        }
        public override void BloquearTxt()
        {
            this.txtPais.Enabled = false;
            this.txtEstado.Enabled = false;
            this.txtUF.Enabled = false;
        }
        public override void DesbloquearTxt()
        {
            this.txtPais.Enabled = true;
            this.txtEstado.Enabled = true;
            this.txtUF.Enabled = true;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string btnSair = oFrmConsPaises.btnSair.Text;
            oFrmConsPaises.btnSair.Text = "Selecionar";
            oFrmConsPaises.ConhecaObj(oEstado.OPais, aCtrl);
            oFrmConsPaises.ShowDialog();
            this.txtCodigoPais.Text = Convert.ToString(oEstado.OPais.Codigo);
            this.txtPais.Text = Convert.ToString(oEstado.OPais.Pais);
            oFrmConsPaises.btnSair.Text = btnSair;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if(obj != null)
                oEstado = (Estados)obj;
            if(ctrl != null)
                aCtrl = (Controller)ctrl;
        }
    }
}
