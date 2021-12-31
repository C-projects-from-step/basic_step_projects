using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Transport
{
   public class Track:Vehicle
    {
        public string CarringCapacity { get; set; }
        public Track(string name, DateTime man, int speed, string color, string type, string cap)
            : base(name, man, speed, color, type)
        {
           CarringCapacity = cap;
        }
        public override void TimetoDestination()
        {
            Console.WriteLine("Time to your destination is : 50 km");
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCaring capacity of the car: {CarringCapacity}";
        }
    }
}
