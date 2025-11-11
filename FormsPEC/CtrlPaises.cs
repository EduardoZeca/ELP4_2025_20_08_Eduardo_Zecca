using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace FormsPEC
{
    internal class CtrlPaises : Controller<Paises>
    {
        //ColPaises aColPaises;
        DaoPaises aDaoPaises;
        public CtrlPaises()
        {
            //aColPaises = new ColPaises();
            aDaoPaises = new DaoPaises();
        }
        public override string Salvar(object obj)
        {
            return aDaoPaises.Salvar(obj);
            //List<Paises> lista = aColPaises.Listar();
            //Paises oPais = (Paises)obj;
            //if (lista.Count == 0)
            //{
            //    aColPaises.Inserir(oPais.Clone());
            //    return;
            //}
            //else if (oPais.Codigo != lista[lista.Count - 1].Codigo)
            //{
            //    aColPaises.Inserir(oPais.Clone());
            //    return;
            //}

            //foreach (Paises p in lista)
            //{
            //    if (p.Codigo == oPais.Codigo)
            //    {
            //        aColPaises.Atualizar(aColPaises.Buscar(p), oPais.Clone());
            //        return;
            //    }
            //}
        }
        public override string Excluir(object obj)
        {
            //Paises oPais = (Paises)obj;
            //List<Paises> lista = aColPaises.Listar();
            //Paises aux = lista.Find(p => p.Codigo == oPais.Codigo);
            //if(aux != null)
            //    aColPaises.Remover(aux);

            return aDaoPaises.Excluir(obj);
        }
        public override List<Paises> Listar()
        {
            return aDaoPaises.Listar();
        }
        public override object CarregaObj(int chave)
        {
            return aDaoPaises.CarregaObj(chave);
        }
        public override List<Paises> Pesquisar(string chave)
        {
            return aDaoPaises.Pesquisar(chave);
        }
    }
}
