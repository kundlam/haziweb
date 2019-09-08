using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazifeladat
{
    class Program
    {   
        static void Main(string[] args)
        {
            int a = 0;
            bool validUserInput = false;

            while (validUserInput == false)
            {
                try
                {
                    Console.Write("Add meg az A oldalt:  ");
                    a = int.Parse(Console.ReadLine());
                }
                catch (Exception) { } 

                if (a >= 1)
                {
                    validUserInput = true;
                }
                else
                {
                    Console.WriteLine("Nem számot írtál be");
                }
            }
            int b = 0;
            validUserInput = false;

            while (validUserInput == false)
            {
                try
                {
                    Console.Write("Add meg a B oldalt:  ");
                    b = int.Parse(Console.ReadLine());
                }
                catch (Exception) { }
                if (b >= 1)
                {
                    validUserInput = true;
                }
                else
                {
                    Console.WriteLine("Nem számot írtál be");
                }

            }
            double c = a * b;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines.txt"))
            file.WriteLine(c)
            Console.WriteLine("A két szám szorzata: " + a*b);

            Console.ReadKey();
        }
    }
}
