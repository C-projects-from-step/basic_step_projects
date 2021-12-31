using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

using System.Runtime.Serialization;
using System.IO;

namespace PaySheet
{
    class Program
    {
        static void Main(string[] args)
        {

           
           
            PaySheet april2 = new PaySheet { DayPayment = 23, TotalDays = 3, FineforOneDayDelay = 5, NumberDaysPaymentDelays = 6 };
            PaySheet.Flag = false;
         //  Console.WriteLine(april2);

            var bf = new BinaryFormatter();
            using (var fs = File.Create("paysheet.bin"))
            {
                bf.Serialize(fs, april2);
            }
            Console.WriteLine("3");
            PaySheet april3 = null;
            using (var fs = File.OpenRead("paysheet.bin"))
            {
                april3 = (PaySheet)bf.Deserialize(fs);
            }
            Console.WriteLine(april3);


        }
    }
}
