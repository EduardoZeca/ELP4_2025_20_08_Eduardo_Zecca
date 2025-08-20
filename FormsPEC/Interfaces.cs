using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPEC
{
    internal class Interfaces
    {
        frmConsPaises oFrmConsPaises;
        frmConsEstados oFrmConsEstados;
        frmConsCidades oFrmConsCidades;
        frmCadPaises oFrmCadPaises;
        frmCadEstados oFrmCadEstados;
        frmCadCidades oFrmCadCidades;
        public Interfaces()
        {
            oFrmConsPaises = new frmConsPaises();
            oFrmConsEstados = new frmConsEstados();
            oFrmConsCidades = new frmConsCidades();
            oFrmCadPaises = new frmCadPaises();
            oFrmCadEstados = new frmCadEstados();
            oFrmCadCidades = new frmCadCidades();

            oFrmConsPaises.setFrmCadastro(oFrmCadPaises);
            oFrmConsEstados.setFrmCadastro(oFrmCadEstados);
            oFrmConsCidades.setFrmCadastro(oFrmCadCidades);

            oFrmCadEstados.setFrmConsPaises(oFrmConsPaises);
            oFrmCadCidades.setFrmConsEstados(oFrmConsEstados);
        }
        public void PecaPaises(object obj, object ctrl)
        {
            oFrmConsPaises.ConhecaObj(obj, ctrl);
            oFrmConsPaises.ShowDialog();
        }
        public void PecaEstados(object obj, object ctrl)
        {
            oFrmConsEstados.ConhecaObj(obj, ctrl);
            oFrmConsEstados.ShowDialog();
        }
        public void PecaCidades(object obj, object ctrl)
        {
            oFrmConsCidades.ConhecaObj(obj, ctrl);
            oFrmConsCidades.ShowDialog();
        }
    }
}
