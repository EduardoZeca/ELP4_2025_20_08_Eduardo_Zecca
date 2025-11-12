using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPEC
{
    internal class CtrlEstados : Controller<Estados>
    {
        DaoEstados aDaoEstados;
        //ColEstados aColEstados;
        protected CtrlPaises aCtrlPaises;
        public CtrlEstados()
        {
            aDaoEstados = new DaoEstados();
            aCtrlPaises = new CtrlPaises();
            //aColEstados = new ColEstados();
        }
        public CtrlPaises ACtrlPaises
        {
            get => aCtrlPaises;
            set => aCtrlPaises = value;
        }
        public override string Salvar(object obj)
        {
            return aDaoEstados.Salvar(obj);
            //base.Salvar(obj);
            //Estados oEstado = (Estados)obj;
            //if(oEstado.Codigo == 0)
            //{
            //    oEstado.Codigo = aColEstados.Tamanho() + 100;
            //    aColEstados.Adicionar(oEstado.Clone());
            //}
            //else
            //{
            //    Estados oEstadoProc = aColEstados.BuscarPorUf(oEstado.Uf);
            //    int ind = aColEstados.Buscar(oEstadoProc);
            //    aColEstados.Atualizar(oEstado);
            //}
        }
        public override string Excluir(object obj)
        {
            return aDaoEstados.Excluir(obj);
            //base.Excluir(obj);
            //Estados oEstado = (Estados)obj;
            //aColEstados.Remover(oEstado);
        }
        public override List<Estados> Listar()
        {
            return aDaoEstados.Listar();
        }
        public override object CarregaObj(int chave)
        {
            return aDaoEstados.CarregaObj(chave);
        }
        public override List<Estados> Pesquisar(string chave)
        {
            return aDaoEstados.Pesquisar(chave);
        }
    }
}
