using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsPEC
{
    public partial class frmConsCidades : FormsPEC.frmConsultas
    {
        frmCadCidades oFrmCadCidades;
        Cidades aCidade;
        Controller<Cidades> aCtrl;
        public frmConsCidades()
        {
            InitializeComponent();
        }
        protected override void Incluir()
        {
            oFrmCadCidades.ConhecaObj(aCidade, aCtrl);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.ShowDialog();
            this.CarregaLV();
        }
        protected override void Alterar()
        {
            oFrmCadCidades.ConhecaObj(aCidade, aCtrl);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
        }
        protected override void Excluir()
        {
            string aux;

            oFrmCadCidades.ConhecaObj(aCidade, aCtrl);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.BloquearTxt();

            aux = oFrmCadCidades.btnSalvar.Text;
            oFrmCadCidades.btnSalvar.Text = "Excluir";

            oFrmCadCidades.ShowDialog();
            oFrmCadCidades.DesbloquearTxt();

            oFrmCadCidades.btnSalvar.Text = aux;
        }
        protected override void CarregaLV()
        {
            ListViewItem item = new ListViewItem(Convert.ToString(aCidade.Codigo));
            item.SubItems.Add(aCidade.Cidade);
            item.SubItems.Add(aCidade.Ddd);
            item.SubItems.Add(Convert.ToString(aCidade.OEstado.Codigo));
            item.SubItems.Add(aCidade.OEstado.Estado);
            listV.Items.Add(item);
        }
        protected override void Pesquisar()
        {

        }
        public override void setFrmCadastro(object obj)
        {
            if (obj != null)
                oFrmCadCidades = (frmCadCidades)obj;
        }
        //public override void ConhecaObj(object obj, object ctrl)
        //{
        //    if (obj != null)
        //        aCidade = (Cidades)obj;
        //    if (ctrl != null)
        //        aCtrl = (Controller)ctrl;
        //}
    }
}
