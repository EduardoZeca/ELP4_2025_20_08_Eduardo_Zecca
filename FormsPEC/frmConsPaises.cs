using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormsPEC
{
    public partial class frmConsPaises : FormsPEC.frmConsultas
    {
        frmCadPaises oFrmCadPaises;
        Paises oPais;
        CtrlPaises aCtrlPaises;
        public frmConsPaises()
        {
            InitializeComponent();
        }
        protected override void Incluir()
        {
            oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.ShowDialog();
            this.CarregaLV("");
        }
        protected override void Alterar()
        {
            int codSelecionado = Convert.ToInt32(listV.SelectedItems[0].SubItems[0].Text);
            oPais = (Paises)aCtrlPaises.CarregaObj(codSelecionado);
            oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
            this.CarregaLV("");
        }
        protected override void Excluir()
        {
            string aux;
            int codSelecionado = Convert.ToInt32(listV.SelectedItems[0].SubItems[0].Text);
            oPais = (Paises)aCtrlPaises.CarregaObj(codSelecionado);

            oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.BloquearTxt();

            aux = oFrmCadPaises.btnSalvar.Text;
            oFrmCadPaises.btnSalvar.Text = "Excluir";
            
            oFrmCadPaises.ShowDialog();
            oFrmCadPaises.DesbloquearTxt();

            oFrmCadPaises.btnSalvar.Text = aux;
            this.CarregaLV("");
        }
        protected override void CarregaLV(string chave)
        {
            if (chave == "")
            {
                listV.Items.Clear();
                foreach (Paises pais in aCtrlPaises.Listar())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(pais.Codigo));
                    item.SubItems.Add(pais.Pais);
                    item.SubItems.Add(pais.Sigla);
                    item.SubItems.Add(pais.Ddi);
                    item.SubItems.Add(pais.Moeda);
                    item.Tag = pais;
                    listV.Items.Add(item);
                }
            } else
            {
                listV.Items.Clear();
                foreach (Paises pais in aCtrlPaises.Pesquisar(chave))
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(pais.Codigo));
                    item.SubItems.Add(pais.Pais);
                    item.SubItems.Add(pais.Sigla);
                    item.SubItems.Add(pais.Ddi);
                    item.SubItems.Add(pais.Moeda);
                    listV.Items.Add(item);
                }
            }
        }
        protected override void Pesquisar()
        {
            this.CarregaLV(txtCodigo.Text);
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
            this.CarregaLV("");
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void listV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listV.SelectedItems.Count > 0)
            {
                ListViewItem item = this.listV.SelectedItems[0];
                Paises paisSelecionado = (Paises)item.Tag;
                oPais.Codigo = paisSelecionado.Codigo;
                oPais.Pais = paisSelecionado.Pais;
                oPais.Ddi = paisSelecionado.Ddi;
                oPais.Sigla = paisSelecionado.Sigla;
                oPais.Moeda = paisSelecionado.Moeda;
            }
        }
    }
}
