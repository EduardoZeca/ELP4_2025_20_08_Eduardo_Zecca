using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPEC
{
    internal class ColPaises : Colecoes<Paises>
    {
        public Paises BuscarPorSigla(string sigla)
        {
            foreach (var opais in aLista)
            {
                if(opais.Sigla.Equals(sigla, StringComparison.OrdinalIgnoreCase))
                    return opais;
            }
            return null;
        }
        public override List<Paises> Listar()
        {
            return aLista;
        }
        public override void Inserir(Paises item)
        {
            aLista.Add(item);
        }
    }
}
