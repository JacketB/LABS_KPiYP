using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument Notebooks = new XmlDocument();
            Notebooks.Load("XMLFile1.xml");
            Console.Title = "Задание";
            Console.WriteLine("\t\t|Каталог ноутбуков|");
            foreach (XmlNode i in Notebooks.DocumentElement)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("№ {0}", i.Attributes[0].Value);
                Console.ResetColor();
                Console.WriteLine("Модель: {0}", i["Model"].InnerText);
                Console.WriteLine("Процессор: {0}", i["Proccesor"].InnerText);
                Console.WriteLine("Объем оперативной памяти: {0}", i["OZU"].InnerText);
                Console.WriteLine("Объем встроенной памяти: {0}", i["Pam"].InnerText);               
                Console.WriteLine("Цена: {0}\n", i["Zena"].InnerText);
            }
            Console.ReadKey(true);
        }
    }
}
