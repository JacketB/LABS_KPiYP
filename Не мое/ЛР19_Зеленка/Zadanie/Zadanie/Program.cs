using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;

namespace Zadanie
{
    class Program
    {
        static IEnumerable<String> test;
        static void DirSearch(string sDir)
        {
            foreach (string d in Directory.GetDirectories(sDir))
            {
                
                test = Directory.EnumerateFiles(d, "*.txt", SearchOption.AllDirectories);      
                List<String> filess = test.ToList();
                try
                {
                    if (filess.Count != 0)
                    {
                        Console.WriteLine(d + ":");
                        foreach (string f in test)
                        {
                            string fileName = f.Substring(d.Length + 1);
                            Console.WriteLine(" " + fileName);
                        }
                        Console.WriteLine("\n");

                    }
                    DirSearch(d);
                }
                catch
                {
                    continue;
                }
            }
        }
        static public void mythreadtxt()
        {      
            Console.Write(@"Введите путь(пример C:\SomeDir) -> ");
            string put = Console.ReadLine();
            DirSearch(put);
        } 
        static void Main(string[] args)
        {
            metka:
            Console.WriteLine("\n1.Найти *.txt файлы." +   
                              "\n2.Выход            ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Thread thread1 = new Thread(mythreadtxt);
                    thread1.Start();
                    Console.WriteLine("Нажмите любую клавишу после окончания поиска!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Environment.Exit(0);       
                    break;
            }
            goto metka;
        }
    }
}
