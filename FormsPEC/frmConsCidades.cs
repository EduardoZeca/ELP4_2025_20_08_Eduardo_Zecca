using System;
using System.Collections;
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
        CtrlCidades aCtrlCidades;
        public frmConsCidades()
        {
            InitializeComponent();
        }
        protected override void Incluir()
        {
            oFrmCadCidades.ConhecaObj(aCidade, aCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.ShowDialog();
            this.CarregaLV("");
        }
        protected override void Alterar()
        {
            int codSelecionado = Convert.ToInt32(listV.SelectedItems[0].SubItems[0].Text);
            aCidade = (Cidades)aCtrlCidades.CarregaObj(codSelecionado);
            oFrmCadCidades.ConhecaObj(aCidade, aCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
            this.CarregaLV("");
        }
        protected override void Excluir()
        {
            int codSelecionado = Convert.ToInt32(listV.SelectedItems[0].SubItems[0].Text);
            aCidade = (Cidades)aCtrlCidades.CarregaObj(codSelecionado);
            string aux;

            oFrmCadCidades.ConhecaObj(aCidade, aCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.BloquearTxt();

            aux = oFrmCadCidades.btnSalvar.Text;
            oFrmCadCidades.btnSalvar.Text = "Excluir";

            oFrmCadCidades.ShowDialog();
            oFrmCadCidades.DesbloquearTxt();

            oFrmCadCidades.btnSalvar.Text = aux;
            this.CarregaLV("");
        }
        protected override void CarregaLV(string chave)
        {
            listV.Items.Clear();
            foreach (var aCidade in aCtrlCidades.Listar())
            {
                ListViewItem item = new ListViewItem(Convert.ToString(aCidade.Codigo));
                item.SubItems.Add(aCidade.Cidade);
                item.SubItems.Add(aCidade.Ddd);
                item.SubItems.Add(aCidade.OEstado.Codigo.ToString());
                item.SubItems.Add(aCidade.OEstado.Estado);
                listV.Items.Add(item);
            }
        }
        protected override void Pesquisar()
        {
            this.CarregaLV("");
        }
        public override void setFrmCadastro(object obj)
        {
            if (obj != null)
                oFrmCadCidades = (frmCadCidades)obj;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                aCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrlCidades = (CtrlCidades)ctrl;
            this.CarregaLV("");
        }
    }
}
