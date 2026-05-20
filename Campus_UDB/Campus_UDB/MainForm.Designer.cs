namespace Campus_UDB
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlGrafo = new System.Windows.Forms.Panel();
            this.lblGrafoHeader = new System.Windows.Forms.Label();
            this.picGrafo = new System.Windows.Forms.PictureBox();
            this.grpSeleccion = new System.Windows.Forms.GroupBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.btnMostrarGrafo = new System.Windows.Forms.Button();
            this.btnBFS = new System.Windows.Forms.Button();
            this.btnDFS = new System.Windows.Forms.Button();
            this.btnTablaHash = new System.Windows.Forms.Button();
            this.btnMinHeap = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.rtbResultados = new System.Windows.Forms.RichTextBox();

            this.pnlHeader.SuspendLayout();
            this.pnlGrafo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafo)).BeginInit();
            this.grpSeleccion.SuspendLayout();
            this.grpOperaciones.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(192, 222, 120);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 54;
            //this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(14, 8);
            this.lblTitulo.Text = "Sistema de Navegación del Campus Universitario";
            /*
            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb( 151, 120, 222);
            this.lblSubtitulo.Location = new System.Drawing.Point(15, 32);
            this.lblSubtitulo.Text = "Estructuras de Datos  ·  Grafos  ·  BFS  ·  DFS  ·  Tabla Hash  ·  Min-Heap";
            */
            // pnlGrafo
            this.pnlGrafo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrafo.Location = new System.Drawing.Point(8, 62);
            this.pnlGrafo.Size = new System.Drawing.Size(555, 478);
            this.pnlGrafo.Controls.Add(this.picGrafo);
            this.pnlGrafo.Controls.Add(this.lblGrafoHeader);

            // lblGrafoHeader
            this.lblGrafoHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGrafoHeader.Height = 28;
            this.lblGrafoHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblGrafoHeader.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.lblGrafoHeader.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.lblGrafoHeader.Text = "   MAPA DEL CAMPUS UNIVERSITARIO";
            this.lblGrafoHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // picGrafo
            this.picGrafo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picGrafo.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.picGrafo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;

            // grpSeleccion
            this.grpSeleccion.Text = "Selección de Edificios";
            this.grpSeleccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpSeleccion.Location = new System.Drawing.Point(572, 62);
            this.grpSeleccion.Size = new System.Drawing.Size(360, 105);
            this.grpSeleccion.Controls.Add(this.lblOrigen);
            this.grpSeleccion.Controls.Add(this.cmbOrigen);
            this.grpSeleccion.Controls.Add(this.lblDestino);
            this.grpSeleccion.Controls.Add(this.cmbDestino);
            this.grpSeleccion.Controls.Add(this.lblHint);

            // lblOrigen
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblOrigen.Location = new System.Drawing.Point(10, 24);
            this.lblOrigen.Text = "Edificio Origen:";

            // cmbOrigen
            this.cmbOrigen.Location = new System.Drawing.Point(10, 40);
            this.cmbOrigen.Size = new System.Drawing.Size(158, 23);
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.Font = new System.Drawing.Font("Segoe UI", 9F);

            // lblDestino
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDestino.Location = new System.Drawing.Point(182, 24);
            this.lblDestino.Text = "Edificio Destino (DFS):";

            // cmbDestino
            this.cmbDestino.Location = new System.Drawing.Point(182, 40);
            this.cmbDestino.Size = new System.Drawing.Size(165, 23);
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.Font = new System.Drawing.Font("Segoe UI", 9F);

            // lblHint
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
            this.lblHint.ForeColor = System.Drawing.Color.Gray;
            this.lblHint.Location = new System.Drawing.Point(10, 72);
            this.lblHint.Text = "Nota: el destino solo aplica para el recorrido DFS.";

            // grpOperaciones
            this.grpOperaciones.Text = "Operaciones";
            this.grpOperaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpOperaciones.Location = new System.Drawing.Point(572, 175);
            this.grpOperaciones.Size = new System.Drawing.Size(360, 125);
            this.grpOperaciones.Controls.Add(this.btnMostrarGrafo);
            this.grpOperaciones.Controls.Add(this.btnBFS);
            this.grpOperaciones.Controls.Add(this.btnDFS);
            this.grpOperaciones.Controls.Add(this.btnTablaHash);
            this.grpOperaciones.Controls.Add(this.btnMinHeap);
            this.grpOperaciones.Controls.Add(this.btnReiniciar);

            // btnMostrarGrafo
            this.btnMostrarGrafo.Text = "Mostrar Grafo";
            this.btnMostrarGrafo.Location = new System.Drawing.Point(10, 22);
            this.btnMostrarGrafo.Size = new System.Drawing.Size(163, 28);
            this.btnMostrarGrafo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMostrarGrafo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarGrafo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 80, 140);
            this.btnMostrarGrafo.FlatAppearance.BorderSize = 1;
            this.btnMostrarGrafo.BackColor = System.Drawing.Color.White;
            this.btnMostrarGrafo.ForeColor = System.Drawing.Color.FromArgb(30, 80, 140);
            this.btnMostrarGrafo.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnBFS
            this.btnBFS.Text = "Recorrido BFS";
            this.btnBFS.Location = new System.Drawing.Point(183, 22);
            this.btnBFS.Size = new System.Drawing.Size(163, 28);
            this.btnBFS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBFS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnBFS.FlatAppearance.BorderSize = 1;
            this.btnBFS.BackColor = System.Drawing.Color.White;
            this.btnBFS.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnBFS.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnDFS
            this.btnDFS.Text = "Recorrido DFS";
            this.btnDFS.Location = new System.Drawing.Point(10, 58);
            this.btnDFS.Size = new System.Drawing.Size(163, 28);
            this.btnDFS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDFS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(59, 109, 17);
            this.btnDFS.FlatAppearance.BorderSize = 1;
            this.btnDFS.BackColor = System.Drawing.Color.White;
            this.btnDFS.ForeColor = System.Drawing.Color.FromArgb(59, 109, 17);
            this.btnDFS.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnTablaHash
            this.btnTablaHash.Text = "Tabla Hash";
            this.btnTablaHash.Location = new System.Drawing.Point(183, 58);
            this.btnTablaHash.Size = new System.Drawing.Size(163, 28);
            this.btnTablaHash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTablaHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablaHash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(133, 79, 11);
            this.btnTablaHash.FlatAppearance.BorderSize = 1;
            this.btnTablaHash.BackColor = System.Drawing.Color.White;
            this.btnTablaHash.ForeColor = System.Drawing.Color.FromArgb(133, 79, 11);
            this.btnTablaHash.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnMinHeap
            this.btnMinHeap.Text = "Min-Heap Rutas";
            this.btnMinHeap.Location = new System.Drawing.Point(10, 92);
            this.btnMinHeap.Size = new System.Drawing.Size(163, 28);
            this.btnMinHeap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMinHeap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinHeap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(153, 60, 29);
            this.btnMinHeap.FlatAppearance.BorderSize = 1;
            this.btnMinHeap.BackColor = System.Drawing.Color.White;
            this.btnMinHeap.ForeColor = System.Drawing.Color.FromArgb(153, 60, 29);
            this.btnMinHeap.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnReiniciar
            this.btnReiniciar.Text = "Reiniciar Todo";
            this.btnReiniciar.Location = new System.Drawing.Point(183, 92);
            this.btnReiniciar.Size = new System.Drawing.Size(163, 28);
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnReiniciar.FlatAppearance.BorderSize = 1;
            this.btnReiniciar.BackColor = System.Drawing.Color.White;
            this.btnReiniciar.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;

            // lblResultados
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblResultados.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.lblResultados.Location = new System.Drawing.Point(572, 308);
            this.lblResultados.Text = "RESULTADOS";

            // rtbResultados
            this.rtbResultados.Location = new System.Drawing.Point(572, 326);
            this.rtbResultados.Size = new System.Drawing.Size(360, 208);
            this.rtbResultados.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbResultados.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.rtbResultados.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.rtbResultados.ReadOnly = true;
            this.rtbResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 560);
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Text = "Sistema de Navegación del Campus Universitario";
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlGrafo);
            this.Controls.Add(this.grpSeleccion);
            this.Controls.Add(this.grpOperaciones);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.rtbResultados);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlGrafo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGrafo)).EndInit();
            this.grpSeleccion.ResumeLayout(false);
            this.grpSeleccion.PerformLayout();
            this.grpOperaciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlGrafo;
        private System.Windows.Forms.Label lblGrafoHeader;
        private System.Windows.Forms.PictureBox picGrafo;
        private System.Windows.Forms.GroupBox grpSeleccion;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.GroupBox grpOperaciones;
        private System.Windows.Forms.Button btnMostrarGrafo;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.Button btnTablaHash;
        private System.Windows.Forms.Button btnMinHeap;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.RichTextBox rtbResultados;
    }
}