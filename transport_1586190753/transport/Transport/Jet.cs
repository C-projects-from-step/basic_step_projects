using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Transport
{
    public class Jet:Plane
    {public int NumPass { get; set; }
        public Jet(string name, DateTime man, int speed, string color, string des,int num)
            :base( name,  man,  speed,  color, des)
        {
            NumPass = num;
        }
        public override void TimetoDestination()
        {
            Console.WriteLine($"Time for jet airplane to {Destinaiton} is:5 hours ");
        }
        public override string ToString()
        {
            return base.ToString() + $"\nNumber of passangers: {NumPass}";
        }
    }
}
