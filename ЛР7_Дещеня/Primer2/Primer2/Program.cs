using System;
using System.Text;

namespace Primer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Исходная строка:");
            string s = Console.ReadLine();
            int k = s.IndexOf('?');
            Console.WriteLine("k={0}", k);
            StringBuilder b1 = new


            StringBuilder(s.Substring(0, k));
            Console.WriteLine(b1);
            StringBuilder b2 = new
            StringBuilder(s.Substring(k));
            Console.WriteLine(b2);
            for (int i = 0; i < b1.Length; i++)
            {
                if (b1[i] == '!' || b1[i] == '.')
                {
                    b1.Remove(i, 1);
                    i--;
                }
            }
            b2.Replace(' ', '_');
            s = b1.ToString() + b2.ToString();
            Console.WriteLine("Результат:\n" + s);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
