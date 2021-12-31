using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            DirectoryInfo info = new DirectoryInfo(@"C:\Users\Alex\Downloads");
            Console.WriteLine(Sum(ref info));
        }

        public static int Sum(ref DirectoryInfo f)
        {
            int m = 0;
            foreach (var el in f.GetFiles())
            {
                m += (int)el.Length;
            }
            DirectoryInfo[] dirs = f.GetDirectories();
            if (dirs.Length == 0)
                return m;
            else
            {
                for (int i = 0; i < dirs.Length; i++)
                {
                    m += Sum(ref dirs[i]);
                }
            }
            return m;
        }
    }
}
