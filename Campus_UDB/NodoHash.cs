using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus_UDB
{
    internal class NodoHash
    {
        public string Clave;
        public string Nombre;
        public int Conteo;
        public NodoHash Siguiente;

        public NodoHash(string clave, string nombre)
        {
            Clave = clave;
            Nombre = nombre;
            Conteo = 1;
            Siguiente = null;
        }
    }
}
