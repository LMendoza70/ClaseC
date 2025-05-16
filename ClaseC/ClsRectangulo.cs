using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseC
{
    class ClsRectangulo
    {
        //atrubutos
        private float Alto;
        private float Ancho;

        //definimos propiedades
        public float getAlto()
        {
            return Alto;
        }
        public void setAlto(float value)
        {
            Alto = value;
        } 
        public float getAncho()
        {
            return Ancho;
        }

        public void setAncho(float value)
        {
            Ancho = value;
        }

        //metodo constructor
        public ClsRectangulo()
        {
            Ancho = 0;
            Alto = 0;
        }
        //definimos metodos
        public float Area()
        {
            float res = 0;
            res = Alto * Ancho;
            return res;
        }

        public float Perimetro()
        {
            float res = 0;
            res = (Alto + Ancho) * 2;
            //res = Alto + Alto + Ancho + Ancho;
            return res;
        }
    }
}
