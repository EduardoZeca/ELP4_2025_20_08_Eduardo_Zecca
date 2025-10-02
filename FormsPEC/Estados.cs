using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPEC
{
    internal class Estados : Pai
    {
        protected Paises oPais;
        protected string estado;
        protected string uf;
        public Estados() : base()
        {
            oPais = new Paises();
            estado = string.Empty;
            uf = string.Empty;
        }
        public Estados(int codigo, DateTime datcad, DateTime ultalt, string estado, string uf, Paises oPais) : base(codigo, datcad, ultalt)
        {
            this.oPais = oPais;
            this.estado = estado;
            this.uf = uf;
        }
        public Estados Clone()
        {
            return new Estados(this.codigo, this.datcad, this.ultalt, this.estado, this.uf, this.oPais.Clone());
        }
        public string Estado
        {
            get => estado;
            set => estado = value;
        }
        public string Uf
        {
            get => uf;
            set => uf = value;
        }
        public Paises OPais
        {
            get => oPais;
            set => oPais = value;
        }
    }
}
