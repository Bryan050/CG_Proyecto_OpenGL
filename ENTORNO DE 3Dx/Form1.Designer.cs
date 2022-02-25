
namespace ENTORNO_DE_3Dx
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrbPositions = new System.Windows.Forms.GroupBox();
            this.Lbltitulo = new System.Windows.Forms.Label();
            this.GrbFiguras = new System.Windows.Forms.GroupBox();
            this.BtnGrafCen = new System.Windows.Forms.Button();
            this.BtnGrafCoord = new System.Windows.Forms.Button();
            this.BtnGrafPuntos = new System.Windows.Forms.Button();
            this.LblFig = new System.Windows.Forms.Label();
            this.CmbBoxFiguras = new System.Windows.Forms.ComboBox();
            this.OpenGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TrkBScale = new System.Windows.Forms.TrackBar();
            this.LblScale = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.trackBarRota = new System.Windows.Forms.TrackBar();
            this.GrbPositions.SuspendLayout();
            this.GrbFiguras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrkBScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRota)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbPositions
            // 
            this.GrbPositions.Controls.Add(this.radioButton1);
            this.GrbPositions.Controls.Add(this.LblScale);
            this.GrbPositions.Controls.Add(this.TrkBScale);
            this.GrbPositions.Controls.Add(this.BtnLimpiar);
            this.GrbPositions.Location = new System.Drawing.Point(566, 48);
            this.GrbPositions.Name = "GrbPositions";
            this.GrbPositions.Size = new System.Drawing.Size(200, 114);
            this.GrbPositions.TabIndex = 0;
            this.GrbPositions.TabStop = false;
            this.GrbPositions.Text = "Interacción";
            // 
            // Lbltitulo
            // 
            this.Lbltitulo.AutoSize = true;
            this.Lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltitulo.Location = new System.Drawing.Point(550, 8);
            this.Lbltitulo.Name = "Lbltitulo";
            this.Lbltitulo.Size = new System.Drawing.Size(232, 37);
            this.Lbltitulo.TabIndex = 1;
            this.Lbltitulo.Text = "Figuras en 3D";
            // 
            // GrbFiguras
            // 
            this.GrbFiguras.Controls.Add(this.BtnGrafCen);
            this.GrbFiguras.Controls.Add(this.BtnGrafCoord);
            this.GrbFiguras.Controls.Add(this.BtnGrafPuntos);
            this.GrbFiguras.Controls.Add(this.LblFig);
            this.GrbFiguras.Controls.Add(this.CmbBoxFiguras);
            this.GrbFiguras.Location = new System.Drawing.Point(566, 168);
            this.GrbFiguras.Name = "GrbFiguras";
            this.GrbFiguras.Size = new System.Drawing.Size(200, 132);
            this.GrbFiguras.TabIndex = 2;
            this.GrbFiguras.TabStop = false;
            this.GrbFiguras.Text = "Figuras";
            // 
            // BtnGrafCen
            // 
            this.BtnGrafCen.Location = new System.Drawing.Point(63, 90);
            this.BtnGrafCen.Name = "BtnGrafCen";
            this.BtnGrafCen.Size = new System.Drawing.Size(88, 23);
            this.BtnGrafCen.TabIndex = 4;
            this.BtnGrafCen.Text = "Graficar Centro";
            this.BtnGrafCen.UseVisualStyleBackColor = true;
            this.BtnGrafCen.Click += new System.EventHandler(this.BtnGrafCen_Click);
            // 
            // BtnGrafCoord
            // 
            this.BtnGrafCoord.Location = new System.Drawing.Point(119, 46);
            this.BtnGrafCoord.Name = "BtnGrafCoord";
            this.BtnGrafCoord.Size = new System.Drawing.Size(75, 38);
            this.BtnGrafCoord.TabIndex = 3;
            this.BtnGrafCoord.Text = "Graficar por Coordenadas";
            this.BtnGrafCoord.UseVisualStyleBackColor = true;
            // 
            // BtnGrafPuntos
            // 
            this.BtnGrafPuntos.Location = new System.Drawing.Point(22, 46);
            this.BtnGrafPuntos.Name = "BtnGrafPuntos";
            this.BtnGrafPuntos.Size = new System.Drawing.Size(75, 38);
            this.BtnGrafPuntos.TabIndex = 2;
            this.BtnGrafPuntos.Text = "Graficar por Puntos";
            this.BtnGrafPuntos.UseVisualStyleBackColor = true;
            this.BtnGrafPuntos.Click += new System.EventHandler(this.BtnGrafPuntos_Click);
            // 
            // LblFig
            // 
            this.LblFig.AutoSize = true;
            this.LblFig.Location = new System.Drawing.Point(19, 22);
            this.LblFig.Name = "LblFig";
            this.LblFig.Size = new System.Drawing.Size(39, 13);
            this.LblFig.TabIndex = 1;
            this.LblFig.Text = "Figura:";
            // 
            // CmbBoxFiguras
            // 
            this.CmbBoxFiguras.FormattingEnabled = true;
            this.CmbBoxFiguras.Items.AddRange(new object[] {
            "Esfera",
            "Corazón",
            "Flecha",
            "Cubo",
            "Toro",
            "Piramide",
            "Jarrón",
            "Cono",
            "Cilindro",
            "Tuvo"});
            this.CmbBoxFiguras.Location = new System.Drawing.Point(73, 19);
            this.CmbBoxFiguras.Name = "CmbBoxFiguras";
            this.CmbBoxFiguras.Size = new System.Drawing.Size(121, 21);
            this.CmbBoxFiguras.TabIndex = 0;
            // 
            // OpenGlControl
            // 
            this.OpenGlControl.AccumBits = ((byte)(0));
            this.OpenGlControl.AutoCheckErrors = false;
            this.OpenGlControl.AutoFinish = false;
            this.OpenGlControl.AutoMakeCurrent = true;
            this.OpenGlControl.AutoSwapBuffers = true;
            this.OpenGlControl.BackColor = System.Drawing.Color.Black;
            this.OpenGlControl.ColorBits = ((byte)(32));
            this.OpenGlControl.DepthBits = ((byte)(16));
            this.OpenGlControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.OpenGlControl.Location = new System.Drawing.Point(0, 0);
            this.OpenGlControl.Margin = new System.Windows.Forms.Padding(2);
            this.OpenGlControl.Name = "OpenGlControl";
            this.OpenGlControl.Size = new System.Drawing.Size(411, 411);
            this.OpenGlControl.StencilBits = ((byte)(0));
            this.OpenGlControl.TabIndex = 3;
            this.OpenGlControl.Load += new System.EventHandler(this.OpenGlControl_Load);
            this.OpenGlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.OpenGlControl_Paint);
            this.OpenGlControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OpenGlControl_MouseDown);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(119, 71);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 0;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TrkBScale
            // 
            this.TrkBScale.LargeChange = 50;
            this.TrkBScale.Location = new System.Drawing.Point(64, 19);
            this.TrkBScale.Maximum = 50;
            this.TrkBScale.Name = "TrkBScale";
            this.TrkBScale.Size = new System.Drawing.Size(104, 45);
            this.TrkBScale.TabIndex = 1;
            this.TrkBScale.Tag = "";
            this.TrkBScale.Scroll += new System.EventHandler(this.TrkBScale_Scroll);
            // 
            // LblScale
            // 
            this.LblScale.AutoSize = true;
            this.LblScale.Location = new System.Drawing.Point(19, 19);
            this.LblScale.Name = "LblScale";
            this.LblScale.Size = new System.Drawing.Size(39, 13);
            this.LblScale.TabIndex = 2;
            this.LblScale.Text = "Escala";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 71);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // trackBarRota
            // 
            this.trackBarRota.LargeChange = 50;
            this.trackBarRota.Location = new System.Drawing.Point(588, 326);
            this.trackBarRota.Maximum = 50;
            this.trackBarRota.Name = "trackBarRota";
            this.trackBarRota.Size = new System.Drawing.Size(104, 45);
            this.trackBarRota.TabIndex = 4;
            this.trackBarRota.Tag = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 411);
            this.Controls.Add(this.trackBarRota);
            this.Controls.Add(this.GrbFiguras);
            this.Controls.Add(this.Lbltitulo);
            this.Controls.Add(this.GrbPositions);
            this.Controls.Add(this.OpenGlControl);
            this.Name = "FormMain";
            this.Text = "ENTORNO DE 3D";
            this.GrbPositions.ResumeLayout(false);
            this.GrbPositions.PerformLayout();
            this.GrbFiguras.ResumeLayout(false);
            this.GrbFiguras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrkBScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbPositions;
        private System.Windows.Forms.Label Lbltitulo;
        private System.Windows.Forms.GroupBox GrbFiguras;
        private System.Windows.Forms.ComboBox CmbBoxFiguras;
        private System.Windows.Forms.Button BtnGrafCoord;
        private System.Windows.Forms.Button BtnGrafPuntos;
        private System.Windows.Forms.Label LblFig;
        private Tao.Platform.Windows.SimpleOpenGlControl OpenGlControl;
        private System.Windows.Forms.Button BtnGrafCen;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label LblScale;
        private System.Windows.Forms.TrackBar TrkBScale;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TrackBar trackBarRota;
    }
}

