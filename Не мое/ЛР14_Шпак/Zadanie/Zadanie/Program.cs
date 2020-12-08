using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    class Program
    {
        delegate void Shop(string message);
        static event Shop Evnt;

        //----------интерфейсы-------
        interface Mlek
        {
            string nazmleko();
            void ml1();
            void ml2();
            void ml3();
        }
        interface Parn 
        {
            string nazparn();
            void parn();
            void parn1();
            void parn2();
        }
        interface Ptiz 
        {
            string nazPtiz();
            void ptiz();
            void ptiz1();
            void ptiz2();
        }
        interface Jiv 
        {
            string nazJiv();
            void jiv();
            void jiv1();
            void jiv2();
        }
        
        public class Mlekop : Mlek
        {
            string nazmlek;
            public string nazmleko()
            {
              return nazmlek;
            }
            
            void Mlek.ml1()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                if (Evnt != null) Evnt(" Добавлены данные о млекопитающем "); 
                Console.ResetColor();
                Console.WriteLine("Млекопитающее - Кит\n");
            }
            void Mlek.ml2()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                if (Evnt != null) Evnt(" Добавлены данные о млекопитающем ");
                Console.ResetColor();
                Console.WriteLine("Млекопитающее - Медведь\n");
            }
            void Mlek.ml3()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                if (Evnt != null) Evnt(" Добавлены данные о млекопитающем ");
                Console.ResetColor();
                Console.WriteLine("Млекопитающее - Белка\n");
            }
        }

        public class Parnk : Mlekop, Parn
        {
            string nazpar;
            public string nazparn()
            {
                return nazpar;
            }
            void Parn.parn()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                if (Evnt != null) Evnt(" Добавлены данные о парнокопытном ");
                Console.ResetColor();
                Console.WriteLine("Парнокопытное - Лошадь\n");
            }
            void Parn.parn1()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                if (Evnt != null) Evnt(" Добавлены данные о парнокопытном ");
                Console.ResetColor();
                Console.WriteLine("Парнокопытное - Корова\n");
            }
            void Parn.parn2()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                if (Evnt != null) Evnt(" Добавлены данные о парнокопытном ");
                Console.ResetColor();
                Console.WriteLine("Парнокопытное - Осел\n");
            }
        }

        public class Ptiza : Parnk, Ptiz
        {
            string nazptiz;
            public string nazPtiz()
            {
                return nazptiz;
            }
            void Ptiz.ptiz()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                if (Evnt != null) Evnt(" Добавлены данные о птице ");
                Console.ResetColor();
                Console.WriteLine("Птица - Аист\n");
            }
            void Ptiz.ptiz1()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                if (Evnt != null) Evnt(" Добавлены данные о птице ");
                Console.ResetColor();
                Console.WriteLine("Птица - Пеликан\n");
            }
            void Ptiz.ptiz2()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                if (Evnt != null) Evnt(" Добавлены данные о птице ");
                Console.ResetColor();
                Console.WriteLine("Птица - Попугай\n");
            }
        }

        public class Jivot : Ptiza, Jiv
        {
            string nazjiv;
            string Jiv.nazJiv()
            {
                return nazjiv;
            }

            void Jiv.jiv()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                if (Evnt != null) Evnt(" Добавлены данные о животном ");
                Console.ResetColor();
                Console.WriteLine("Животное - таракан\n");
            }
            void Jiv.jiv1()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                if (Evnt != null) Evnt(" Добавлены данные о животном");
                Console.ResetColor();
                Console.WriteLine("Животное - змея\n");
            }
            void Jiv.jiv2()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                if (Evnt != null) Evnt(" Добавлены данные о животном");
                Console.ResetColor();
                Console.WriteLine("Животное - крокодил\n");
            }
        }
        private static void DisplayMessage(string message) // метод для вывода сообщений события
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Evnt += DisplayMessage;
            Mlekop x = new Mlekop();
            Parnk y = new Parnk();
            Ptiza z = new Ptiza();
            Jivot q = new Jivot();
            Jiv z1 = ((Jiv)q);
        metka:
            Console.WriteLine("Выберите магазин");
            Console.Write("1. Набор 1 \n2. Набор 2\n3. Набор 3\n");
            int m = int.Parse(Console.ReadLine());
            try
            {
                switch (m)
                {
                    case 1:
                     Console.Clear();
                     Console.WriteLine("\n\tНабор 1");
                     ((Mlek)x).ml1();
                     ((Parn)y).parn();
                     ((Ptiz)z).ptiz();
                     z1.jiv();
                     Console.ReadKey();
                     Console.Clear();
                    break;
                
                    case 2:
                     Console.Clear();
                     Console.WriteLine("\n\tНабор 2");
                     ((Mlek)x).ml2();
                     ((Parn)y).parn1();
                     ((Ptiz)z).ptiz1();
                     z1.jiv1();
                     Console.ReadKey();
                     Console.Clear();
                    break;
                    case 3:
                     Console.Clear();
                     Console.WriteLine("\n\tНабор 3");
                     ((Mlek)x).ml3();
                     ((Parn)y).parn2();
                     ((Ptiz)z).ptiz2();
                     z1.jiv2();
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
