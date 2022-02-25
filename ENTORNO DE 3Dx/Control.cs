using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;
namespace ENTORNO_DE_3Dx
{
    class Control
    {
        public Control()
        {

        }
        public Figuras.Figura SelectObject()
        {
            Gl.glRenderMode(Gl.GL_SELECT);
            return null;
        }
        public void ChangeColor(Object Figura,ConsoleColor c)
        {
            
            //.changeColor();
        }
   
    }
}
