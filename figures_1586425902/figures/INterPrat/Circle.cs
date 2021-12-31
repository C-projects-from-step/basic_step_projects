using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace INterPrat
{
    class Circle:GeometryFig,ISimpleNAgnle
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
        public double Radious { get; set; }
        public Circle(double r)
        {
            if (r<=0)
                throw new Exception("Wrong numbers;");
            _arr = new double[0];
            Radious = r;
        }
        public override double Square()
        {
            return Radious * Radious * Math.PI;
        }
        public override double Peremeter()
        {
            return 2*Math.PI*Radious;
        }
    }
}
