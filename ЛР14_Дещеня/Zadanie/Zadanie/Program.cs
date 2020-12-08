using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    class Program
    {
        //----создаем делегат
        delegate void Tests(string message);
        //----создаем событие относящееся к делегату
        static event Tests Evnt;
        //----------интерфейсы-------
        interface ITest
        {
            string nazTest();
            void testing();
            void testingZA();
            void testingZI();
        }

        interface IEkzam
        {
            string nazEkz();
            void testing1();
            void testingZA1();
            void testingZI1();
        }
        interface IVipEkz
        {
            string nazVipEkz();
            void testing2();
            void testingZA2();
            void testingZI2();
        }
        interface IIsp
        {
            string nazIsp();
            void testing3();
            void testingZA3();
            void testingZI3();
        }

        public class Test : ITest
        {
            string naztest;
            public string nazTest()
            {
                return naztest;
            }

            void ITest.testing()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Evnt?.Invoke($" Добавлены данные о тесте ");//вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Тест - пройден\n");
            }
            void ITest.testingZA()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Evnt?.Invoke($" Добавлены данные о тесте "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Тест - пройден\n");
            }
            void ITest.testingZI()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Evnt?.Invoke($" Добавлены данные о тесте "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Тест - пройден\n");
            }
            public void print()
            {
                string name = "Admin";
                Console.Write(name + "\n");
            }
        }

        public class Ekzam : Test, IEkzam
        {
            string nazekz;
            public string nazEkz()
            {
                return nazekz;
            }
            void IEkzam.testing1()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Evnt?.Invoke($" Добавлены данные о экзамене "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Экзамен - тестируется\n");
            }
            void IEkzam.testingZA1()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Evnt?.Invoke($" Добавлены данные о экзамене "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Экзамен - пройден\n");
            }
            void IEkzam.testingZI1()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Evnt?.Invoke($" Добавлены данные о экзамене "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Экзамен - не сдан\n");
            }
        }

        public class VipEkz : Ekzam, IVipEkz
        {
            string nazvipEkz;
            public string nazVipEkz()
            {
                return nazvipEkz;
            }
            void IVipEkz.testing2()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Evnt?.Invoke($" Добавлены данные о выпускном экзамене "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Выпускной экзамен - не допущен(не проверен экзамен)\n");
            }
            void IVipEkz.testingZA2()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Evnt?.Invoke($" Добавлены данные о выпускном экзамене "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Выпускной экзамен - пройден\n");
            }
            void IVipEkz.testingZI2()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Evnt?.Invoke($" Добавлены данные о выпускном экзамене "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Выпускной экзамен - не допущен(экзамен не сдан)\n");
            }
        }

        public class Isp : VipEkz, IIsp
        {
            string nazsp;
            string IIsp.nazIsp()
            {
                return nazsp;
            }

            void IIsp.testing3()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Evnt?.Invoke($" Добавлены данные о испытании "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Испытание - не допущен (не проверен выпускной экзамен)\n");
            }
            void IIsp.testingZA3()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Evnt?.Invoke($" Добавлены данные о испытании "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Испытание - тестируется\n");
            }
            void IIsp.testingZI3()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Evnt?.Invoke($" Добавлены данные о испытании "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Испытание - не допущен (выпускной экзамен не сдан)\n");
            }
        }
        private static void DisplayMessage(string message) // метод для вывода сообщений события
        {
            Console.WriteLine(message);
        }
        public static void Main(string[] args)
        {
            Evnt += DisplayMessage; // добавление обработчика события
            Test x = new Test();
            Ekzam y = new Ekzam();
            VipEkz z = new VipEkz();
            Isp q = new Isp();
            IIsp z1 = ((IIsp)q);
        metka:
            Console.WriteLine("Выберите студента");
            Console.Write("|1. Дубов А.Б.|\n|2. Лупов З.А.|\n|3. Пупов З.И.|\n|4. Выход     |\n");
            int m = int.Parse(Console.ReadLine());

            try
            {
                switch (m)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("\n\tДубов А.Б");
                        ((ITest)x).testing();
                        ((IEkzam)y).testing1();
                        ((IVipEkz)z).testing2();
                        z1.testing3();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n\tЛупов З.А.");
                        ((ITest)x).testingZA();
                        ((IEkzam)y).testingZA1();
                        ((IVipEkz)z).testingZA2();
                        z1.testingZA3();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n\tПупов З.И");
                        ((ITest)x).testingZI();
                        ((IEkzam)y).testingZI1();
                        ((IVipEkz)z).testingZI2();
                        z1.testingZI3();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
                goto metka;
            }
            catch
            {
                goto metka;
            }

            
        }
    }
}
