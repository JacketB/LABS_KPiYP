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
              return naztest ;
            }
            
            void ITest.testing()
            {
                Console.WriteLine(" Тест - пройден");
            }
            void ITest.testingZA()
            {
                Console.WriteLine(" Тест - пройден");
            }
            void ITest.testingZI()
            {
                Console.WriteLine(" Тест - пройден");
            }
            public void print()
            {  
                string name = "Admin";
                Console.Write(name+"\n");
                
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
                Console.WriteLine(" Экзамен - тестируется");
            }
            void IEkzam.testingZA1()
            {
                Console.WriteLine(" Экзамен - пройден");
            }
            void IEkzam.testingZI1()
            {
                Console.WriteLine(" Экзамен - не сдан");
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
                Console.WriteLine(" Выпускной экзамен - не допущен(не проверен экзамен)");
            }
            void IVipEkz.testingZA2()
            {
                Console.WriteLine(" Выпускной экзамен - пройден");
            }
            void IVipEkz.testingZI2()
            {
                Console.WriteLine(" Выпускной экзамен - не допущен(экзамен не сдан)");
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
                Console.WriteLine(" Испытание - не допущен (не проверен выпускной экзамен)");
            }
            void IIsp.testingZA3()
            {
                Console.WriteLine(" Испытание - тестируется");
            }
            void IIsp.testingZI3()
            {
                Console.WriteLine(" Испытание - не допущен (выпускной экзамен не сдан)");
            }
        }
        static void Main(string[] args)
        {
            Test x = new Test();
            Ekzam y = new Ekzam();
            VipEkz z = new VipEkz();
            Isp q = new Isp();
            IIsp z1 = ((IIsp)q);
        metka:
            Console.WriteLine("Выберите студента");
            Console.Write("|1. Дубов А.Б.|\n|2. Лупов З.А.|\n|3. Пупов З.И.|\n");
            int m = int.Parse(Console.ReadLine());
            
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

            Console.ReadKey(true);
        }
    }
}
