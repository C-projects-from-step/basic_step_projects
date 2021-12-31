using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Delegate
{
    class Program
    {
        public delegate bool Found(Object a);
        static void Main(string[] args)
        {
            Object[] arr = { 5, 3, "s", "fs", 'm', 4 };
            Object a = 4;
            Found found = ca => (Object.Equals(ca, a));
            Console.WriteLine(Element(arr, found));


            
        }

       


        public static int Element(Object[] arr, Found found)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (found(arr[i]) == true)
                    return i;
            }
            return -1;
        }
    }
}
