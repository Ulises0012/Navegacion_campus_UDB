using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Campus_UDB
{
    public partial class MainForm : Form
    {
        private Grafo grafo;
        private TablaHash tablaHash;
        private MinHeap minHeap;
        private string[] claves = { "A", "B", "C", "D", "E", "F", "G" };

        // Posiciones fijas de cada nodo en el canvas
        private Point[] posiciones = new Point[]
{
    new Point(75,  240),  // A - Biblioteca    (medio izquierda)
    new Point(210, 240),  // B - Cafeteria     (medio centro)
    new Point(150, 110),  // C - Laboratorio   (arriba izquierda)
    new Point(340, 240),  // D - Rectoria      (medio derecha)
    new Point(210, 370),  // E - Gimnasio      (abajo)
    new Point(340, 110),  // F - Aulas         (arriba derecha)
    new Point(465, 240),  // G - Estacionamiento (extremo derecho)
};

        // Color actual de cada nodo
        private Color[] coloresNodo;

        // Aristas resaltadas segun operacion
        private HashSet<string> aristasResaltadas = new HashSet<string>();

        // Paleta de colores
        private readonly Color ColorNormal = Color.FromArgb(50, 130, 194);
        private readonly Color ColorOrigen = Color.FromArgb(220, 80, 50);
        private readonly Color ColorDestino = Color.FromArgb(50, 160, 80);
        private readonly Color ColorVisitado = Color.FromArgb(240, 170, 40);
        private readonly Color ColorCamino = Color.FromArgb(100, 200, 120);

        public MainForm()
        {
            InitializeComponent();
            InicializarSistema();
        }

        private void InicializarSistema()
        {
            grafo = new Grafo(7);
            tablaHash = new TablaHash();
            minHeap = new MinHeap();

            grafo.AgregarEdificio("A", "Biblioteca Central");
            grafo.AgregarEdificio("B", "Cafeteria");
            grafo.AgregarEdificio("C", "Laboratorio de Computo");
            grafo.AgregarEdificio("D", "Rectoria");
            grafo.AgregarEdificio("E", "Gimnasio");
            grafo.AgregarEdificio("F", "Aulas Generales");
            grafo.AgregarEdificio("G", "Estacionamiento");

            grafo.AgregarCamino("A", "B", 120);
            grafo.AgregarCamino("A", "C", 200);
            grafo.AgregarCamino("B", "D", 150);
            grafo.AgregarCamino("B", "E", 300);
            grafo.AgregarCamino("C", "F", 100);
            grafo.AgregarCamino("D", "F", 80);
            grafo.AgregarCamino("E", "G", 250);
            grafo.AgregarCamino("F", "G", 180);

            coloresNodo = new Color[7];
            ResetearColores();

            string[] opciones = {
                "A — Biblioteca Central",  "B — Cafeteria",
                "C — Laboratorio",         "D — Rectoria",
                "E — Gimnasio",            "F — Aulas Generales",
                "G — Estacionamiento"
            };
            cmbOrigen.Items.AddRange(opciones);
            cmbDestino.Items.AddRange(opciones);
            cmbOrigen.SelectedIndex = 0;
            cmbDestino.SelectedIndex = 4;

            // Eventos botones
            btnMostrarGrafo.Click += BtnMostrarGrafo_Click;
            btnBFS.Click += BtnBFS_Click;
            btnDFS.Click += BtnDFS_Click;
            btnTablaHash.Click += BtnTablaHash_Click;
            btnMinHeap.Click += BtnMinHeap_Click;
            btnReiniciar.Click += BtnReiniciar_Click;

            // Evento paint del canvas
            picGrafo.Paint += PicGrafo_Paint;
            picGrafo.Invalidate();
        }

        // ── Reset colores ──────────────────────────────────────────────

        private void ResetearColores()
        {
            for (int i = 0; i < coloresNodo.Length; i++)
                coloresNodo[i] = ColorNormal;
            aristasResaltadas.Clear();
        }

        // ── Botones ────────────────────────────────────────────────────

        private void BtnMostrarGrafo_Click(object sender, EventArgs e)
        {
            ResetearColores();
            rtbResultados.Text = grafo.MostrarGrafo();
            picGrafo.Invalidate();
        }

        private void BtnBFS_Click(object sender, EventArgs e)
        {
            ResetearColores();
            string origen = claves[cmbOrigen.SelectedIndex];

            int[] orden = grafo.ObtenerOrdenBFS(origen);

            // Colorear nodos visitados
            coloresNodo[orden[0]] = ColorOrigen;
            for (int i = 1; i < orden.Length; i++)
                coloresNodo[orden[i]] = ColorVisitado;

            // Resaltar aristas del recorrido en orden
            for (int i = 0; i < orden.Length - 1; i++)
                aristasResaltadas.Add(ClaveArista(orden[i], orden[i + 1]));

            // Registrar visitas en TablaHash
            foreach (int idx in orden)
                tablaHash.RegistrarVisita(grafo.GetClave(idx), grafo.GetNombre(idx));

            rtbResultados.Text = grafo.RecorridoBFS(origen);
            picGrafo.Invalidate();
        }

        private void BtnDFS_Click(object sender, EventArgs e)
        {
            ResetearColores();
            string origen = claves[cmbOrigen.SelectedIndex];
            string destino = claves[cmbDestino.SelectedIndex];

            int[] camino = grafo.ObtenerCaminoDFS(origen, destino);

            if (camino.Length > 0)
            {
                for (int i = 0; i < camino.Length; i++)
                {
                    if (i == 0) coloresNodo[camino[i]] = ColorOrigen;
                    else if (i == camino.Length - 1) coloresNodo[camino[i]] = ColorDestino;
                    else coloresNodo[camino[i]] = ColorCamino;
                }

                for (int i = 0; i < camino.Length - 1; i++)
                    aristasResaltadas.Add(ClaveArista(camino[i], camino[i + 1]));

                // Registrar visitas en TablaHash
                foreach (int idx in camino)
                    tablaHash.RegistrarVisita(grafo.GetClave(idx), grafo.GetNombre(idx));
            }

            rtbResultados.Text = grafo.RecorridoDFS(origen, destino);
            picGrafo.Invalidate();
        }

        private void BtnTablaHash_Click(object sender, EventArgs e)
        {
            rtbResultados.Text = tablaHash.MostrarEstadisticas();
        }

        private void BtnMinHeap_Click(object sender, EventArgs e)
        {
            minHeap = new MinHeap();
            for (int i = 0; i < grafo.GetTotal(); i++)
                for (int j = i + 1; j < grafo.GetTotal(); j++)
                {
                    int dist = grafo.GetDistancia(i, j);
                    if (dist > 0)
                        minHeap.Insertar(grafo.GetNombre(i), grafo.GetNombre(j), dist);
                }
            rtbResultados.Text = minHeap.MostrarRutasOrdenadas();
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            ResetearColores();
            tablaHash.Limpiar();
            rtbResultados.Clear();
            cmbOrigen.SelectedIndex = 0;
            cmbDestino.SelectedIndex = 4;
            picGrafo.Invalidate();
        }

        // ── Dibujo del grafo ───────────────────────────────────────────

        private void PicGrafo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            int radio = 24;
            Font fuenteDistancia = new Font("Segoe UI", 7.5f);
            Font fuenteNombre = new Font("Segoe UI", 7.5f);
            Font fuenteClave = new Font("Segoe UI", 11f, FontStyle.Bold);

            // 1. Dibujar aristas
            for (int i = 0; i < grafo.GetTotal(); i++)
            {
                for (int j = i + 1; j < grafo.GetTotal(); j++)
                {
                    int dist = grafo.GetDistancia(i, j);
                    if (dist == 0) continue;

                    string key = ClaveArista(i, j);
                    bool resaltada = aristasResaltadas.Contains(key);

                    Pen lapiz = resaltada
                        ? new Pen(Color.FromArgb(80, 190, 110), 3f)
                        : new Pen(Color.FromArgb(190, 190, 190), 1.5f);

                    g.DrawLine(lapiz, posiciones[i], posiciones[j]);
                    lapiz.Dispose();

                    // Etiqueta de distancia centrada en la arista
                    int mx = (posiciones[i].X + posiciones[j].X) / 2;
                    int my = (posiciones[i].Y + posiciones[j].Y) / 2;

                    SizeF sz = g.MeasureString($"{dist}m", fuenteDistancia);
                    RectangleF bg = new RectangleF(mx - sz.Width / 2 - 2, my - sz.Height / 2 - 1, sz.Width + 4, sz.Height + 2);
                    g.FillRectangle(new SolidBrush(Color.FromArgb(245, 245, 245)), bg);
                    g.DrawString($"{dist}m", fuenteDistancia,
                        new SolidBrush(resaltada ? Color.FromArgb(40, 130, 60) : Color.FromArgb(120, 120, 120)),
                        mx - sz.Width / 2, my - sz.Height / 2);
                }
            }

            // 2. Dibujar nodos
            for (int i = 0; i < grafo.GetTotal(); i++)
            {
                Point p = posiciones[i];
                Rectangle rect = new Rectangle(p.X - radio, p.Y - radio, radio * 2, radio * 2);

                // Sombra suave
                Rectangle sombra = new Rectangle(p.X - radio + 3, p.Y - radio + 3, radio * 2, radio * 2);
                g.FillEllipse(new SolidBrush(Color.FromArgb(40, 0, 0, 0)), sombra);

                // Circulo relleno
                g.FillEllipse(new SolidBrush(coloresNodo[i]), rect);

                // Borde
                g.DrawEllipse(new Pen(DarkenColor(coloresNodo[i]), 2), rect);

                // Letra clave centrada
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                g.DrawString(grafo.GetClave(i), fuenteClave, Brushes.White, rect, sf);

                // Nombre debajo del nodo
                string nombreCorto = NombreCorto(grafo.GetNombre(i));
                SizeF szNombre = g.MeasureString(nombreCorto, fuenteNombre);
                g.DrawString(nombreCorto, fuenteNombre,
                    new SolidBrush(Color.FromArgb(60, 60, 60)),
                    p.X - szNombre.Width / 2, p.Y + radio + 4);
            }

            // 3. Leyenda
            DibujarLeyenda(g);

            fuenteDistancia.Dispose();
            fuenteNombre.Dispose();
            fuenteClave.Dispose();
        }

        private void DibujarLeyenda(Graphics g)
        {
            int x = 8, y = picGrafo.Height - 30;
            Font fLeyenda = new Font("Segoe UI", 7.5f);

            var items = new (Color color, string texto)[]
            {
                (ColorNormal,   "Sin visitar"),
                (ColorOrigen,   "Origen"),
                (ColorDestino,  "Destino"),
                (ColorVisitado, "Visitado"),
                (ColorCamino,   "Camino"),
            };

            foreach (var (color, texto) in items)
            {
                g.FillEllipse(new SolidBrush(color), x, y, 12, 12);
                g.DrawEllipse(new Pen(DarkenColor(color), 1), x, y, 12, 12);
                g.DrawString(texto, fLeyenda, new SolidBrush(Color.FromArgb(60, 60, 60)), x + 16, y - 1);
                x += 80;
            }

            fLeyenda.Dispose();
        }

        // ── Helpers ────────────────────────────────────────────────────

        private string ClaveArista(int i, int j)
            => i < j ? $"{i}-{j}" : $"{j}-{i}";

        private Color DarkenColor(Color c)
            => Color.FromArgb(
                Math.Max(0, c.R - 50),
                Math.Max(0, c.G - 50),
                Math.Max(0, c.B - 50));

        private string NombreCorto(string nombre)
        {
            string[] partes = nombre.Split(' ');
            return partes[0];
        }


    }
}