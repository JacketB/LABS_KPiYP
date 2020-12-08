using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Zadanie
{
    class Program
    {
        static void findMyText(string text, MatchCollection myMatch)
        {
            //Console.WriteLine("\n\nИсходная строка:\n\n{ 0}\n\nВидоизмененная строка:\n", text);

            // Реализуем выделение ключевых слов в консоли другим цветом
            for (int i = 0; i < text.Length; i++)
            {
                foreach (Match m in myMatch)
                {
                    if ((i >= m.Index) && (i < m.Index + m.Length))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.ReadKey(true);
                        break;

                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.Write(text[i]);
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // Инициализация переменных
            string path = @"K:\В\Учеба\КПиЯП\ЛР15_Дещеня\Zadanie1\Zadanie1\bin\Debug\text.txt";
            string text;
            text = "";
            

            using (FileStream fstream = File.OpenRead($"{path}"))
            {
                
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                text = System.Text.Encoding.UTF8.GetString(array);
                Console.WriteLine($"Текст из файла:\n{text}\n");
            }
            // Разбиваем текст на слова (в массив строк)
            string[] textArray = text.Split(new char[] { ' ' });

            // Данные массива (кол-во слов)
            Console.WriteLine("Кол-во слов: {0}.", textArray.Length);

            // Самое длинное слово (берем первое)
            string longestWord = "";

            // Перебираем слова
            for (int i = 0; i < textArray.Length; i++)
            {
                // Сравниваем длины слов
                if ((textArray[i].Length >= longestWord.Length))
                    // Если длиннее, значит берем его
                    longestWord = textArray[i];
            }

            Regex regex = new Regex(longestWord);
            MatchCollection matches = regex.Matches(text);
            findMyText(text, matches);

            //строка1
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n██████████████████████████████");
            Console.ResetColor();
            //строка 2
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██████████████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("██████████████"); Console.ResetColor();
            //строка 3
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 4
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("███"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("███"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 5
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 6
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 7
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("███"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("███"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 8
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("███"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("███"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 9
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("███"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("███"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 10
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("███"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("███"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 11
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 12
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 13
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 14
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("███"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 15
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 16
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 17
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 18
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██████████████████████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 16
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████"); Console.ResetColor();
            //строка 20
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██████████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██████████"); Console.ResetColor();
            Console.WriteLine(" ");
            //строка 21
            Console.Write("  ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██████████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██████████"); Console.ResetColor();
            Console.WriteLine(" ");
            //строка 22
            Console.Write("   ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("███████████"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("██"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("███████████"); Console.ResetColor();
            Console.WriteLine(" ");
            //строка 23
            Console.Write("     ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████████████████████"); Console.ResetColor();
            Console.WriteLine(" ");
            //строка 24
            Console.Write("       ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████████████████"); Console.ResetColor();
            Console.WriteLine(" ");
            //строка 25
            Console.Write("         ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████████████"); Console.ResetColor();
            Console.WriteLine(" ");
            Console.ReadKey(true);
        }

    }
}



