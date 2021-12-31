using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterPrat
{
    class Parallelogram : GeometryFig, ISimpleNAgnle
    {
       private double[] _arr;

        public double this[int pos]
        {
            get => _arr[pos];
            set => _arr[pos] = value;
        }

        public double Height { get; set; }

        public double Base { get; set; }

        public double Angel { get; set; }

        public int NumSides => _arr.Length;


        public Parallelogram(double a1, double a2,double h, double c)
        {
            if (h <= 0 || a1 <= 0 || a2 <= 0||c<=0||c>179)
                throw new FormatException();
            Base = a1;
            Height = (Square()/a1);
            _arr = new double[4];
            _arr[0] = a1;
            _arr[1] = a2;
            _arr[2] = a1;
            _arr[2] = a2;
            Angel = c;

        }

        public override double Square()
        {
            return Base * Height;
        }

        public override double Peremeter()
        {
            return (_arr[0] + _arr[1])* 2;
        }
    }
}
