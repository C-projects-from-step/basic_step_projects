using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Transport
{
    public class Train:Transport
    {
        public int NumVagons { get; set; }
        public Train(string name, DateTime man, int speed, string color, int num)
            :base( name, man, speed,  color)
        {
            NumVagons = num;
        }
        public override void TimetoDestination()
        {
            Console.WriteLine("Time to Moscow is: 3 hours.");
        }
        public override string ToString()
        {
            return base.ToString() + $"\nNumber of vagons: {NumVagons}";
        }
    }
}
