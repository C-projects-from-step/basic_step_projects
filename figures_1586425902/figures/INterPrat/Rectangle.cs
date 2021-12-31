using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterPrat
{
    class Rectangle : GeometryFig, ISimpleNAgnle
    {
        private double[] _arr;
        public double this[int pos] {
            get => _arr[pos];
            set => _arr[pos]=value; }

        public double Height { get; set; }

        public double Base { get; set; }

        public double Angel { get; set; }

        public int NumSides => _arr.Length;

        public Rectangle(double a, double b)
        {
            if (a <= 0 || b <= 0)
                throw new FormatException();
            _arr = new double[4];
            _arr[0] = _arr[2] = b;
            _arr[1] = _arr[3] = a;
            Angel = 90;
            Base = a;
            Height = b;

        }

        public override double Peremeter()
        {
            return (_arr[0] + _arr[1]) * 2;
        }

        public override double Square()
        {
            return (_arr[0] * _arr[1]);
        }
    }
}
