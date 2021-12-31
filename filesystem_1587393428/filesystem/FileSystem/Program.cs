using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystem
{
    class Program
    {
        //       1. Даны два текстовых файла f1 и   f2.Переписать с сохранением порядка
        //содержимое из  f1 в  f2 и  из f2  в f1(использовать дополнительный
        //файл). 
        //2. Даны два текстовых файла f и g.Записать в файл h вначале содержимое
        //файла f, потом - содержимое файла g с сохранением порядка.
        //3. Дан файл  f, содержащий целые  числа.Записать в  файл g  все элементы
        //файла f, которые: 
        //a.являются четными числами.
        //b.делятся нацело на 3 и не делятся нацело на 7

        static void Main(string[] args)
        {
            //1
            //using (var fs1 = new FileStream("test.txt", FileMode.Open))
            //{
            //    using (var sr = new StreamReader(fs1, Encoding.Default))
            //    {
            //        using (var fs = new FileStream("Myfile4.txt", FileMode.Create))
            //        {
            //            using (var sw = new StreamWriter(fs, Encoding.Default))
            //            {
            //                sw.WriteLine(sr.ReadToEnd());
            //                Console.WriteLine("Done");
            //            }
            //        }
            //    }
            //}
            //using (var fs1 = new FileStream("Myfile6.txt", FileMode.Open))
            //{
            //    using (var sr = new StreamReader(fs1, Encoding.Default))
            //    {
            //        using (var fs = new FileStream("test.txt", FileMode.Create))
            //        {
            //            using (var sw = new StreamWriter(fs, Encoding.Default))
            //            {
            //                sw.WriteLine(sr.ReadToEnd());
            //                Console.WriteLine("Done");
            //            }
            //        }
            //    }
            //}
            //using (var fs1 = new FileStream("Myfile4.txt", FileMode.Open))
            //{
            //    using (var sr = new StreamReader(fs1, Encoding.Default))
            //    {
            //        using (var fs = new FileStream("Myfile6.txt", FileMode.Create))
            //        {
            //            using (var sw = new StreamWriter(fs, Encoding.Default))
            //            {
            //                sw.WriteLine(sr.ReadToEnd());
            //                Console.WriteLine("Done");
            //            }
            //        }
            //    }
            //}
            //2
            //using (var fs1 = new FileStream("f.txt", FileMode.Open))
            //{
            //    using (var sr = new StreamReader(fs1, Encoding.Default))
            //    {
            //        using (var fs = new FileStream("h.txt", FileMode.Create))
            //        {
            //            using (var sw = new StreamWriter(fs, Encoding.Default))
            //            {
            //                sw.WriteLine(sr.ReadToEnd());
            //                Console.WriteLine("Done");
            //            }
            //        }
            //    }
            //}
            //using (var fs1 = new FileStream("g.txt", FileMode.Open))
            //{
            //    using (var sr = new StreamReader(fs1, Encoding.Default))
            //    {
            //        using (var fs = new FileStream("h.txt", FileMode.Append))
            //        {
            //            using (var sw = new StreamWriter(fs, Encoding.Default))
            //            {
            //                sw.WriteLine(sr.ReadToEnd());
            //                Console.WriteLine("Done");
            //            }
            //        }
            //    }
            //}
            //3
             //StringBuilder str = new StringBuilder();
            //using (var fs1 = new FileStream("f.txt", FileMode.Open))
            //{
            //    using (var sr = new StreamReader(fs1, Encoding.Default))
            //    {
            //        str.Append(sr.ReadToEnd());
            //        str.Append(" ");
            //    }
            //}
            //string str1 = str.ToString();
            //string[] arr = str1.Split("!,.? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //int num = 0;
            //using (var fs1 = new FileStream("h.txt", FileMode.Create))
            //{
            //    using (var sr = new StreamWriter(fs1, Encoding.Default))
            //    {
            //        using (var fs = new FileStream("g.txt", FileMode.Create))
            //        {
            //            using (var s = new StreamWriter(fs, Encoding.Default))
            //            {
            //                for (int i = 0; i < arr.Length; i++)
            //                {
            //                    num = Convert.ToInt32(arr[i]);
            //                    if(num % 2 == 0)
            //                    {
            //                        sr.WriteLine(arr[i]);
            //                    }
            //                    if(num % 3 == 0 && num % 7 != 0)
            //                    {
            //                        s.WriteLine(arr[i]);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
        }
    }
}
