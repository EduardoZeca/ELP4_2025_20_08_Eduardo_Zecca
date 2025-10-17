using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsPEC
{
    public partial class frmPrincipal : Form
    {
        Interfaces aInter = new Interfaces();
        Paises oPais = new Paises();
        Estados oEstado = new Estados();
        Cidades aCidade = new Cidades();
        //Controller<T> aCtrl = new Controller();
        CtrlPaises aCtrlPaises = new CtrlPaises();
        CtrlEstados aCtrlEstados = new CtrlEstados();
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaPaises(oPais, aCtrlPaises);
        }
        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaEstados(oEstado, aCtrlEstados);
        }
        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //aInter.PecaCidades(aCidade, aCtrl);
        }
    }
}
