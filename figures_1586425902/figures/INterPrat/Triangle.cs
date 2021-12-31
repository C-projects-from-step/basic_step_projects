using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterPrat
{
    class Triangle : GeometryFig,ISimpleNAgnle
    {
       private double[] _arr;

        public double this[int pos] { get=>_arr[pos];
            set => _arr[pos]=value; }

        public double Height { get ; set; }

        public double Base { get; set; }

        public double Angel { get ; set ; }

        public int NumSides =>_arr.Length;




        public Triangle( double a1, double a2, double a3 )
        {
            if (a1 + a2 < a3 && a2 + a3 < a1 && a1 + a3 < a2)
                throw new Exception("Wrong numbers;");

            if(a1<0||a2<0||a3<0)
                throw new Exception("Wrong numbers;");

            Base = a1;
            Angel = Math.Acos((a2 * a2 + a3 * a3 - a1 * a1) / (2 * a2 * a3));
            Height = _arr[0]* _arr[0] + _arr[1] * _arr[1];
           
            _arr = new double[3];
            _arr[0] = a1;
            _arr[1] = a2;
            _arr[2] = a3;

        }

        public override double Square()
        {
            double c = Peremeter();

            return Math.Sqrt(c * (c - _arr[0]) * (c - _arr[1]) * (c - _arr[2]));
        }

        public override double Peremeter()
        {
            return (_arr[0] + _arr[1] + _arr[2])/2;
        }
    }
}
