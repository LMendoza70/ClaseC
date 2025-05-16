using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseC
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos el objeto de la clase rectangulo
            ClsRectangulo miRectangulo = new ClsRectangulo();

            //capturamos los valores de alto y ancho
            Console.WriteLine("Captura el ancho que tendra el rectangulo");
            miRectangulo.setAncho(float.Parse(Console.ReadLine()));

            Console.WriteLine("Captura el Alto del rectangulo");
            miRectangulo.setAlto(float.Parse(Console.ReadLine()));

            Console.WriteLine("El area del rectangulo es : " +miRectangulo.Area()+" m2");
            Console.WriteLine("El Perimetro del rectangulo es : "+miRectangulo.Perimetro()+" m");

            Console.ReadKey();
            
        }
    }
}
