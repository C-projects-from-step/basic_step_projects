using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {


            Student a = new Student("Olga", "234sd", 21, DateTime.Parse("12.03.2000"), "Female");



            // Student b = new Student("Misha", "234sd", 21, DateTime.Parse("12.03.2000"), "Male");

            //   a.Print();
            int[] c = { 2, 2, 2, };
            a.Print();
            a.AddMarks(Subject.Programming, 1);
            a.AddMarks(Subject.Design,1);
            a.AddMarks(Subject.Administration,1);
            a.Print();
            Console.WriteLine("Bye");

        }
    }

    public enum Subject { Programming, Administration, Design };


    public class Student
    {
        /***********************fields***********************/
        private string _fullName;
        private string _group;
        private int _age;
        private DateTime _birthday;
        private int[][] _marks;
        private static int _quantity;
        public const string School = "MIT";
        private readonly string _gender;
        private  int _id;                                //readonly ???
        /***********************Constractors***********************/
        static Student()
        {
            _quantity = 0;
        }
        public Student(string name, string group, int age, DateTime birthday, string gender)
        {
            _fullName = name;
            _group = group;
            _age = age;
            _birthday = birthday;
            var rand = new Random();

            _marks = new int[3][];


            for (int i = 0; i < _marks.Length; i++)
            {
                _marks[i] = new int[rand.Next(6, 15)];
            }

            for (int i = 0; i < _marks.Length; i++)
            {
                for (int j = 0; j < _marks[i].Length; j++)
                {
                    _marks[i][j] = rand.Next(8, 12);
                }
            }

            _quantity++;
            _gender = gender;
            _id = Student._quantity;

        }

        /***********************Setters and Getters***********************/
        public static int GetQuantity()
        {
            return _quantity;
        }
        public string GetGender()
        {
            return _gender;
        }
        public void SetName(string name) => _fullName = name;
        public string GetName() => _fullName;
        public void SetGroup(string group) => _group = group;
        public string GetGroup() => _group;
        public void SetAge(int age) => _age = age;
        public int GetAge() => _age;
        public void Setbirthday(DateTime birthday) => _birthday = birthday;
        public DateTime Getbirthday() => _birthday;
        public void SetMarks(ref int[][] arr) => _marks = arr;
        public int[][] GetMarks() => _marks;


        // ***********************Methods***********************//
        public void Print()
        {
            Console.WriteLine($" Full name: {_fullName}\n Group: {_group}\n Age: {_age}" +
                $" \n Birthday: {_birthday.Day}.{_birthday.Month}.{_birthday.Year}\n " +
                $"School: {School}\n Gender: {_gender}\n Id:{_id} ");


            if (_marks[0].Length == 0)
            {
                Console.WriteLine("There are not marks for Programming");
            }
            else
            {
                Console.Write("Marks for Programming:    ");
                for (int i = 0; i < _marks[0].Length; i++)
                {

                    Console.Write(_marks[0][i] + " ");
                }

            }

            Console.WriteLine();
            if (_marks[1].Length == 0)
            {
                Console.WriteLine("There are not marks for Administration");
            }
            else
            {
                Console.Write("Marks for Administration: ");
                for (int i = 0; i < _marks[1].Length; i++)
                {

                    Console.Write(_marks[1][i] + " ");
                }

            }

            Console.WriteLine();

            if (_marks[2].Length == 0)
            {
                Console.WriteLine("There are not marks for Design");
            }
            else
            {
                Console.Write("Marks for Design:         ");
                for (int i = 0; i < _marks[2].Length; i++)
                {

                    Console.Write(_marks[2][i] + " ");
                }

            }

            Console.WriteLine();

        }
        public void DeleteMarks(Subject subject, int from, int amount)
        {
            if (from < 0 || from > (_marks[(int)subject].Length)|| from+amount > (_marks[(int)subject].Length))
                 return;

                    int[] tmp = new int[_marks[(int)subject].Length - amount];

                    for (int i = 0, j = 0; i < _marks[(int)subject].Length; i++)
                    {
                        if (i < from || i >= from + amount)
                            tmp[j++] = _marks[(int)subject][i];
                    }
                    _marks[(int)subject] = tmp;

        }
        public void InsertMark(Subject subject, int pos, int mark)
        {
            if (mark > 12 || mark < 1)
                return;

            if (pos > _marks[(int)subject].Length || pos < 0)
                return;
         
                    int[] tmp = new int[_marks[(int)subject].Length + 1];

                    for (int i = 0, j = 0; j < tmp.Length; j++)
                    {
                        if (j == pos)
                        {
                            tmp[j] = mark;

                        }
                        else tmp[j] = _marks[(int)subject][i++];
                    }
                    _marks[(int)subject] = tmp;
             
        }
        public void InsertMarks(Subject subject, int pos, int amount)
        {

            if (pos > _marks[(int)subject].Length || pos < 0)
                return;

            int val = 0;
          
                    int[] tmp = new int[_marks[(int)subject].Length + amount];

                    for (int i = 0, j = 0; j < tmp.Length; j++)
                    {
                        if (j >= pos && j < pos + amount)
                        {

                            Console.WriteLine("Enter a mark: ");

                            Int32.TryParse(Console.ReadLine(), out val);
                            if (val > 0 && val < 13)
                                tmp[j] = val;
                            else
                            {
                                Console.WriteLine("A wrong number!!!. Try again.");
                                j--;
                            }


                        }
                        else tmp[j] = _marks[(int)subject][i++];
                    }
                    _marks[(int)subject] = tmp;
                }
        public void InsertMarksArr(Subject subject, int pos, int[] arr)
        {
            if (pos > _marks[(int)subject].Length || pos < 0)
                return;
            int l = 0, j = 0, i = 0;
         
                    int[] tmp = new int[_marks[(int)subject].Length + arr.Length];

                    for (; i < tmp.Length; i++)
                    {
                        if (i >= pos && i < pos + arr.Length)
                            tmp[i] = arr[j++];

                        else tmp[i] = _marks[(int)subject][l++];

                    }
                    _marks[(int)subject] = tmp;
          
        }
        public void Sort(Subject subject)
        {
                Array.Sort(_marks[(int)subject]);
            
        }
        public void AddMarks(Subject subject, int num)
        {
              int[] temp = new int[_marks[(int)subject].Length + num];
              int val = 0;
              for (int i = 0; i < temp.Length; i++)
              {
                  if (i < _marks[(int)subject].Length)
                      temp[i] = _marks[(int)subject][i];
                  else
                  {
                      Console.WriteLine("Enter a mark: ");
                      Int32.TryParse(Console.ReadLine(), out val);
                      if (val > 0 && val < 13)
                          temp[i] = val;
                      else
                    {
                        Console.WriteLine("A wrong number!!!. Try again.");
                        i--;
                    }

                  }

              }
              _marks[(int)subject] = temp;

        }
        public void AvarageMark(Subject subject)
        {
            double val = 0;
                val = _marks[(int)subject].Sum();
            val = Math.Round(val / _marks[(int)subject].Length, 2);

            if (Subject.Administration == subject)
            {
                if (val != 0)
                {
                   
                    Console.WriteLine("The avarage Mark for Administarion is: " + val);
                }
                else Console.WriteLine("There are not any marks");
            }
            else if (Subject.Design == subject)
            {
                if (val != 0)
                {

                   
                    Console.WriteLine("The avarage Mark for Design is: " + val);
                }
                else Console.WriteLine("There are not any marks");
            }
            else
            {
               
                if (val != 0)
                {
                   
                    Console.WriteLine("The avarage Mark for Programming is: " + val);
                }
                else Console.WriteLine("There are not any marks");
            }

        }
        public int GetMark(Subject subject, int pos)
        {
                if (pos > _marks[(int)subject].Length || pos < 0)
                    return -1;
                return _marks[(int)subject][pos];
            
        }
        public int GetMaxMark(Subject subject)
        {
           
                return _marks[(int)subject].Max();       
            

        }
        public int GetMinMark(Subject subject)
        {
            return _marks[(int)subject].Min();
        }

    }
    


}
