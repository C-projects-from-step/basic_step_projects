using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterPrat
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle m = new Circle( 2);
            Squares ds = new Squares(2);
            double f = 0;

            BuildFig test = new BuildFig();
            test.Add(ds);
            test.Add(m);
            test.Del(0);
            f = test.TotalSqueare();
           // double l = m.Square();
            Console.WriteLine(f);
           // Console.WriteLine(l);
        }
    }
}
