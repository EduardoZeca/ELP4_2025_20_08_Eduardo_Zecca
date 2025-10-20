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
            this.CarregaLV();
        }
        protected override void Alterar()
        {
            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
            this.CarregaLV();
        }
        protected override void Excluir()
        {
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
            this.CarregaLV();
        }
        protected override void CarregaLV()
        {
            listV.Items.Clear();
            foreach (var oEstado in aCtrlEstados.Listar())
            {
                ListViewItem item = new ListViewItem(Convert.ToString(oEstado.Codigo));
                item.SubItems.Add(oEstado.Estado);
                item.SubItems.Add(oEstado.Uf);
                item.SubItems.Add(Convert.ToString(oEstado.OPais.Codigo));
                item.SubItems.Add(oEstado.OPais.Pais);
                listV.Items.Add(item);
            }
        }
        protected override void Pesquisar()
        {
            this.CarregaLV();
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
        }
    }
}
