using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
   public abstract class Plane:Transport
    {
         public string Destinaiton { get; set; }

        public Plane(string name, DateTime man, int speed, string color, string des)
            :base( name,  man,speed, color)
        {
            Destinaiton = des;
        }

        public override void TimetoDestination()
        {
            Console.WriteLine("Your destinaiton time is: 12 min.");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nThe final destinaiton is: {Destinaiton}";
        }

    }
}
