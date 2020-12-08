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
        public int numtel;

        public zapis(int num, string name, string famil, DateTime dataroj, int numtel)
        {
            this.num = num;
            this.name = name;
            this.famil = famil;
            this.dataroj = dataroj;
            this.numtel = numtel;
        }
    }

    public class bloknote : zapis, IComparable
    {
        public static List<bloknote> notzap = new List<bloknote>();

        public bloknote(int num, string name, string famil, DateTime dataroj, int numtel)
        : base(num, name, famil, dataroj, numtel)
        {

        }

        public int CompareTo(object obj)
        {
            bloknote b = obj as bloknote;
            return string.Compare(this.famil, b.famil);
        }
    }
    public class Program
    {
        public int n;
        
        public static void addzap()
        {
            int num;
            DateTime dataroj;
            int numtel;
        metka10:
            try
            {
                Console.Write("   |Введите номер записи: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Некоректный ввод данных!");
                Console.ResetColor();
                goto metka10;
            }
                Console.Write("\n   |Введите имя: ");
                string name = Convert.ToString(Console.ReadLine());
                Console.Write("\n   |Введите фамилия: ");
                string famil = Convert.ToString(Console.ReadLine());
            metka9:
            try
            {
                Console.Write("\n   |Введите дату рождения(ДД.ММ.ГГГГ): ");
                dataroj = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Некоректный ввод данных! Ввод должен быть формата ДД.ММ.ГГГГ!");
                Console.ResetColor();
                goto metka9;
            }
            metka8:
            try
            {
                Console.Write("\n   |Введите номер телефона: ");
                numtel = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Некоректный ввод данных!");
                Console.ResetColor();
                goto metka8;
            }    
                bloknote zap = new bloknote(num, name, famil, dataroj, numtel);
                bloknote.notzap.Add(zap);

        }

        private static void poisk()
        {
            try { 
            int nomer;
            Console.WriteLine("Введите номер записи: ");
            nomer = int.Parse(Console.ReadLine());
            List<bloknote> ret = new List<bloknote>();
            foreach (bloknote zap in bloknote.notzap)
            {
                if (zap.num == nomer)
                {
                    Console.Write("\t" + zap.name + " ");
                    Console.Write(zap.famil + " ");
                    Console.Write(zap.dataroj);
                    Console.Write(" " + zap.numtel);

                }

            }
                }
            catch
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Такой записи нет!");
                Console.ResetColor();
            }


        }

        public static void FamilSort()
        {
            
                bloknote.notzap.Sort();
                foreach (bloknote i in bloknote.notzap)
                {
                    Console.Write("\t" + i.num + " " + i.name + " " + i.famil + " " + i.dataroj + " " + i.numtel + "\n");
                }
            if (bloknote.notzap.Count == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Лист пуст!");
                Console.ResetColor();
            }


        }

        public static void vivod(List<bloknote> zap)
        {
          
                int count = 0;
                foreach (bloknote i in bloknote.notzap)
                {

                    Console.Write("\t" + i.num + " " + i.name + " " + i.famil + " " + i.dataroj + " " + i.numtel + "\n");
                    count++;

                }      
                if (bloknote.notzap.Count == 0)
                {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Лист пуст!");
                Console.ResetColor();
                }
            
        }
        private static void DelZap()
        {
            
            
                int nomer;
                Console.WriteLine("Введите номер записи: ");
                nomer = int.Parse(Console.ReadLine());
                List<bloknote> ret = new List<bloknote>();
                for (int i = 0; i < bloknote.notzap.Count; i++)
                {
                    if (bloknote.notzap[i].num == nomer)
                    {
                        bloknote.notzap.RemoveAt(i);
                    }
                }
            if (bloknote.notzap.Count == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Лист пуст!");
                Console.ResetColor();
            }


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
            Console.WriteLine(" \t|2. Удалить запись    |");
            Console.WriteLine(" \t|3. Сортировать список|");
            Console.WriteLine(" \t|4. Вывести список    |");
            Console.WriteLine(" \t|5. Найти запись      |");
            Console.WriteLine(" \t|6. Выход             |");
            Console.WriteLine(" \t|_____________________|");
            Console.Write("\n\tВыберите действие ");

                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1: addzap(); Console.ReadKey(); Console.Clear(); break;

                    case 2: DelZap(); Console.Clear(); break;

                    case 3: FamilSort(); Console.ReadKey(); Console.Clear(); break;

                    case 4: vivod(zap1); Console.ReadKey(); Console.Clear(); break;

                    case 5: poisk(); Console.ReadKey(); Console.Clear(); break;

                    case 6: Environment.Exit(0); break;
                }
                goto metka; 
        }
    }
}