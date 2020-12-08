using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    class Program
    {
        //----создаем делегат
        delegate void Dvigatel(string message);
        //----создаем событие относящееся к делегату
        static event Dvigatel sob;
        //----------интерфейсы-------
        interface IDvig
        {
            string nazDvig();
            void testing();
            void testingdv();
            void testingdv1();
        }
        interface IDvigVnutr 
        {
            string nazDvigVnutr();
            void testing1();
            void testingdvv();
            void testingdvv2();
        }
        interface IDizel 
        {
            string nazDizel();
            void testing2();
            void testingDiz();
            void testingDiz2();
        }
        interface IReact 
        {
            string nazReactt();
            void testing3();
            void testingReact1();
            void testingReact3();
        }
        
        public class Test : IDvig
        {
            string naztest;
            public string nazDvig()
            {
              return naztest ;
            }
            
            void IDvig.testing()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                if (sob != null) sob("произошло действие"); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Двигатель - ЕСТЬ ");
            }
            void IDvig.testingdv()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                if (sob != null) sob("произошло действие"); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Двигатель - ЕСТЬ ");
            }
            void IDvig.testingdv1()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                if (sob != null) sob("произошло действие"); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Двигатель - ЕСТЬ ");
            }
            public void print()
            { 
                string name = "Admin";
                Console.Write(name+"\n");
                
            }
        }

        public class Ekzam : Test, IDvigVnutr
        {
            string nazekz;
            public string nazDvigVnutr()
            {
                return nazekz;
            }
            void IDvigVnutr.testing1()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                if (sob != null) sob(" Добавлены данные о двигателе о типе двигателя "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Двигатель внутреннего сгорания - ЕСТЬ ");
            }
            void IDvigVnutr.testingdvv()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                if (sob != null) sob(" Добавлены данные о двигателе о типе двигателя "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Двигатель внутреннего сгорания - ЕСТЬ ");
            }
            void IDvigVnutr.testingdvv2()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                if(sob != null) sob(" Добавлены данные о двигателе о типе двигателя "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Двигатель внутреннего сгорания - ЕСТЬ ");
            }
        }

        public class VipEkz : Ekzam, IDizel 
        {
            string nazvipEkz;
            public string nazDizel()
            {
                return nazvipEkz;
            }
            void IDizel.testing2()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                if (sob != null)  sob(" Добавлены данные о типе топлива "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Дизель - НЕТ (бензиновый двигатель)");
            }
            void IDizel.testingDiz()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                if (sob != null) sob(" Добавлены данные о типе топлива "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Дизель - ДА ");
            }
            void IDizel.testingDiz2()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                if (sob != null) sob(" Добавлены данные о типе топлива "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Дизель - НЕТ");
            }
        }

        public class Isp : VipEkz, IReact 
        {
            string nazsp;
            string IReact.nazReactt()
            {
                return nazsp;
            }

            void IReact.testing3()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                if (sob != null) sob(" Добавлены данные о наличии реактивного двигателя "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Реактивный двигатель - НЕТ");
            }
            void IReact.testingReact1()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                if (sob != null) sob(" Добавлены данные о наличии реактивного двигателя "); //вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Реактивный двигатель - НЕТ");
            }
            void IReact.testingReact3()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                if (sob != null) sob(" Добавлены данные о наличии реактивного двигателя ");//вызываем событие как метод и выводим сообщение (?.Invoke - метод для проверки на null)
                Console.ResetColor();
                Console.WriteLine(" Реактивный двигатель - ДА");
            }
        }
        private static void DisplayMessage(string message) // метод для вывода сообщений события
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            sob += DisplayMessage; // добавление обработчика события
            Test x = new Test();
            Ekzam y = new Ekzam();
            VipEkz z = new VipEkz();
            Isp q = new Isp();
            IReact z1 = ((IReact)q);
        metka:
            Console.WriteLine("Выберите студента");
            Console.Write("1. Автомобиль\n2. Поезд\n3. Самолет\n");
            int m = int.Parse(Console.ReadLine());
            try
            {
                switch (m)
                {
                    case 1:
                     Console.Clear();
                     Console.WriteLine("\n\tАвтомобиль");
                     ((IDvig)x).testing();
                     ((IDvigVnutr)y).testing1();
                     ((IDizel)z).testing2();
                     z1.testing3();
                     Console.ReadKey();
                     Console.Clear();
                    break;
                
                    case 2:
                     Console.Clear();
                     Console.WriteLine("\n\tПоезд");
                     ((IDvig)x).testingdv();
                     ((IDvigVnutr)y).testingdvv();
                     ((IDizel)z).testingDiz();
                     z1.testingReact1();
                     Console.ReadKey();
                     Console.Clear();
                    break;
                    case 3:
                     Console.Clear();
                     Console.WriteLine("\n\tСамолет");
                     ((IDvig)x).testingdv1();
                     ((IDvigVnutr)y).testingdvv2();
                     ((IDizel)z).testingDiz2();
                     z1.testingReact3();
                     Console.ReadKey();
                     Console.Clear();
                    break;

                }
                goto metka;
            }
            catch
            {

            }

            Console.ReadKey(true);
        }
    }
}
