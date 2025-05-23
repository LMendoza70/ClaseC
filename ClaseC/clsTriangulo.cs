using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseC
{
    class clsTriangulo : ClsFigura
    {
        //atributos
        private float _LadoA, _LadoB, _LadoC;
        //propiedades
        public float LadoA
        {
            get { return _LadoA; }
            set { _LadoA = value; }
        }

        //se ocupa LadoA=5;  setLadoA(5);  variable=LadoA;   variable=getLadoA();
        public float LadoB
        {
            get { return _LadoB; }
            set { _LadoB = value; }
        }

        public float LadoC
        {
            get { return _LadoC; }
            set { _LadoC = value; }
        }

        //cosntructor
        public clsTriangulo()
        {
            _LadoA = 0;
            _LadoB = 0;
            _LadoC = 0;
        }

        public clsTriangulo(float LA, float LB, float LC)
        {
            _LadoA = LA;
            _LadoB = LB;
            _LadoC = LC;
        }

        public clsTriangulo(clsTriangulo copia)
        {
            _LadoA = copia._LadoA;
            _LadoB = copia._LadoB;
            _LadoC = copia._LadoC;
        }

        //metodos
        public override float Area()
        {
            float res = 0;
            float s = (_LadoA+_LadoB+_LadoC) / 2;
            res = (float)Math.Sqrt(s*(s-_LadoA)*(s-_LadoB)*(s-_LadoC));
            return res;
        }

        public override float Perimetro()
        {
            float res = 0;
            res = _LadoA + _LadoB + _LadoC;
            return res;
        }

    }
}
