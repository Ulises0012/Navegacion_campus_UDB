using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus_UDB
{
    internal class NodoRuta
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public int Distancia { get; set; }

        public NodoRuta(string origen, string destino, int distancia)
        {
            Origen = origen;
            Destino = destino;
            Distancia = distancia;
        }
    }
}
