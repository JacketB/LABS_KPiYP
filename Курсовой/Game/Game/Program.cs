using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(
                              "           ═───══────══────═#═────══────══───═ \n" +
                              "          |             WELCOME TO            |\n" +
                              "          |  -------------------------------  |\n" +
                              "          |  | ===== =     ===  =  = ===== |  |\n" +
                              "          |  |    =  =    =   = == =   =   |  |\n" +
                              "          #  |   =   =    =   = = ==   =   |  #\n" +
                              "          |  |  =    =    =   = =  =   =   |  |\n" +
                              "          |  | ===== ====  ===  =  =   =   |  |\n" +
                              "          |  -------------------------------  |\n" +
                              "          |                                   |\n" +
                              "           ═───══────══────═#═────══────══───═\n\n");
            Console.WriteLine("          1. Начать игру.\n" +
                              "          2. Выход. ");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1" : Console.WriteLine(" Начало "); break;
                case "2" : Environment.Exit(0); break;

            }
            Thread.Sleep(500);
            Console.WriteLine("Брызги от падающего водопада летели прямо в лицо." +
                              "Я был уже близко к цели. Слышится ее зов \n" +
                              "По мере приближения этот зов все усиливался\n" +
                              "за водопадом появился силуэт женщины.\n" +
                              "- Зачем ты здесь?"); 
            Console.WriteLine("          Город Злонт ХХ год.");

            Console.ReadKey(true);
        }
    }
}
