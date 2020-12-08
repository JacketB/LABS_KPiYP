using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{

    class Program
    {
        delegate void Poezd(string message);
        static event Poezd Evnt;
        interface Production { void Poezda(); }
        public class afto : Production
        {       
            public void Poezda()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Evnt?.Invoke($" Добавлены данные о Автомобиле");
                Console.ResetColor();
                Console.WriteLine("Автомобиль-средство передвижения по дороге.\n");
                
            }
        }
        public class poezdr : Production
        {
            public void Poezda()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Evnt?.Invoke($" Добавлены данные о Поезде");
                Console.ResetColor();
                Console.WriteLine("Поезд-средство для передвижения по рейсам (занимает больше времени чем на автомобиле).\n");
            }
        }
        public class bistro : Production
        {
            public void Poezda()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Evnt?.Invoke($" Добавлены данные о Экспресс-поезде");
                Console.ResetColor();
                Console.WriteLine("Экспресс-поезд, судно, автобус и другие транспортные средства для поездок на дальние расстояние.\n");
            }
        }
        public class transport : Production
        {
            public void Poezda()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Evnt?.Invoke($" Добавлены данные о Транспортном средстве");
                Console.ResetColor();
                Console.WriteLine("Транспортное средство -техническое устройство для перевозки людей и грузов.\n");
            }
        }
        
        private static void DisplayMessage(string message) // метод для вывода сообщений события
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Evnt += DisplayMessage;
            afto x = new afto();
            x.Poezda();
            poezdr y = new poezdr();
            y.Poezda();
            bistro b = new bistro();
            b.Poezda();
            transport c = new transport();
            c.Poezda();
            Console.ReadKey(true);
        }
    }
}
