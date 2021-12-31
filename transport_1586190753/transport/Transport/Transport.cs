using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Transport
{
    public abstract class Transport
    {
        public string Name { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        public Transport(string name, DateTime man, int speed, string color)
        {
            Name = name;
            ManufactureDate = man;
            Speed = speed;
            Color = color;
        }
        public abstract void TimetoDestination();
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Manufacutre date: {ManufactureDate.ToShortDateString()}\n" +
                $"Speed: {Speed}\n" +
                $"Color: {Color}";
        }
    }
}
