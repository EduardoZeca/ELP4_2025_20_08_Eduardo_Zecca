using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPEC
{
    internal class Colecoes<T>
    {
        protected List<T> aLista;
        public Colecoes()
        {
            aLista = new List<T>();
        }
        public virtual void Inserir(T item)
        {
            aLista.Add(item);
        }
        public virtual bool Remover(T item)
        {
            return aLista.Remove(item);
        }
        public virtual int Buscar (T item)
        {
            return aLista.IndexOf(item);
        }
        public virtual T Acessar (int ind)
        {
            if(ind >= 0 && ind < aLista.Count)
            {
                return aLista[ind];
            }
            throw new ArgumentOutOfRangeException("Indice fora da lista");
        }
        public virtual void Atualizar(int ind, T item)
        {
            if(ind >= 0 && ind < aLista.Count)
                aLista[ind] = item;
            else
                throw new ArgumentOutOfRangeException("Indice fora da lista");
        }
        public virtual int Tamanho()
        {
            return aLista.Count;
        }
        public virtual void Imprimir()
        {
            foreach (var item in aLista)
                Console.WriteLine(item);
        }
        public virtual List<T> Listar()
        {
            return aLista;
        }

        public virtual void Ordenar()
        {
            aLista.Sort();
        }
    }
}
