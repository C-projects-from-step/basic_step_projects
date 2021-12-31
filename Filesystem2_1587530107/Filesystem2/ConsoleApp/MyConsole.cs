using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp
{//      Реализовать свою консоль.
 //Должны быть реализованы минимум такие команды:  
 //  help
 //  cls
 //  dir
 //  cd
 //  copy
 //  del
 //  mkdir
    public static class MyConsole
    {
        public static void Help()
        {
            Console.WriteLine("help -  This command would print a list of all commands to the console. ");
            Console.WriteLine("cls  -  Clears (erases) the screen.");
            Console.WriteLine("dir  -  Displays a list of a directory's files and subdirectories.");
           
            Console.WriteLine("cd   -  Displays the name of or changes the current directory. ");
            Console.WriteLine("copy -  Copies one or more files from one location to another.");
            Console.WriteLine("Syntacs:  copy name.txt c:users\\john...");
           
            Console.WriteLine("del  -  Deletes one or more files. This command is the same as the erase command.");
            Console.WriteLine("Syntacs: del name.txt or del c:\\.....");
            Console.WriteLine("mkdir-  Creates a directory or subdirectory.");
            Console.WriteLine("doskey/history - to see all typed commands");
            Console.WriteLine("exit - to go out");
        }
        public static void ClS()
        {
            Console.Clear();
        }
        public static void Dir(string path)
        {
            DirectoryInfo f = new DirectoryInfo(path);
            if (!f.Exists)
            { Console.WriteLine("The directory does not exict");
                return;
            }
                Console.WriteLine($"The folder contains: {f.FullName,-10}\n");
                int dir = 0;
                int sizeF = 0;
                foreach (var item in f.GetDirectories())
                {
                    Console.WriteLine($"{item.CreationTime.ToShortDateString()}   {item.CreationTime.ToShortTimeString()}  <DIR>     {item.Name}");
                    dir++;
                }
                int file = 0;
                foreach (var item in f.GetFiles())
                {
                    Console.WriteLine($"{item.CreationTime.ToShortDateString()}   {item.CreationTime.ToShortTimeString()}  {item.Length,-5}     {item.Name}");
                    file++;
                    sizeF += (int)item.Length;
                }
                Console.WriteLine($"{file,15} files.  ");
                Console.WriteLine($"{dir,15} directories. ");
        }
        public static void Dir()
        {
            DirectoryInfo f = new DirectoryInfo(Directory.GetCurrentDirectory());
                Console.WriteLine($"The folder contains: {f.FullName,-10}\n");
                int dir = 0;
                int sizeF = 0;
                foreach (var item in f.GetDirectories())
                {
                    Console.WriteLine($"{item.CreationTime.ToShortDateString()}   {item.CreationTime.ToShortTimeString()}  <DIR>     {item.Name}");
                    dir++;
                }
                int file = 0;
                foreach (var item in f.GetFiles())
                {
                    Console.WriteLine($"{item.CreationTime.ToShortDateString()}   {item.CreationTime.ToShortTimeString()}  {item.Length,-5}     {item.Name}");
                    file++;
                    sizeF += (int)item.Length;
                }
                Console.WriteLine($"{file,15} files.  ");
                Console.WriteLine($"{dir,15} directories. ");
        }
        public static void CD(string f)
        {
            Directory.SetCurrentDirectory(f);
            Console.WriteLine(Directory.GetCurrentDirectory());
        }
        public static void CD()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
        }
        public static void Copy(string path, string newpath)
        {
            File.Copy(path, newpath);
        }
        public static void Del(string path)
        {
            int index =path.IndexOf("\\");
            if (index == -1)
            {
                string str = Directory.GetCurrentDirectory();
                path = str + "\\" + path;
            }
            

            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                f.Delete();
            }
        }
        public static void MKDiR(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }
        public static void Menu()
        {
            Console.WriteLine("Kiev. 21.04.2020. All rights are reserved. ");
            Console.WriteLine();
            List<string> history = new List<string>();
           
            while (true)
            {
                try
                {
                    Console.WriteLine(Directory.GetCurrentDirectory());
                    string str = Console.ReadLine();
                    str=str.Trim();
                    history.Add(str);
                   
                    if (str == "cls")
                    {
                        ClS();
                    }
                    else if (str.StartsWith("help"))
                    {
                        Help();
                    }
                    else if (str.StartsWith("dir"))
                    {
                       if(str=="dir")
                        Dir();
                        else
                        {
                            str = str.Remove(0, 3);
                            str.TrimStart();
                            Dir(str);

                        }
                    }
                    else if (str.StartsWith("cd"))
                    {
                       
                        str=str.Remove(0, 2);
                        str.Trim();
                        CD(str);

                    }
                    else if (str.StartsWith("copy")){ // copy name.txt c:users\john...
                        string  path =Directory.GetCurrentDirectory();
                       
                        str = str.Remove(0, 5);
                       
                        int index = str.IndexOf(' ');
                        string str1 = str.Substring(0,index);
                        str = str.Remove(0, index);
                        str = str.TrimStart();
                        str1 = @"\" + str1;
                        str = str + str1;
                        path = path + str1;


                        Copy(path, str);
                    }
                    else if (str.StartsWith("del")) // del name.txt or del c:\.....
                    {
                        str = str.Remove(0, 4);
                        str = str.TrimStart();
                        Del(str);
                    }
                    else if (str.StartsWith("mkdir"))
                    {
                        str = str.Remove(0, 5);
                        str = str.TrimStart();
                        MKDiR(str);

                    }
                    else if (str.Equals("exit"))
                    {
                        return;
                    }else if (str.StartsWith( "doskey/history") || str.StartsWith( "doskey/History"))
                    {
                        foreach (var com in history)
                        {
                            Console.WriteLine(com);
                        }

                    }
                    else Console.WriteLine("There are not matched results.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
