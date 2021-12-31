using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Word_Calculator
    {
        Dictionary< string,int> _dictionary;

        public Word_Calculator()
        {
            _dictionary = new Dictionary<string, int>();
        }

       public  void Calculate_words(string str)
        {
            string[] str1 = str.Split(" ,.!?:;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
           

            for (int i = 0; i < str1.Length; i++)
            {
                if (_dictionary.ContainsKey(str1[i]))
                    _dictionary[str1[i]] = _dictionary[str1[i]] + 1;
                else
                    Add_Word( str1[i].ToString(),1);
            }
        }

        private void Add_Word( string value,int key)
        {
            _dictionary.Add(value, key );
        } 

        public void Display()
        {
           foreach (var words in _dictionary)
            {
                Console.WriteLine($"This word: {words.Key,5} was found {words.Value,5} times.");
               
            }
        }

        public void CleanDictionary()
        {
            _dictionary.Clear();
        }


    }
}
