using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Vocabulary
    {
        private Dictionary<string, string> EngRus;
        private Dictionary<string, string> RusEng;

        public Vocabulary()
        {
            EngRus = new Dictionary<string, string>();
            EngRus.Add("Ukraine", "Украина");
            EngRus.Add("Russia", "Россия");
            EngRus.Add("Belorussia", "Белоруссия");
            EngRus.Add("Italy", "Италия");
            EngRus.Add("Germany", "Германия");
            EngRus.Add("Denmark", "Дания");
            EngRus.Add("England", "Англия");
            EngRus.Add("USA", "США");
            EngRus.Add("Brazil", "Бразилия");
            EngRus.Add("Australia", "Австралия");
            EngRus.Add("New Zealand", "Новая Зеландия");
            RusEng = new Dictionary<string, string>();
            RusEng.Add("Украина", "Ukraine");
            RusEng.Add("Россия", "Russia");
            RusEng.Add("Белоруссия", "Belorussia");
            RusEng.Add( "Италия","Italy");
            RusEng.Add("Германия","Germany" );
            RusEng.Add( "Дания","Denmark");
            RusEng.Add("Англия","England" );
            RusEng.Add( "США","USA");
            RusEng.Add("Бразилия","Brazil" );
            RusEng.Add("Австралия","Australia" );
            RusEng.Add("Новая Зеландия","New Zealand" );

        }

        public void Add_Word(string key, string value)
        {

            EngRus.Add(key, value);
            RusEng.Add(value, key);
        }

        public void Del_Word(string word)
        {
            string value;
            if (EngRus.TryGetValue(word, out value))
            {
                EngRus.Remove(word);
                RusEng.Remove(value);
            }
            else if (RusEng.TryGetValue(word, out value))
            {
                RusEng.Remove(word);
                EngRus.Remove(value);
            }

        }

        public string TranslateEng(string word)
        {
            if (EngRus.TryGetValue(word, out string value))
                return EngRus[word];
            return "There is not such word in the Dictionary";
        }

        public string TranslateRus(string word)
        {
            if (RusEng.TryGetValue(word, out string value))
                return RusEng[word];
            return "There is not such word in the Dictionary";
        }

        public string Translate(string word)
        {
            if (RusEng.TryGetValue(word, out string value))
                return RusEng[word];
            else if (EngRus.TryGetValue(word, out string valu))
                return EngRus[word];
            return "There is not such word in the Dictionary";
        }

        public void Menu()
        {
            Console.WriteLine("Dictionary", 18);
            do
            {
                Console.WriteLine("Choose your dictionary: ");
                Console.WriteLine("English to Russian, press 1 ");
                Console.WriteLine("Russian to English, press 2 ");
                Console.WriteLine("Both, press 3 ");
                Console.WriteLine("Add a word, press 4 ");
                Console.WriteLine("Delete a word, press 5 ");
                Console.WriteLine("Leave traslator, press 6");

                int n = Convert.ToInt32(Console.ReadLine());
                string word=null;
                if (n != 6)
                {
                    Console.WriteLine("Enter a word: ");
                    word = Console.ReadLine();
                }
                else Console.WriteLine("Bye");

                Console.Clear();
               
                    switch (n)
                {
                    case 1: Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine(TranslateEng(word));
                            Console.ResetColor();
                            break;
                    case 2: Console.WriteLine(TranslateRus(word)); break;
                    case 3: Console.WriteLine(Translate(word)); break;
                    case 4:
                        Console.WriteLine("Enter a translation");
                        string val = Console.ReadLine();
                        Add_Word(word, val); break;
                    case 5: Del_Word(word); break;
                    case 6: return;

                    default: Console.WriteLine("Try again"); break;
                }
               
               


            } while (true);

        }
    }
}

