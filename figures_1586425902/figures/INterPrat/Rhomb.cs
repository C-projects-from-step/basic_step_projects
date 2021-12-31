using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterPrat
{
    class Rhomb : GeometryFig,ISimpleNAgnle
    {
        private double[] _arr;

        public double this[int pos] { get =>_arr[pos];
            set =>_arr[pos]=value; }

        public double Height { get; set;}
        public double Base { get; set; }
        public double Angel { get; set; }

        public int NumSides => _arr.Length;

        public Rhomb(double b, double a, double c)
        {
            if (b <= 0 || a <= 0||c<=0||c>=180)
                throw new FormatException();
            double m = Square();
            Height = m/a;
            Base = a;
            _arr = new double[4];
            _arr[0] = _arr[2] = b;
            _arr[1] = _arr[3] = a;
        }

        public override double Peremeter()
        {
            return Base * 4;
        }

        public override double Square()
        {
            return Base * Height;
        }
    }
}
