using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPEC
{
    internal class ColEstados : Colecoes<Estados>
    {
        public Estados BuscarPorUF(string uf)
        {
            foreach (var oestado in aLista)
            {
                if (oestado.Uf.Equals(uf, StringComparison.OrdinalIgnoreCase))
                    return oestado;
            }
            return null;
        }
        public override void Imprimir()
        {
            foreach (var oEstado in aLista)
            {
                Console.WriteLine($"Pais : {oEstado.OPais.Pais}");
                Console.WriteLine($"Estado: {oEstado.Estado}");
                Console.WriteLine($"UF  : {oEstado.Uf}");
            }
        }
    }
}
