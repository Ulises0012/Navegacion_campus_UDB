using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus_UDB
{
    internal class TablaHash
    {
        private const int CAPACIDAD = 13;   
        private NodoHash[] cubetas;
        private int totalEntradas;

        public TablaHash()
        {
            cubetas = new NodoHash[CAPACIDAD];
            totalEntradas = 0;
        }

        // Funcion hash
        private int FuncionHash(string clave)
        {
            int suma = 0;
            foreach (char c in clave)
                suma += (int)c;
            return suma % CAPACIDAD;
        }

        // Registrar una visita 
        public void RegistrarVisita(string clave, string nombre)
        {
            int indice = FuncionHash(clave);
            NodoHash actual = cubetas[indice];

            // Buscar si ya existe en la cadena
            while (actual != null)
            {
                if (actual.Clave == clave)
                {
                    actual.Conteo++;
                    return;
                }
                actual = actual.Siguiente;
            }

            //  Si no existe lo  inserta al frente de la cadena
            NodoHash nuevo = new NodoHash(clave, nombre);
            nuevo.Siguiente = cubetas[indice];
            cubetas[indice] = nuevo;
            totalEntradas++;
        }

        // Obtener conteo de un edificio
        public int ObtenerConteo(string clave)
        {
            int indice = FuncionHash(clave);
            NodoHash actual = cubetas[indice];

            while (actual != null)
            {
                if (actual.Clave == clave) return actual.Conteo;
                actual = actual.Siguiente;
            }
            return 0;
        }

        //  Edificio mas visitado 
        public string EdificioMasVisitado()
        {
            NodoHash mejor = null;

            for (int i = 0; i < CAPACIDAD; i++)
            {
                NodoHash actual = cubetas[i];
                while (actual != null)
                {
                    if (mejor == null || actual.Conteo > mejor.Conteo)
                        mejor = actual;
                    actual = actual.Siguiente;
                }
            }

            return mejor == null
                ? "Ninguno"
                : $"{mejor.Nombre} ({mejor.Clave}) con {mejor.Conteo} visitas";
        }

        // Mostrar estadssticas ordenadas (burbuja sobre arreglo aux) 
        public string MostrarEstadisticas()
        {
            // Recolectar todos los nodos en un arreglo auxiliar
            NodoHash[] todos = new NodoHash[totalEntradas];
            int k = 0;
            for (int i = 0; i < CAPACIDAD; i++)
            {
                NodoHash actual = cubetas[i];
                while (actual != null)
                {
                    todos[k++] = actual;
                    actual = actual.Siguiente;
                }
            }

            // Ordenar por conteo descendente 
            for (int i = 0; i < k - 1; i++)
                for (int j = 0; j < k - i - 1; j++)
                    if (todos[j].Conteo < todos[j + 1].Conteo)
                    {
                        NodoHash tmp = todos[j];
                        todos[j] = todos[j + 1];
                        todos[j + 1] = tmp;
                    }

            //  Construir salida
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== ESTADÍSTICAS DE VISITAS ===\n");

            int maxConteo = k > 0 ? todos[0].Conteo : 1;

            for (int i = 0; i < k; i++)
            {
                NodoHash n = todos[i];
                int bloques = (int)Math.Round((double)n.Conteo / maxConteo * 20);
                string barra = new string('█', Math.Max(1, bloques));
                sb.AppendLine($"  {n.Nombre,-30} {barra} {n.Conteo} visita{(n.Conteo != 1 ? "s" : "")}");
            }

            sb.AppendLine();
            sb.AppendLine($"Edificio más visitado: {EdificioMasVisitado()}");

            //  Estado interno de la tabla (cubetas)
            sb.AppendLine();
            sb.AppendLine("--- Estado interno de la tabla hash ---");
            sb.AppendLine($"  Capacidad: {CAPACIDAD} cubetas\n");
            for (int i = 0; i < CAPACIDAD; i++)
            {
                if (cubetas[i] == null) continue;
                sb.Append($"  [{i:D2}] ");
                NodoHash actual = cubetas[i];
                while (actual != null)
                {
                    sb.Append($"({actual.Clave}:{actual.Conteo})");
                    if (actual.Siguiente != null) sb.Append(" -> ");
                    actual = actual.Siguiente;
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        // Limpiar tabla
        public void Limpiar()
        {
            for (int i = 0; i < CAPACIDAD; i++)
                cubetas[i] = null;
            totalEntradas = 0;
        }
    }
}
