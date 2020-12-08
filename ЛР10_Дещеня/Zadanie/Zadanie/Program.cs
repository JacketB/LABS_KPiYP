using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Bloknote
{

    public class zapis
    {
        public int num;
        public string name;
        public string famil;
        public DateTime dataroj;
        public string numtel;

        public zapis(int num, string name, string famil, DateTime dataroj, string numtel)
        {
            this.num = num;
            this.name = name;
            this.famil = famil;
            this.dataroj = dataroj;
            this.numtel = numtel;
        }
    }

    public class bloknote : zapis
    {
        public static List<bloknote> notzap = new List<bloknote>();

        public bloknote(int num, string name, string famil, DateTime dataroj, string numtel)
        : base(num, name, famil, dataroj, numtel)
        {

        }
    }
    public class Program
    {
        public int n;
        public static void addzap()
        {
            Console.Write("   |Введите номер записи: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n   |Введите имя: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("\n   |Введите фамилия: ");
            string famil = Convert.ToString(Console.ReadLine());
            Console.Write("\n   |Введите дату рождения: ");
            DateTime dataroj = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\n   |Введите номер телефона: ");
            string numtel = Convert.ToString(Console.ReadLine());
            bloknote zap = new bloknote(num, name, famil, dataroj, numtel);
            bloknote.notzap.Add(zap);

        }
       
        private static void poisk()
        {
            int nomer;
            Console.WriteLine("Введите номер записи: ");
            nomer = int.Parse(Console.ReadLine());
            List<bloknote> ret = new List<bloknote>();
            foreach (bloknote zap in bloknote.notzap) {
                if (zap.num == nomer) ;
                Console.Write("\t" + zap.name + " ");
                Console.Write(zap.famil + " ");
                Console.Write(zap.dataroj);
                Console.Write(" " + zap.numtel);
                break;
            }
            

        }
        
        public static void FamilSort()
        {
            bloknote.notzap.OrderBy(x => x.famil);
        }
        public static void vivod(List<bloknote> zap)
        {
            int count = 0;
            foreach (bloknote i in bloknote.notzap)
            {

                Console.Write("\t"+i.num + " " + i.name + " " + i.famil + " " + i.dataroj + " " + i.numtel + "\n");
                count++;

            }
        }
        private static void DelZap()
        {
            int nomer;
            Console.WriteLine("Введите номер записи: ");
            nomer = int.Parse(Console.ReadLine());
            List<bloknote> ret = new List<bloknote>();
            foreach (bloknote zap in bloknote.notzap)
            {
                if (zap.num == nomer)
                    bloknote.notzap.Remove(zap);
            }
           // throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            List<bloknote> zap1 = new List<bloknote>();

        metka:
            Console.WriteLine("\t #####################\n" +
                              "\t # Добро пожаловать! #\n" +
                              "\t #####################\n");
            Console.WriteLine(" \t______________________");
            Console.WriteLine(" \t|1. Добавить запись   |");
            Console.WriteLine(" \t|2. Удалить запись    | <---- не трогать");
            Console.WriteLine(" \t|3. Сортировать список|");
            Console.WriteLine(" \t|4. Вывести список    |");
            Console.WriteLine(" \t|5. Найти запись      |");
            Console.WriteLine(" \t|_____________________|");
            Console.Write("\n\tВыберите действие ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1: addzap(); Console.Clear(); break;

                    case 2: DelZap(); Console.Clear(); break;

                    case 3: FamilSort(); break;

                    case 4: vivod(zap1); Console.ReadKey(); Console.Clear(); break;

                    case 5: poisk(); Console.ReadKey(); Console.Clear(); break;
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