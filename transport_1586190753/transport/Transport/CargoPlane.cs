using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class CargoPlane:Plane
    { public string TranspItems { get; set; }

        public CargoPlane(string name, DateTime man, int speed, string color, string des, string items)
            :base( name, man,  speed,  color,des)
        {
            TranspItems = items;
        }

        public override void TimetoDestination()
        {
            Console.WriteLine("Time to destination is: 2 hours");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nItems for delivering: {TranspItems}";
        }
    }
}
