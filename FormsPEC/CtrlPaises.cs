using System;
using System.Collections;
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
            List<Paises> lista = aColPaises.Listar();
            Paises oPais = (Paises)obj;
            if(lista.Count == 0)
            {
                aColPaises.Inserir(oPais.Clone());
                return;
            }
            else if (oPais.Codigo != lista[lista.Count - 1].Codigo)
            {
                aColPaises.Inserir(oPais.Clone());
                return;
            }
            
            foreach (Paises p in lista)
            {
                if (p.Codigo == oPais.Codigo)
                {
                    aColPaises.Atualizar(aColPaises.Buscar(p), oPais.Clone());
                    return;
                }
            }
        }
        public override void Excluir(object obj)
        {
            Paises oPais = (Paises)obj;
            aColPaises.Remover(oPais);
        }
        public List<Paises> Listar()
        {
            return aColPaises.Listar();
        }
    }
}
