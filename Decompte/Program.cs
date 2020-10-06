using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decompte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer un nombre");

            if(int.TryParse(Console.ReadLine(), out int Nbre))
            {
                while (Nbre >= 0)
                {
                    Console.WriteLine(Nbre);
                    Nbre--;
                }     
            }
            else
            {
                Console.WriteLine("Votre nombre n'est pas correct");
            }
            Console.ReadKey();
        }
    }
}
