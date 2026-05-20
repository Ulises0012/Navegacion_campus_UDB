using System.Collections.Generic;
using System.Text;

namespace Campus_UDB
{
    public class Grafo
    {
        private string[] claves;
        private string[] nombres;
        private int[,] matriz;
        private int total;

        public Grafo(int capacidad)
        {
            claves = new string[capacidad];
            nombres = new string[capacidad];
            matriz = new int[capacidad, capacidad];
            total = 0;
        }

        private int BuscarIndice(string clave)
        {
            for (int i = 0; i < total; i++)
                if (claves[i] == clave) return i;
            return -1;
        }

        // ── TAREA 1 ────────────────────────────────────────────────────

        public void AgregarEdificio(string clave, string nombre)
        {
            claves[total] = clave;
            nombres[total] = nombre;
            total++;
        }

        public void AgregarCamino(string origen, string destino, int distancia)
        {
            int i = BuscarIndice(origen);
            int j = BuscarIndice(destino);
            if (i != -1 && j != -1)
            {
                matriz[i, j] = distancia;
                matriz[j, i] = distancia;
            }
        }

        public string MostrarGrafo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== MAPA DEL CAMPUS ===\n");

            for (int i = 0; i < total; i++)
            {
                sb.Append($"{nombres[i]} ({claves[i]}): ");
                for (int j = 0; j < total; j++)
                    if (matriz[i, j] > 0)
                        sb.Append($"-> {nombres[j]} ({claves[j]}) [{matriz[i, j]}m]  ");
                sb.AppendLine();
            }

            return sb.ToString();
        }

        // ── TAREA 2 — BFS ──────────────────────────────────────────────

        public string RecorridoBFS(string inicio)
        {
            int idx = BuscarIndice(inicio);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"=== RECORRIDO BFS desde: {nombres[idx]} ({inicio}) ===\n");

            bool[] visitado = new bool[total];
            Queue<int> cola = new Queue<int>();
            int nivel = 0;
            int totalVis = 0;

            cola.Enqueue(idx);
            visitado[idx] = true;

            while (cola.Count > 0)
            {
                int nodosEnNivel = cola.Count;
                StringBuilder linea = new StringBuilder($"Nivel {nivel}: ");

                for (int i = 0; i < nodosEnNivel; i++)
                {
                    int actual = cola.Dequeue();
                    linea.Append($"{nombres[actual]} ({claves[actual]})");
                    if (i < nodosEnNivel - 1) linea.Append(" | ");
                    totalVis++;

                    for (int j = 0; j < total; j++)
                        if (matriz[actual, j] > 0 && !visitado[j])
                        {
                            visitado[j] = true;
                            cola.Enqueue(j);
                        }
                }

                sb.AppendLine(linea.ToString());
                nivel++;
            }

            sb.AppendLine($"\nTotal de edificios visitados: {totalVis}");
            return sb.ToString();
        }

        // ── TAREA 3 — DFS ──────────────────────────────────────────────

        public string RecorridoDFS(string inicio, string destino)
        {
            int idxInicio = BuscarIndice(inicio);
            int idxDestino = BuscarIndice(destino);

            StringBuilder sb = new StringBuilder();
            bool[] visitado = new bool[total];
            Stack<int> pila = new Stack<int>();
            List<int> camino = new List<int>();
            bool encontrado = false;

            // lógica viene en el siguiente paso...

            return sb.ToString();
        }

        // ── Metodos publicos para el dibujo en MainForm ────────────────

        public int GetTotal() => total;
        public string GetClave(int i) => claves[i];
        public string GetNombre(int i) => nombres[i];
        public int GetDistancia(int i, int j) => matriz[i, j];
        public int GetIndice(string clave) => BuscarIndice(clave);

        public int[] ObtenerOrdenBFS(string inicio)
        {
            bool[] visitado = new bool[total];
            Queue<int> cola = new Queue<int>();
            List<int> orden = new List<int>();
            int idx = BuscarIndice(inicio);

            cola.Enqueue(idx);
            visitado[idx] = true;

            while (cola.Count > 0)
            {
                int actual = cola.Dequeue();
                orden.Add(actual);
                for (int j = 0; j < total; j++)
                    if (matriz[actual, j] > 0 && !visitado[j])
                    {
                        visitado[j] = true;
                        cola.Enqueue(j);
                    }
            }
            return orden.ToArray();
        }

        public int[] ObtenerCaminoDFS(string inicio, string destino)
        {
            int idxInicio = BuscarIndice(inicio);
            int idxDestino = BuscarIndice(destino);
            bool[] visitado = new bool[total];
            Stack<int> pila = new Stack<int>();
            List<int> camino = new List<int>();

            pila.Push(idxInicio);

            while (pila.Count > 0)
            {
                int actual = pila.Pop();
                if (visitado[actual]) continue;
                visitado[actual] = true;
                camino.Add(actual);

                if (actual == idxDestino) return camino.ToArray();

                for (int j = total - 1; j >= 0; j--)
                    if (matriz[actual, j] > 0 && !visitado[j])
                        pila.Push(j);
            }

            return new int[0];
        }
    }
}