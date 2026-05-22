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
                {
                    if (matriz[i, j] > 0)
                    {
                        sb.Append($"-> {nombres[j]} ({claves[j]}) [{matriz[i, j]}m]  ");
                    }
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }

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

                    if (i < nodosEnNivel - 1)
                        linea.Append(" | ");

                    totalVis++;

                    for (int j = 0; j < total; j++)
                    {
                        if (matriz[actual, j] > 0 && !visitado[j])
                        {
                            visitado[j] = true;
                            cola.Enqueue(j);
                        }
                    }
                }

                sb.AppendLine(linea.ToString());
                nivel++;
            }

            sb.AppendLine($"\nTotal de edificios visitados: {totalVis}");

            return sb.ToString();
        }

        public (int[] orden, int[] padre) ObtenerOrdenBFS(string inicio)
        {
            bool[] visitado = new bool[total];
            int[] padre = new int[total];

            for (int i = 0; i < total; i++)
                padre[i] = -1;

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
                {
                    if (matriz[actual, j] > 0 && !visitado[j])
                    {
                        visitado[j] = true;
                        padre[j] = actual;
                        cola.Enqueue(j);
                    }
                }
            }

            return (orden.ToArray(), padre);
        }

        public int[] ObtenerCaminoMasCorto(string inicio, string destino)
        {
            int origen = BuscarIndice(inicio);
            int fin = BuscarIndice(destino);

            int[] distancia = new int[total];
            bool[] visitado = new bool[total];
            int[] padre = new int[total];

            for (int i = 0; i < total; i++)
            {
                distancia[i] = int.MaxValue;
                padre[i] = -1;
            }

            distancia[origen] = 0;

            for (int i = 0; i < total - 1; i++)
            {
                int actual = -1;
                int menor = int.MaxValue;

                for (int j = 0; j < total; j++)
                {
                    if (!visitado[j] && distancia[j] < menor)
                    {
                        menor = distancia[j];
                        actual = j;
                    }
                }

                if (actual == -1)
                    break;

                visitado[actual] = true;

                for (int vecino = 0; vecino < total; vecino++)
                {
                    if (matriz[actual, vecino] > 0 && !visitado[vecino])
                    {
                        int nuevaDistancia =
                            distancia[actual] + matriz[actual, vecino];

                        if (nuevaDistancia < distancia[vecino])
                        {
                            distancia[vecino] = nuevaDistancia;
                            padre[vecino] = actual;
                        }
                    }
                }
            }

            List<int> camino = new List<int>();

            int nodo = fin;

            while (nodo != -1)
            {
                camino.Insert(0, nodo);
                nodo = padre[nodo];
            }

            return camino.ToArray();
        }


        public string MostrarCaminoMasCorto(string inicio, string destino)
        {
            int[] camino = ObtenerCaminoMasCorto(inicio, destino);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("=== CAMINO MÁS CORTO ===\n");

            int distanciaTotal = 0;

            for (int i = 0; i < camino.Length; i++)
            {
                sb.Append($"{claves[camino[i]]}");

                if (i < camino.Length - 1)
                {
                    distanciaTotal += matriz[camino[i], camino[i + 1]];
                    sb.Append(" -> ");
                }
            }

            sb.AppendLine($"\n\nDistancia total: {distanciaTotal} metros");

            return sb.ToString();
        }

        

        public int GetTotal() => total;

        public string GetClave(int i) => claves[i];

        public string GetNombre(int i) => nombres[i];

        public int GetDistancia(int i, int j) => matriz[i, j];

        public int GetIndice(string clave) => BuscarIndice(clave);
    }
}