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
        Controller aCtrl;
        public frmConsPaises()
        {
            InitializeComponent();
        }
        protected override void Incluir()
        {
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.ShowDialog();
        }
        protected override void Alterar()
        {
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.ShowDialog();
        }
        protected override void Excluir()
        {
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.ShowDialog();
        }
        protected override void Pesquisar()
        {
            
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
                aCtrl = (Controller)ctrl;
        }

    }
}
