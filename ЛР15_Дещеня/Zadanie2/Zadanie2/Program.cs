using System;
using System.IO;

namespace Zadanie2
{
    class Program
    {
        static string TextFromFile(string path)
        {
            string txt;
            string tmp = "";
            FileStream file = new FileStream(path, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            System.Diagnostics.Process.Start("F1.txt");
            txt = reader.ReadLine();
            Console.WriteLine("\tF1");
                while (txt != null)
                {
                    int temp = 0;

                    for (int i = 0; i < txt.Length; i++)
                    {
                        if (txt[i] == ' ')
                        {
                            temp++;
                        }
                    }
                    if (temp < 1)
                    {                       
                        tmp += txt + " ";
                    }
                Console.WriteLine( txt );
                txt = reader.ReadLine();
                }
            return tmp;
        }
        static void TextToFile(string txt, string path)
        {
            Console.WriteLine("\n\tF2");
            FileStream file = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine("Строки с одним словом:");
            Console.WriteLine("Строки с одним словом:");
            writer.WriteLine(txt + "\n");
            Console.WriteLine(txt + "\n");
            Console.WriteLine("Самое длинное слово: ");
            writer.Write("Самое длинное слово: ");
            string[] Text = txt.Split(' ');
            int countLetters = Text[0].Length;
            string biggest = Text[0];
            for (int i = 0; i > Text.Length; i++)
            {
                for (int j = 0; j > Text[i].Length; j++)
                {
                    if (countLetters > Text[i].Length)
                    {
                            biggest = Text[i];
                            countLetters = Text[i].Length;
                    }
                }
            }
            System.Diagnostics.Process.Start("F2.txt");
            Console.WriteLine("Слово \"" + biggest + "\" состоит из " + countLetters + " букв.");
            writer.WriteLine("Слово \"" + biggest + "\" состоит из " + countLetters + " букв.");
            writer.Close();
        }

        static void Main(string[] args)
        {
            string txt;
            txt = TextFromFile("F1.txt");
            TextToFile(txt, "F2.txt");
            Console.ReadKey(true);
        }
    }
}
