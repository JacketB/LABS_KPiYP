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
                Console.WriteLine("Млекопитающее - Кит");
            }
            void Mlek.ml2()
            {
                Console.WriteLine("Млекопитающее - Медведь");
            }
            void Mlek.ml3()
            {
                Console.WriteLine("Млекопитающее - Белка");
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
                Console.WriteLine("Парнокопытное - Лошадь");
            }
            void Parn.parn1()
            {
                Console.WriteLine("Парнокопытное - Корова");
            }
            void Parn.parn2()
            {
                Console.WriteLine("Парнокопытное - Осел");
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
                Console.WriteLine("Птица - Аист");
            }
            void Ptiz.ptiz1()
            {
                Console.WriteLine("Птица - Пеликан");
            }
            void Ptiz.ptiz2()
            {
                Console.WriteLine("Птица - Попугай");
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
                Console.WriteLine("Животное - таракан");
            }
            void Jiv.jiv1()
            {
                Console.WriteLine("Животное - змея");
            }
            void Jiv.jiv2()
            {
                Console.WriteLine("Животное - крокодил");
            }
        }
        static void Main(string[] args)
        {
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
