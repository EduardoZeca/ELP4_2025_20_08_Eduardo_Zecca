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
        CtrlEstados aCtrlEstados;
        
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
            oEstado.Codigo = Convert.ToInt32(txtCodigo.Text);
            oEstado.Estado = txtEstado.Text;
            oEstado.Uf = txtUF.Text;
            oEstado.OPais.Pais = txtPais.Text;
            oEstado.OPais.Codigo = Convert.ToInt32(txtCodigoPais.Text);
            if (this.btnSalvar.Text == "Excluir")
                MessageBox.Show(aCtrlEstados.Excluir(oEstado));
            else
                //aCtrlEstados.Salvar(oEstado);
                MessageBox.Show(aCtrlEstados.Salvar(oEstado.Clone()));
        }
        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oEstado.Codigo);
            this.txtPais.Text = oEstado.OPais.Pais;
            this.txtEstado.Text = oEstado.Estado;
            this.txtUF.Text = oEstado.Uf;
            this.txtCodigoPais.Text = Convert.ToString(oEstado.OPais.Codigo);
        }
        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtPais.Clear();
            this.txtEstado.Clear();
            this.txtUF.Clear();
            this.txtCodigoPais.Text = "0";
        }
        public override void BloquearTxt()
        {
            this.txtPais.Enabled = false;
            this.txtEstado.Enabled = false;
            this.txtUF.Enabled = false;
            this.txtCodigoPais.Enabled = false;
            this.btnBuscar.Enabled = false;
        }
        public override void DesbloquearTxt()
        {
            this.txtPais.Enabled = true;
            this.txtEstado.Enabled = true;
            this.txtUF.Enabled = true;
            this.txtCodigoPais.Enabled = true;
            this.btnBuscar.Enabled = true;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string btnSair = oFrmConsPaises.btnSair.Text;
            oFrmConsPaises.btnSair.Text = "Selecionar";
            oFrmConsPaises.ConhecaObj(oEstado.OPais, aCtrlEstados.ACtrlPaises);
            oFrmConsPaises.ShowDialog();
            this.txtCodigoPais.Text = Convert.ToString(oEstado.OPais.Codigo);
            this.txtPais.Text = Convert.ToString(oEstado.OPais.Pais);
            oFrmConsPaises.btnSair.Text = btnSair;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oEstado = (Estados)obj;
            if (ctrl != null)
                aCtrlEstados = (CtrlEstados)ctrl;
        }
    }
}
