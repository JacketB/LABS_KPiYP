using System;
using System.IO;

namespace Zadanie2
{
    class Program
    {
        static string Textizfile(string path)
        {
            string text;
            string tempText = "";
            FileStream file = new FileStream(path, FileMode.Open);
            StreamReader reader;        
                reader = new StreamReader(file);
                text = reader.ReadLine();
                while (text != null)
                {
                    int temp = 0;

                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i] == ' ')
                        {
                            temp++;
                        }
                    }
                    if (temp < 1)
                    {
                        tempText += text + " ";
                    }
                    text = reader.ReadLine();
                }
                return tempText;
        } 
        static void Textvfile(string text, string path)
        {
            FileStream file = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(text);
            Console.WriteLine(text);
            writer.Write("Самое короткое слово: ");
            Console.WriteLine("Самое короткое слово: ");
                string[] Text = text.Split(' ');
                int kolvo = Text[0].Length;
                string korotkoeslovo = Text[0];
                for (int i = 0; i < Text.Length; i++)
                {
                    for (int j = 0; j < Text[i].Length; j++)
                    {
                        if (kolvo > Text[i].Length)
                        {
                            korotkoeslovo = Text[i];
                            kolvo = Text[i].Length;
                        }
                    }
                }
            Console.WriteLine(korotkoeslovo + " состоит из " + kolvo + " букв.");
                writer.WriteLine(korotkoeslovo + " состоит из " + kolvo + " букв.");
            System.Diagnostics.Process.Start("F2.txt");
            writer.Close();
        }
        static void Main(string[] args)
        {
            string text;
            text = Textizfile("F1.txt");
            Textvfile(text, "F2.txt");
            Console.ReadLine();
        }
    }
}