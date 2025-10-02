using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPEC
{
    internal class CtrlPaises : Controller
    {
        ColPaises aColPaises;

        public CtrlPaises()
        {
            aColPaises = new ColPaises();
        }
        public override void Salvar(object obj)
        {
            Paises oPais = (Paises)obj;
            if (oPais.Codigo == 0)
            {
                aColPaises.Inserir(oPais.Clone());
            }
            else
            {
                //aColPaises.Atualizar(oPais);
            }
        }
        public List<Paises> Listar()
        {
            return aColPaises.Listar();
        }
    }
}
