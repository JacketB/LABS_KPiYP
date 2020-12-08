using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    class Program
    {
        //----------интерфейсы-------
        interface IIgr
        {
            string nazIgr();
            void testing();
            void testingZA();
            void testingZI();
        }
        interface Iprod 
        {
            string nazEkz();
            void testing1();
            void testingZA1();
            void testingZI1();
        }
        interface Itov 
        {
            string nazVipEkz();
            void testing2();
            void testingZA2();
            void testingZI2();
        }
        interface Imolprod 
        {
            string nazIsp();
            void testing3();
            void testingZA3();
            void testingZI3();
        }
        
        public class Igr : IIgr
        {
            string nazigr;
            public string nazIgr()
            {
              return nazigr ;
            }
            
            void IIgr.testing()
            {
                Console.WriteLine(" Игрушек - 251 шт");
            }
            void IIgr.testingZA()
            {
                Console.WriteLine(" Игрушек - 15 шт");
            }
            void IIgr.testingZI()
            {
                Console.WriteLine(" Игрушек - 45 шт");
            }
            public void print()
            {
                string name = "Admin";
                Console.Write(name+"\n");  
            }
        }

        public class Prod : Igr, Iprod
        {
            string nazprod;
            public string nazEkz()
            {
                return nazprod;
            }
            void Iprod.testing1()
            {
                Console.WriteLine(" Продуктов - 67 ящ.");
            }
            void Iprod.testingZA1()
            {
                Console.WriteLine(" Продуктов - 79 ящ.");
            }
            void Iprod.testingZI1()
            {
                Console.WriteLine(" Продуктов - 154 ящ.");
            }
        }

        public class Tov : Prod, Itov
        {
            string naztov;
            public string nazVipEkz()
            {
                return naztov;
            }
            void Itov.testing2()
            {
                Console.WriteLine(" Товаров всего - 1890");
            }
            void Itov.testingZA2()
            {
                Console.WriteLine(" Товаров всего - 1070");
            }
            void Itov.testingZI2()
            {
                Console.WriteLine(" Товаров всего - 4500");
            }
        }

        public class MolProd : Tov, Imolprod
        {
            string nazmol;
            string Imolprod.nazIsp()
            {
                return nazmol;
            }

            void Imolprod.testing3()
            {
                Console.WriteLine(" Молочные продукты - 45 ящ.");
            }
            void Imolprod.testingZA3()
            {
                Console.WriteLine(" Молочные продукты - 68 ящ.");
            }
            void Imolprod.testingZI3()
            {
                Console.WriteLine(" Молочные продукты - 79 ящ.");
            }
        }
        static void Main(string[] args)
        {
            Igr x = new Igr();
            Prod y = new Prod();
            Tov z = new Tov();
            MolProd q = new MolProd();
            Imolprod z1 = ((Imolprod)q);
        metka:
            Console.WriteLine("Выберите магазин");
            Console.Write("1. Доброном \n2. Копеечка\n3. Евроопт\n");
            int m = int.Parse(Console.ReadLine());
            try
            {
                switch (m)
                {
                    case 1:
                     Console.Clear();
                     Console.WriteLine("\n\tДоброном");
                     ((IIgr)x).testing();
                     ((Iprod)y).testing1();
                     ((Itov)z).testing2();
                     z1.testing3();
                     Console.ReadKey();
                     Console.Clear();
                    break;
                
                    case 2:
                     Console.Clear();
                     Console.WriteLine("\n\tКопеечка.");
                     ((IIgr)x).testingZA();
                     ((Iprod)y).testingZA1();
                     ((Itov)z).testingZA2();
                     z1.testingZA3();
                     Console.ReadKey();
                     Console.Clear();
                    break;
                    case 3:
                     Console.Clear();
                     Console.WriteLine("\n\tЕвроопт");
                     ((IIgr)x).testingZI();
                     ((Iprod)y).testingZI1();
                     ((Itov)z).testingZI2();
                     z1.testingZI3();
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
