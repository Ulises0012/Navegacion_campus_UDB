using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus_UDB
{
    internal class MinHeap
    {
        private List<NodoRuta> heap;

        public MinHeap()
        {
            heap = new List<NodoRuta>();
        }

        public int Tamano => heap.Count;
        public bool EstaVacio() => heap.Count == 0;

        //Insertar

        public void Insertar(string origen, string destino, int distancia)
        {
            heap.Add(new NodoRuta(origen, destino, distancia));
            SubirUltimo();
        }

        //  Extraer minimo 

        public NodoRuta ExtraerMinimo()
        {
            if (EstaVacio()) return null;

            NodoRuta minimo = heap[0];

            // Mover el ultimo al frente y bajar
            int ultimo = heap.Count - 1;
            heap[0] = heap[ultimo];
            heap.RemoveAt(ultimo);

            if (!EstaVacio()) BajarRaiz();

            return minimo;
        }

        // Muestra todas las rutas ordenadas de menor a mayor

        public string MostrarRutasOrdenadas()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== RUTAS ORDENADAS POR DISTANCIA ===\n");

            // Extraer todo en orden
            List<NodoRuta> extraidas = new List<NodoRuta>();
            int posicion = 1;

            while (!EstaVacio())
            {
                NodoRuta ruta = ExtraerMinimo();
                extraidas.Add(ruta);
                sb.AppendLine($"  {posicion}°  {ruta.Origen,-26} →  {ruta.Destino,-26}  {ruta.Distancia,4} metros");
                posicion++;
            }

            sb.AppendLine($"\n  Total de rutas: {extraidas.Count}");
            sb.AppendLine();

            // Mostrar estado interno del heap vacio
            sb.AppendLine("  Estado interno del heap (arreglo):");
            sb.AppendLine("  [ vacío — todas las rutas fueron procesadas ]");

            return sb.ToString();
        }

        // ── partes del heap ───────────────────────────────────────────

        private int Padre(int i) => (i - 1) / 2;
        private int HijoIzq(int i) => 2 * i + 1;
        private int HijoDer(int i) => 2 * i + 2;

        private void Intercambiar(int i, int j)
        {
            NodoRuta tmp = heap[i];
            heap[i] = heap[j];
            heap[j] = tmp;
        }

        // Sube el ultimo elemento hasta su posicion correcta
        private void SubirUltimo()
        {
            int i = heap.Count - 1;
            while (i > 0 && heap[i].Distancia < heap[Padre(i)].Distancia)
            {
                Intercambiar(i, Padre(i));
                i = Padre(i);
            }
        }

        // Baja la raiz hasta su posicion correcta
        private void BajarRaiz()
        {
            int i = 0;
            int n = heap.Count;

            while (true)
            {
                int menor = i;
                int iz = HijoIzq(i);
                int de = HijoDer(i);

                if (iz < n && heap[iz].Distancia < heap[menor].Distancia) menor = iz;
                if (de < n && heap[de].Distancia < heap[menor].Distancia) menor = de;

                if (menor == i) break;

                Intercambiar(i, menor);
                i = menor;
            }
        }
    }
}
