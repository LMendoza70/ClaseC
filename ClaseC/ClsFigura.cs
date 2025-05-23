using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseC
{
    abstract class ClsFigura
    {
        public abstract float Area();


        public abstract float Perimetro();

        public string Descripcion()
        {
            return "Esto es una simple fugura";
        }
       
    }
}
