using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //библиотека для использованя команд для открытия и сохранения файлов

namespace cursak
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter vivod = new StreamWriter("vivod.txt"); // создаем переменную для вывода результатов в текстовый файл с названием vivod.txt
            Console.Title = "Курсовая_Работа_Дрозд_313"; //задаем название консоли
            int lenght = 5; //количество строк матрицы
            int height = 5; //количество столбцов матрицы
            double sum = 0; //переменная для нахождения суммы
            double sumelem = 1; //переменная для нахождения суммы
            double z = 0; // пременная для нахождения выражения
            double[,] mat1 = new double[lenght, height]; //инициализация матрицы 5 на 5

            for (int i = 0; i < lenght; i++) // проходим по строкам
            {
                for (int j = 0; j < height; j++) // проходим по столбцам
                {
                        Console.Write("Введите число: "); 
                        mat1[i, j] = int.Parse(Console.ReadLine()); //вводим число
                }

            }
            Console.WriteLine("\n\t\tМатрица №1\n"); vivod.WriteLine("\n\t\tМатрица №1\n"); //выводим заголовок с названием матрицы
            for (int i = 0; i < lenght; i++) // проходим по строкам
            {
                for (int j = 0; j < height; j++)  // проходим по столбцам
                {
                    Console.Write("{0}\t ", mat1[i, j]); //выводим матрицу на экран
                    vivod.Write("{0}\t ", mat1[i, j]); //выводим матрицу в текстовый файл
                }
                Console.WriteLine(); vivod.WriteLine(); // пропускаем строку
            }
            double[,] mat2 = new double[lenght, height]; //инициализируем торую матрицу
            Console.WriteLine("\n\t\tМатрица №2\n"); vivod.WriteLine("\n\t\tМатрица №2\n"); //выводим заголовок с названием матрицы
            for (int i = 0; i < lenght; i++) // проходим по строкам
            {
                for (int j = 0; j < height; j++) // проходим по столбцам
                {
                    mat2[i, j] = Math.Pow(mat1[i, j], 2) - Math.Pow(mat1[0, 1], 1 / 3); //вычисляем значение элемента матрицы по формуле
                    Console.Write("{0}\t ", mat2[i, j]); //выводим элементы на экран
                    vivod.Write("{0}\t ", mat2[i, j]); //выводим элементы в тектстовый документ
                }
                Console.WriteLine(); vivod.WriteLine(); // пропускаем строку
            }
            for (int i = 1; i < lenght; i += 2) // проходим по строкам
            {
                for (int j = 0; j < height; j++) // проходим по столбцам
                {
                    sum += Math.Abs(mat2[i, j]); // находим сумму элементов четных столбцов
                }

            }
            double min = mat2[0, 0]; //создаем перменную которая будет принимать минимальное значение в матрице
            for (int i = 0; i < lenght; i++)  // проходим по строкам
            {
                for (int j = 0; j < height; j++) // проходим по столбцам
                {

                    if (Math.Abs(mat2[0, j]) < min) //если модуль числа меньше чем исходное 
                    {
                        min = mat2[i, j]; // присваем min значение элемента матрицы
                    }
                }
            }
            for (int i = 0; i < lenght; i++) // проходим по строкам
            {
                for (int j = 0; j < height; j++) // проходим по столбцам
                {
                    sumelem += mat2[i, j]; //суммиуем все значения эллементов матрицы
                }
            }
            z = 1 / Math.Tan((3 / 2 * Math.PI) - sumelem); //находим значение выражения
            //выводим рещультат в файл и на экран
            Console.WriteLine("\nСумма четных строк {0}\n", sum); vivod.WriteLine("Сумма четных строк {0}\n", sum); 
            Console.WriteLine("Минимальный элемент {0}\n", min); vivod.WriteLine("Минимальный элемент {0}\n", min);
            Console.WriteLine("Сумма всех элементов матрицы {0}\n", sumelem); vivod.WriteLine("Сумма всех элементов матрицы {0}\n", sumelem);
            Console.WriteLine("Математическое выражение {0}\n", Math.Round(z, 2)); vivod.WriteLine("Математическое выражение {0}\n", Math.Round(z, 2));
            vivod.Close(); //закрываем текстовый файл
            Console.ReadKey(true);
        }
    }
}
