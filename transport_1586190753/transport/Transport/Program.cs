using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            Small_car car = new Small_car("Subaru", DateTime.Now, 320, "blue", "sedan", "Homeless MIcle");
            Track track = new Track("Kamaz", DateTime.Now, 120, "pink", "track", "50tones");
            CargoPlane pl = new CargoPlane("UKraine eagle", DateTime.Now, 1200, "siver", "Tokio", "ice-cream");
            Jet jt = new Jet("Uraine eagle", DateTime.Now, 1200, "siver", "Tokio", 360);
            Train tr = new Train("Fast Ming", DateTime.Parse("12.03.1998"), 120, "Golden", 530);
            Console.WriteLine(tr);
            tr.TimetoDestination();
            //Console.ReadKey();
        }
    }
}
