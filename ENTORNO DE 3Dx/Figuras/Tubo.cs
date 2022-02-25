using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace ENTORNO_DE_3Dx.Figuras
{
    class Tubo:Figura
    {
        private float radioMayor;
        private float radioMenor;
        public Tubo()
        {
            this.radioMayor = 2;
            this.radioMenor = 1;
        }
        public override void DrawFigure(float altura)
        {
            double x, y, z;
            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3d(color[0], color[1], color[2]);
            for (double h = 0; h <= altura; h+=0.01)
            {
                for (double a = 0; a <= 2 * Math.PI; a += 0.005)
                {
                    z = radioMayor * Math.Cos(a) * scale;
                    x = radioMayor * Math.Sin(a) * scale;
                    y = h*scale;
                    Gl.glVertex3d(x, y, z);

                    z = radioMenor * Math.Cos(a) * scale;
                    x = radioMenor * Math.Sin(a) * scale;
                    y = h* scale;
                    Gl.glVertex3d(x, y, z);

                    z = radioMenor * Math.Cos(a) * scale;
                    x = radioMenor * Math.Sin(a) * scale;
                    y = altura * scale;
                    Gl.glVertex3d(x, y, z);

                    z = radioMenor * Math.Cos(a) * scale;
                    x = radioMenor * Math.Sin(a) * scale;
                    y = 0 * scale;
                    Gl.glVertex3d(x, y, z);
                }
            }
            Gl.glEnd();
            Gl.glFlush();
        }
    }
}
