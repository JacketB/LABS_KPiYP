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
        static void DirSearchexe(string sDir)
        {
            foreach (string d in Directory.GetDirectories(sDir))
            {

                test = Directory.EnumerateFiles(d, "*.exe", SearchOption.AllDirectories);
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
                    DirSearchexe(d);
                }
                catch
                {
                    continue;
                }
            }
        }
        static void DirSearchsln(string sDir)
        {
            foreach (string d in Directory.GetDirectories(sDir))
            {

                test = Directory.EnumerateFiles(d, "*.sln", SearchOption.AllDirectories);
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
                    DirSearchsln(d);
                }
                catch
                {
                    continue;
                }
            }
        }
        static void DirSearchpng(string sDir)
        {
            foreach (string d in Directory.GetDirectories(sDir))
            {

                test = Directory.EnumerateFiles(d, "*.png", SearchOption.AllDirectories);
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
                    DirSearchpng(d);
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
        static public void mythreadexe()
        {
            Console.Write(@"Введите путь(пример C:\SomeDir) -> ");
            string put = Console.ReadLine();
            DirSearchexe(put);
        }
        static public void mythreadsln()
        {
            Console.Write(@"Введите путь(пример C:\SomeDir) -> ");
            string put = Console.ReadLine();
            DirSearchsln(put);
        }
        static public void mythreadpng()
        {
            Console.Write(@"Введите путь(пример C:\SomeDir) -> ");
            string put = Console.ReadLine();
            DirSearchpng(put);
        }
        static void Main(string[] args)
        {
            Console.Title = "Многопоточный поиск файлов";
            metka:
            Console.WriteLine("|  Добро пожаловать  |" +
                              "\n|1.Найти *.txt файлы.|" +
                              "\n|2.Найти *.exe файлы |" +
                              "\n|3.Найти *.sln файлы |" +
                              "\n|4.Найти *.png файлы |" +
                              "\n|5.Выход             |" +
                              "\n!!!После окончания поиска нажмите на любую клавишу!!!");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Thread thread1 = new Thread(mythreadtxt);
                    thread1.Start();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Thread thread2 = new Thread(mythreadexe);
                    thread2.Start();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Thread thread3 = new Thread(mythreadsln);
                    thread3.Start();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Thread thread4 = new Thread(mythreadpng);
                    thread4.Start();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }

            goto metka;
        }
    }
}
