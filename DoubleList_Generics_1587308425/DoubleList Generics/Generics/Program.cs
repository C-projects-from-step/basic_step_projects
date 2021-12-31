using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleList<string> list = new DoubleList<string>();
            list.Add_Last("Man");
            list.Add_First("Marina");
            list.Add_Pos("Misha", 1);
            list.Add_Range(2, "Sveta", "Tania");
            list.Add_Range(4, "Vova", "Nikita", "Arnest");
            foreach (var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
            list.Del_Data("Vova");

            //foreach (var t in list.BackEnumerator())
            //{
            //    Console.WriteLine(t);
            //}

            foreach (var el in list)
            {
                Console.WriteLine(el);
            }







        }
    }
}
