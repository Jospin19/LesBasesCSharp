using System;

namespace Revisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Caractère qu'on affichera à l'écran
            char car = (char)177;

            //On défini la couleur d'affichage
            Console.ForegroundColor = ConsoleColor.Gray;

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.SetCursorPosition(10 + j, 10 + i);
                    Console.Write(car.ToString());
                }
            }
        }
    }
}
