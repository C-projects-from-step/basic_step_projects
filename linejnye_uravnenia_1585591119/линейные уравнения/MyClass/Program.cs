using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    

    class Program
    {
        static void Main(string[] args)
        {
            
            
                Myclass first = new Myclass();
                Myclass second = new Myclass();


                first = Myclass.Parse("2,3,7 ");
                second = Myclass.Parse("1,4,6");

                double a = 0, b = 0;

                (a, b) = Myclass.Fun(first, second);
                Console.WriteLine(a);
                Console.WriteLine(b);
            

        }
    }

    class Myclass
    {
        private  int _a;
        private  int _b;
        private  int _c;

       public Myclass() 
        {
            _a = 0;
            _b = 0;
            _c = 0;
        }

        public void SetA(int a) => _a = a;
        public void SetB(int b) => _b = b;
        public void SetC(int c) => _c = c;
        public int GetA() => _a;
        public int GetB() => _b;
        public int GetC() => _c;

       
        public  static Myclass Parse(string n)
        {
            string[] arr = n.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
          
            if(arr.Length!=3)
                throw new FormatException("Not enough parameters");

            Myclass extra = new Myclass();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if(!Char.IsDigit(arr[i][j]))
                          throw new FormatException("Wrong format!!!");                   
                }

                if (i == 0)
                   extra._a = int.Parse(arr[0]);
                
                else if(i==1)
                    extra._b = int.Parse(arr[1]);

                else extra._c = int.Parse(arr[2]);

            }
            return extra;
           
        } 

        public static  (double , double ) Fun(Myclass first, Myclass second)
        {
            double del = first._a * second._b - second._a * first._b;
            if (del == 0)
                throw new ArgumentOutOfRangeException("Del=0");

            double del1 = first._c * second._b - second._c * first._b;
            double del2 = first._a * second._c - second._a * first._c;

            

            double x = 0, y = 0;
            x = del1 / del;
            y = del2 / del;

            return (x, y);
        }
        
       }


    }




