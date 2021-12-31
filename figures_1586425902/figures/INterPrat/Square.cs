using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterPrat
{
    class Squares : GeometryFig,ISimpleNAgnle
    {
        private double[] _arr;
        
        public double this[int pos] { get =>_arr[pos];
            set =>_arr[pos]=value; }

        public double Height { get; set; }
        public double Base { get; set; }
        public double Angel { get; set; }

        public int NumSides => _arr.Length;

        public Squares(double a)
        {
            if (a < 0)
                throw new FormatException("The side can't be negative.");
            _arr = new double[4];
            _arr[0] = _arr[1] = _arr[2] = _arr[3] = a;
            Base = a;
            Angel = 90;
            Height = a;
            
        }



        public override double Peremeter()
        {
            return Base * 4;
        }

        public override double Square()
        {
            return Base * Base;
        }
    }
}
