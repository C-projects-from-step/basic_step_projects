using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Transport
{
    public class Small_car:Vehicle
    {
        public string Owner { get; set; }
        public Small_car(string name, DateTime man, int speed, string color, string type, string owner)
            :base( name, man,  speed,  color,  type)
        {
            Owner = owner;
        }
        public override void TimetoDestination()
        {
            Console.WriteLine("Time to your destination is : 45 km");
        }
        public override string ToString()
        {
            return base.ToString()+$"\nOwner of the car:{Owner}"; 
        }
    }
}
