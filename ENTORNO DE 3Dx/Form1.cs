using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;

namespace ENTORNO_DE_3Dx
{

    public partial class FormMain : Form
    {
        int eyeX = 800, eyeY = 400, eyeZ = 2300;
        int op = -1;
        Control control;
        Figuras.Esfera es = new Figuras.Esfera();
        public FormMain()
        {
            InitializeComponent();
            CmbBoxFiguras.SelectedIndex = 0;
            Gl.glClearColor(1, 1, 1, 0);
            control = new Control();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnGrafPuntos_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void OpenGlControl_Load(object sender, EventArgs e)
        {
            OpenGlControl.InitializeContexts();
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(-100.0, 100.0, -100.0, 100.0, -100.0, 100.0);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            drawEjes();
        }
        void drawEjes()
        {
            Gl.glLineWidth(20);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3f(1.0f, 0.0f, 1.0f);   //Morado eje x
            Gl.glVertex3f(100, 0.0f, 0.0f);
            Gl.glVertex3f(-100, 0.0f, 0.0f);
            
            Gl.glColor3f(0.0f, 1.0f, 0.0f);   //Verde eje y
            Gl.glVertex3f(0.0f, 100f, 0.0f);
            Gl.glVertex3f(0.0f, -100, 0.0f);
            
            Gl.glColor3f(1.0f, 0.0f, 0.0f);   //Rojo eje z
            Gl.glVertex3f(0.0f, 0.0f, 100);
            Gl.glVertex3f(0.0f, 0.0f, -100);
            Gl.glEnd();
        }
        private void OpenGlControl_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glShadeModel(Gl.GL_SMOOTH);
            switch (op)
            {
                case 0:
                    {
                        es.DrawFigure();
                       // es = null;
                        break;
                    }
            }
        }

        private void BtnGrafCen_Click(object sender, EventArgs e)
        {
            op = CmbBoxFiguras.SelectedIndex;
            
            OpenGlControl.Refresh();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Gl.glClearColor(0,0,0,1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double[] color = new double[3];
            color[0] = 1;
            color[1] = 0;
            color[2] = 0;
            es.ChangeColor(color);
            OpenGlControl.Refresh();
        }

        private void TrkBScale_Scroll(object sender, EventArgs e)
        {

            //MessageBox.Show("cacaasdfasdf " + e.ToString());
            es.ChangeScale(TrkBScale.Value);
            // control.SelectObject().ChangeScale((float)TrkBScale.Value);
            OpenGlControl.Refresh();
        }

        private void OpenGlControl_MouseDown(object sender, MouseEventArgs e)
        {
            //double minZ = 0;
            //int idx = 0;
            //int[] selectBuff = new int[512];
            //int[] Viewports = new int[4];
            
            //Gl.glSelectBuffer(512, selectBuff);
            //Gl.glGetIntegerv(Gl.GL_VIEWPORT, Viewports);
            //Gl.glRenderMode(Gl.GL_SELECT);
            //Gl.glInitNames();
            //Gl.glPushName(-1);

            ////camara aplicar
            //int[] Viewports2 = new int[4];
            //Gl.glGetIntegerv(Gl.GL_VIEWPORT, Viewports2);
            //Gl.glMatrixMode(Gl.GL_PROJECTION);
            //Gl.glLoadIdentity();
            //Glu.gluPickMatrix (e.X, (Viewports2[3] - e.Y), 1, 1, Viewports2);
            //Glu.gluPerspective(Math.PI, 1F, 0.1F, 20000F);
            //Gl.glMatrixMode(Gl.GL_MODELVIEW);
            //Gl.glLoadIdentity();
            //Glu.gluLookAt(eyeX, eyeY, eyeZ, 0, 0, 0, 0, 1, 0);
            ////camara aplicar

            //Gl.glPushMatrix();
            //for (int i = 1; i < Gl.glLis GList.Count; i++)
            //    Gl.glCallList(GList[i]);
            //Gl.glPopMatrix();
            //Gl.glFlush();
            //long hits = Gl.glRenderMode(gl);

            //if (!(hits == 0))
            //{
            //    minZ = 2147483647;
            //    idx = 0;
            //    seleccionado = 0;

            //    int NameNos;
            //    for (int i = 0; i < hits; i++)
            //    {
            //        NameNos = selectBuff[idx];

            //        if ((selectBuff[idx + 1] < minZ) && (NameNos > 0))
            //        {
            //            minZ = selectBuff[idx + 1];
            //            seleccionado = selectBuff[idx + 3];
            //            btn_ocultar.Enabled = true;
            //        }
            //        idx = idx + 3 + NameNos;
            //    }

            //}
            //else
            //{
            //    seleccionado = 0;
            //}
            //ocultar = seleccionado;
            //loaded = true;
        }
    }
}
