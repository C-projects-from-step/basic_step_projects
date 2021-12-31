using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public abstract class Vehicle : Transport
    {
        public string Type { get; set; }

        public Vehicle(string name, DateTime man, int speed, string color, string type) :
            base(name, man, speed, color)
        {
            Type = type;
        }

        public override void TimetoDestination()
       {
            Console.WriteLine("Do someting");
        }
        

        

        public override string ToString()
        {
            return base.ToString() + $"\nType of the car: {Type}";
                
        }
    }
}
