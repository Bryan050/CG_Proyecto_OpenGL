using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace ENTORNO_DE_3Dx.Figuras
{
    class Esfera:Figura
    {
        private float radio;
        public Esfera()
        {
            this.radio = 1;
        }
        public override void DrawFigure()
        {
            base.DrawFigure();
            double x, y, z;
            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3d(color[0], color[1], color[2]);
            for (double t = 0; t <= 2 * Math.PI; t += 0.005)
            {
                for (double a = 0; a <= 2 * Math.PI; a += 0.005)
                {
                    x = radio * Math.Cos(a) * Math.Sin(t) * scale;
                    y = radio * Math.Sin(a) * Math.Sin(t) * scale;
                    z = radio * Math.Cos(t) * scale;
                    Gl.glVertex3d(x, y, z);
                }
            }
            Gl.glEnd();
            Gl.glFlush();
        }
    }
}
