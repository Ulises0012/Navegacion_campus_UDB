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
            this.picGrafo = new System.Windows.Forms.PictureBox();
            this.lblGrafoHeader = new System.Windows.Forms.Label();
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
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(222)))), ((int)(((byte)(120)))));
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1259, 66);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(19, 10);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(476, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Navegación del Campus Universitario";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(100, 23);
            this.lblSubtitulo.TabIndex = 0;
            // 
            // pnlGrafo
            // 
            this.pnlGrafo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrafo.Controls.Add(this.picGrafo);
            this.pnlGrafo.Controls.Add(this.lblGrafoHeader);
            this.pnlGrafo.Location = new System.Drawing.Point(11, 76);
            this.pnlGrafo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGrafo.Name = "pnlGrafo";
            this.pnlGrafo.Size = new System.Drawing.Size(739, 588);
            this.pnlGrafo.TabIndex = 1;
            // 
            // picGrafo
            // 
            this.picGrafo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.picGrafo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picGrafo.Location = new System.Drawing.Point(0, 34);
            this.picGrafo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picGrafo.Name = "picGrafo";
            this.picGrafo.Size = new System.Drawing.Size(737, 552);
            this.picGrafo.TabIndex = 0;
            this.picGrafo.TabStop = false;
            // 
            // lblGrafoHeader
            // 
            this.lblGrafoHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblGrafoHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGrafoHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblGrafoHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblGrafoHeader.Location = new System.Drawing.Point(0, 0);
            this.lblGrafoHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrafoHeader.Name = "lblGrafoHeader";
            this.lblGrafoHeader.Size = new System.Drawing.Size(737, 34);
            this.lblGrafoHeader.TabIndex = 1;
            this.lblGrafoHeader.Text = "   MAPA DEL CAMPUS UNIVERSITARIO";
            this.lblGrafoHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpSeleccion
            // 
            this.grpSeleccion.Controls.Add(this.lblOrigen);
            this.grpSeleccion.Controls.Add(this.cmbOrigen);
            this.grpSeleccion.Controls.Add(this.lblDestino);
            this.grpSeleccion.Controls.Add(this.cmbDestino);
            this.grpSeleccion.Controls.Add(this.lblHint);
            this.grpSeleccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpSeleccion.Location = new System.Drawing.Point(763, 76);
            this.grpSeleccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSeleccion.Name = "grpSeleccion";
            this.grpSeleccion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSeleccion.Size = new System.Drawing.Size(480, 129);
            this.grpSeleccion.TabIndex = 2;
            this.grpSeleccion.TabStop = false;
            this.grpSeleccion.Text = "Selección de Edificios";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblOrigen.Location = new System.Drawing.Point(13, 30);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(100, 19);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Edificio Origen:";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbOrigen.Location = new System.Drawing.Point(13, 49);
            this.cmbOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(209, 28);
            this.cmbOrigen.TabIndex = 1;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDestino.Location = new System.Drawing.Point(243, 30);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(141, 19);
            this.lblDestino.TabIndex = 2;
            this.lblDestino.Text = "Edificio Destino (DFS):";
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDestino.Location = new System.Drawing.Point(243, 49);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(219, 28);
            this.cmbDestino.TabIndex = 3;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
            this.lblHint.ForeColor = System.Drawing.Color.Gray;
            this.lblHint.Location = new System.Drawing.Point(13, 89);
            this.lblHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(284, 17);
            this.lblHint.TabIndex = 4;
            this.lblHint.Text = "Nota: el destino solo aplica para el recorrido DFS.";
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.Controls.Add(this.btnMostrarGrafo);
            this.grpOperaciones.Controls.Add(this.btnBFS);
            this.grpOperaciones.Controls.Add(this.btnDFS);
            this.grpOperaciones.Controls.Add(this.btnTablaHash);
            this.grpOperaciones.Controls.Add(this.btnMinHeap);
            this.grpOperaciones.Controls.Add(this.btnReiniciar);
            this.grpOperaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpOperaciones.Location = new System.Drawing.Point(763, 215);
            this.grpOperaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOperaciones.Size = new System.Drawing.Size(480, 154);
            this.grpOperaciones.TabIndex = 3;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Operaciones";
            // 
            // btnMostrarGrafo
            // 
            this.btnMostrarGrafo.BackColor = System.Drawing.Color.White;
            this.btnMostrarGrafo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarGrafo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(140)))));
            this.btnMostrarGrafo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarGrafo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMostrarGrafo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(140)))));
            this.btnMostrarGrafo.Location = new System.Drawing.Point(13, 27);
            this.btnMostrarGrafo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarGrafo.Name = "btnMostrarGrafo";
            this.btnMostrarGrafo.Size = new System.Drawing.Size(217, 34);
            this.btnMostrarGrafo.TabIndex = 0;
            this.btnMostrarGrafo.Text = "Mostrar Grafo";
            this.btnMostrarGrafo.UseVisualStyleBackColor = false;
            // 
            // btnBFS
            // 
            this.btnBFS.BackColor = System.Drawing.Color.White;
            this.btnBFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBFS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.btnBFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBFS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBFS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.btnBFS.Location = new System.Drawing.Point(244, 27);
            this.btnBFS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(217, 34);
            this.btnBFS.TabIndex = 1;
            this.btnBFS.Text = "Recorrido BFS";
            this.btnBFS.UseVisualStyleBackColor = false;
            // 
            // btnDFS
            // 
            this.btnDFS.BackColor = System.Drawing.Color.White;
            this.btnDFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDFS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(109)))), ((int)(((byte)(17)))));
            this.btnDFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDFS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDFS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(109)))), ((int)(((byte)(17)))));
            this.btnDFS.Location = new System.Drawing.Point(13, 71);
            this.btnDFS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(217, 34);
            this.btnDFS.TabIndex = 2;
            this.btnDFS.Text = "Recorrido DFS";
            this.btnDFS.UseVisualStyleBackColor = false;
            // 
            // btnTablaHash
            // 
            this.btnTablaHash.BackColor = System.Drawing.Color.White;
            this.btnTablaHash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTablaHash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(79)))), ((int)(((byte)(11)))));
            this.btnTablaHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablaHash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTablaHash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(79)))), ((int)(((byte)(11)))));
            this.btnTablaHash.Location = new System.Drawing.Point(244, 71);
            this.btnTablaHash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTablaHash.Name = "btnTablaHash";
            this.btnTablaHash.Size = new System.Drawing.Size(217, 34);
            this.btnTablaHash.TabIndex = 3;
            this.btnTablaHash.Text = "Tabla Hash";
            this.btnTablaHash.UseVisualStyleBackColor = false;
            this.btnTablaHash.Click += new System.EventHandler(this.BtnTablaHash_Click);
            // 
            // btnMinHeap
            // 
            this.btnMinHeap.BackColor = System.Drawing.Color.White;
            this.btnMinHeap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinHeap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(60)))), ((int)(((byte)(29)))));
            this.btnMinHeap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinHeap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMinHeap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(60)))), ((int)(((byte)(29)))));
            this.btnMinHeap.Location = new System.Drawing.Point(13, 113);
            this.btnMinHeap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinHeap.Name = "btnMinHeap";
            this.btnMinHeap.Size = new System.Drawing.Size(217, 34);
            this.btnMinHeap.TabIndex = 4;
            this.btnMinHeap.Text = "Min-Heap Rutas";
            this.btnMinHeap.UseVisualStyleBackColor = false;
            this.btnMinHeap.Click += new System.EventHandler(this.BtnMinHeap_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.White;
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReiniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnReiniciar.Location = new System.Drawing.Point(244, 113);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(217, 34);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "Reiniciar Todo";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblResultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblResultados.Location = new System.Drawing.Point(763, 379);
            this.lblResultados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(95, 19);
            this.lblResultados.TabIndex = 4;
            this.lblResultados.Text = "RESULTADOS";
            // 
            // rtbResultados
            // 
            this.rtbResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.rtbResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbResultados.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbResultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.rtbResultados.Location = new System.Drawing.Point(763, 401);
            this.rtbResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbResultados.Name = "rtbResultados";
            this.rtbResultados.ReadOnly = true;
            this.rtbResultados.Size = new System.Drawing.Size(479, 255);
            this.rtbResultados.TabIndex = 5;
            this.rtbResultados.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1259, 689);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlGrafo);
            this.Controls.Add(this.grpSeleccion);
            this.Controls.Add(this.grpOperaciones);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.rtbResultados);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1274, 728);
            this.Name = "MainForm";
            this.Text = "Sistema de Navegación del Campus Universitario";
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