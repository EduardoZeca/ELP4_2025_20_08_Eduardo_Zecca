using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPEC
{
    internal class ColCidades : Colecoes<Cidades>
    {
        public Cidades BuscaPorDDD(string ddd)
        {
            foreach (var cidade in aLista)
            {
                if (cidade.Ddd.Equals(ddd, StringComparison.OrdinalIgnoreCase))
                {
                    return cidade;
                }
            }
            return null;
        }
    }
}
