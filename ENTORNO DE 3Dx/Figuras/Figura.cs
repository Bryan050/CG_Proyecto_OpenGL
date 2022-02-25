using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace ENTORNO_DE_3Dx.Figuras
{
    abstract class Figura
    {
        private double AngX;
        private double AngY;
        private double AngZ;
        private double[] Angs;
        private double[] Coordenadas;
        protected float scale;
        protected double[] color;
        public Figura()
        {
            AngX = AngY = AngZ = 0;
            Angs= new double[3];
            color = new double[3];
            color[0] = 0;
            color[1] = 0;
            color[2] = 1;
            Coordenadas = new double[3];

        }
        public void Rotate(double ang, double rotX, double rotY, double rotZ)
        {
            Gl.glRotated(ang, rotX, rotY, rotZ);
        }
        public void ChangeColor(double[] color)
        {
            this.color = color;
        }
        public void ChangeScale(float scale)
        {
            this.scale = scale;
        }
        public float GetScale()
        {
            return this.scale;
        }
        public void Move(double x, double y, double z)
        {
            Gl.glTranslated(x,y,z);
        }
        public void ChangeTexture()
        {
            Gl.glTextureNormalEXT(1);
        }
        public virtual void DrawFigure() {
            
        }
    }
}
