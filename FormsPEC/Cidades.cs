using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPEC
{
    internal class Cidades : Pai
    {
        protected Estados oEstado;
        protected string cidade;
        protected string ddd;
        public Cidades() : base()
        {
            oEstado = new Estados();
            cidade = string.Empty;
            ddd = string.Empty;
        }
        public Cidades(int codigo, DateTime datcad, DateTime ultalt, Estados oEstado, string cidade, string ddd) : base(codigo, datcad, ultalt)
        {
            this.oEstado = oEstado;
            this.cidade = cidade;
            this.ddd = ddd;
        }
        public string Cidade
        {
            get => cidade;
            set => cidade = value;
        }
        public string Ddd
        {
            get => ddd;
            set => ddd = value;
        }
        public Estados OEstado
        {
            get => oEstado;
            set => oEstado = value;
        }
    }
}
