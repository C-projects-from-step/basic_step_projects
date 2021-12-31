using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double b =MathHelper.Asin(0.5) ;    //Math.Sqrt(1 - (0.5) * 0.5);

            Console.WriteLine(b);

            double a = Math.Asin(0.5);
            Console.WriteLine(a);

        }






    }

    public static class MathHelper
    {
       public static double Exponenta(double num)
        {
           
            double res = 1;
           
            while (num>0)
            {
               res*= Math.E;
                num--;
            }


            return res;
        }

       public static double Asin(double num)
        {
            if (num >= 0 && num <= 1)
            {
                num = Math.Acos(Math.Sqrt(1 - (num) * num));
                return num;
            }
            return -1; 
        }

       public static double Dis3(double x1, double x2, double y1, double y2, double z1, double z2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));
                       
            return distance;
        }
        
        public static T[,] MaTrans<T>(T[,] arr)
        {
            int col = arr.GetUpperBound(0) + 1;
            int row = arr.Length / col;


            T[,] tarr = new T [row,col];

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    tarr[j, i] = arr[i, j];
                }
            }

            return tarr;
        }
        
    }



}
