using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsPEC
{
    internal class CtrlCidades : Controller<Cidades>
    {
        ColCidades aColCidades;
        DaoCidades aDaoCidades;
        protected CtrlEstados aCtrlEstados;
        public CtrlCidades()
        {
            aColCidades = new ColCidades();
            aCtrlEstados = new CtrlEstados();
            aDaoCidades = new DaoCidades();
        }
        public CtrlEstados ACtrlEstados
        {
            get => aCtrlEstados;
            set => aCtrlEstados = value;
        }
        public override string Salvar(object obj)
        {
            return aDaoCidades.Salvar(obj);
            // base.Salvar(obj);
            //Cidades aCidade = (Cidades)obj;
            //if(aCidade.Codigo == 0)
            //{
            //    aCidade.Codigo = aColCidades.Tamanho() + 1000;
            //    aColCidades.Inserir(aCidade.Clone());
            //}
            //else
            //{
            //    Cidades aCidadeProcurada = aColCidades.BuscaPorDDD(aCidade.DDD);

            //    int indice = aColCidades.Buscar(aCidadeProcurada);

            //    aColCidades.Atualizar(indice, aCidade);
            //}
        }
        public override string Excluir(object obj)
        {
            return aDaoCidades.Excluir(obj);
            //base.Excluir(obj);
            //Cidades aCidade = (Cidades)obj;
            //aColCidades.Remover(aCidade);
        }
        public override List<Cidades> Listar()
        {
            return aDaoCidades.Listar();
        }
        public override object CarregaObj(int chave)
        {
            return aDaoCidades.CarregaObj(chave);
        }
        public override List<Cidades> Pesquisar(string chave)
        {
            return aDaoCidades.Pesquisar(chave);
        }
    }
}
