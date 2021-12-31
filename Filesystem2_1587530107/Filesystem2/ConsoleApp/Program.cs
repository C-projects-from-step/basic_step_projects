using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
  //      Реализовать свою консоль.
  //Должны быть реализованы минимум такие команды:  
  //  help
  //  cls
  //  dir
  //  cd
  //  copy
  //  del
  //  mkdir
        static void Main(string[] args)
        {
            //DirectoryInfo info = new DirectoryInfo(@"C: \Users");
            //MyConsole.CD();
          //  string f = @"C:\Users\Alex\Downloads\Somedirectory\dire";
            // FileInfo file = new FileInfo(f);
            // MyConsole.Del(file);
            //string des = @"C:\Users\Alex\Desktop\copyfile.txt";
            //MyConsole.Copy(f, des, true);
            // MyConsole.MKDiR(f);
            MyConsole.Menu();

        }
    }
}
