using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ozero1
{

    public class Program 
    
    {
        public static void Main()
        {   
			Console.Write("  _____\n"+
				          " |озеро|\n\n"+
						  " #    #   _||___\n"+
			              "###  ### |= _ ==|\n"+
			              " |    |  |_|-|__|  \n");
			Console.Write("\n\t ");
			Console.BackgroundColor = ConsoleColor.Cyan;
			Console.Write("\t       \n"+"\t\t         \n");
			Console.ResetColor();
			Console.Write("\t ");
			Console.BackgroundColor = ConsoleColor.Cyan;
			Console.Write("\t       \n");
        }
    }
}