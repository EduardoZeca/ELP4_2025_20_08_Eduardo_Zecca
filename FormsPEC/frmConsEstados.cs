using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsPEC
{
    public partial class frmConsEstados : FormsPEC.frmConsultas
    {
        frmCadEstados oFrmCadEstados;
        Estados oEstado;
        CtrlEstados aCtrlEstados;
        public frmConsEstados()
        {
            InitializeComponent();
        }
    
        protected override void Incluir()
        {
            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.ShowDialog();
            this.CarregaLV("");
        }
        protected override void Alterar()
        {
            int codSelecionado = Convert.ToInt32(listV.SelectedItems[0].SubItems[0].Text);
            oEstado = (Estados)aCtrlEstados.CarregaObj(codSelecionado);
            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
            this.CarregaLV("");
        }
        protected override void Excluir()
        {
            int codSelecionado = Convert.ToInt32(listV.SelectedItems[0].SubItems[0].Text);
            oEstado = (Estados)aCtrlEstados.CarregaObj(codSelecionado);

            string aux;

            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.BloquearTxt();

            aux = oFrmCadEstados.btnSalvar.Text;
            oFrmCadEstados.btnSalvar.Text = "Excluir";

            oFrmCadEstados.ShowDialog();
            oFrmCadEstados.DesbloquearTxt();

            oFrmCadEstados.btnSalvar.Text = aux;
            this.CarregaLV("");
        }
        protected override void CarregaLV(string chave)
        {
            if (chave == "")
            {
                listV.Items.Clear();
                foreach (Estados estado in aCtrlEstados.Listar())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(estado.Codigo));
                    item.SubItems.Add(estado.Estado);
                    item.SubItems.Add(estado.Uf);
                    item.SubItems.Add(Convert.ToString(estado.OPais.Codigo));
                    item.SubItems.Add(estado.OPais.Pais);
                    listV.Items.Add(item);
                }
            }
            else
            {
                listV.Items.Clear();
                foreach (Estados estado in aCtrlEstados.Pesquisar(chave))
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(estado.Codigo));
                    item.SubItems.Add(estado.Estado);
                    item.SubItems.Add(estado.Uf);
                    item.SubItems.Add(Convert.ToString(estado.OPais.Codigo));
                    item.SubItems.Add(estado.OPais.Pais);
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
            if (obj != null)
                oFrmCadEstados = (frmCadEstados)obj;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oEstado = (Estados)obj;
            if (ctrl != null)
                aCtrlEstados = (CtrlEstados)ctrl;
            this.CarregaLV("");
        }
    }
}
