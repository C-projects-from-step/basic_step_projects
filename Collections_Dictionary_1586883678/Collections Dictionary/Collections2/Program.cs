using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            Word_Calculator word_Calculator = new Word_Calculator();

            string str = "The whole secret of a successful life is to find out what is one’s destiny to do, and then do it";

            word_Calculator.Calculate_words(str);
            word_Calculator.Display();



        }
    }
}
