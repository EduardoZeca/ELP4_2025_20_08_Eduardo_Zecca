using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsPEC
{
    public partial class frmConsPaises : FormsPEC.frmConsultas
    {
        frmCadPaises oFrmCadPaises;
        Paises oPais;
        CtrlPaises aCtrlPaises;
        //Controller aCtrl;
        public frmConsPaises()
        {
            InitializeComponent();
        }
        protected override void Incluir()
        {
            oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.ShowDialog();
            this.CarregaLV();
        }
        protected override void Alterar()
        {
            oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
            this.CarregaLV();
        }
        protected override void Excluir()
        {
            string aux;
            
            oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.BloquearTxt();

            aux = oFrmCadPaises.btnSalvar.Text;
            oFrmCadPaises.btnSalvar.Text = "Excluir";
            
            oFrmCadPaises.ShowDialog();
            oFrmCadPaises.DesbloquearTxt();

            oFrmCadPaises.btnSalvar.Text = aux;
            this.CarregaLV();
        }
        protected override void CarregaLV()
        {
            listV.Items.Clear();
            foreach (Paises pais in aCtrlPaises.Listar())
            {
                ListViewItem item = new ListViewItem(Convert.ToString(pais.Codigo));
                item.SubItems.Add(pais.Pais);
                item.SubItems.Add(pais.Sigla);
                item.SubItems.Add(pais.Ddi);
                item.SubItems.Add(pais.Moeda);
                listV.Items.Add(item);
            }
        }
        protected override void Pesquisar()
        {
            //aCtrlPaises.Buscar();
        }
        public override void setFrmCadastro(object obj)
        {
            if(obj != null)
                oFrmCadPaises = (frmCadPaises)obj;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if(obj != null)
                oPais = (Paises)obj;
            if(ctrl != null)
                aCtrlPaises = (CtrlPaises)ctrl;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}
