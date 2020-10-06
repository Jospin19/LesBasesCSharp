using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirageAuSort
{
    class Program
    {
        /// <summary>
        /// Fonction qui va vérifier si un nombre correspond à un autre
        /// </summary>
        /// <param name="args">int NbreOrdi</param>
        /// <param name="args">int NbreUser</param>
        static bool VerifierNbre(int NbreOrdi, int NbreUser)
        {
            bool Reponse = false;

            //Si NbreOrdi == NbreUser alors Reponse vaut true
            //Sinon Reponse vaut false
            if (NbreOrdi == NbreUser)
            {
                Reponse = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vous avez réussi!!!!!");
            }
            else
                ContinuerIHM(NbreOrdi, NbreUser);

            return Reponse;
        }

        /// <summary>
        /// Fonction qui va boucler tant que la reponse n'est pas correcte
        /// </summary>
        /// <param name="args">int NbreOrdi</param>
        /// <param name="args">int NbreUser</param>
        static void ContinuerIHM(int NbreOrdi, int NbreUser)
        {
            //Variable qui va récupérer le choix de l'utilisateur
            char choix = 'N';
            Console.ForegroundColor = ConsoleColor.Red;

            

            if ((NbreUser <1) || (NbreUser >6) || (int.TryParse(Console.ReadLine(), out NbreUser) == false))
                Console.WriteLine("Vous avez entrer un nombre invalide");
            else
                Console.WriteLine("Vous avez échoué!!!!!");

            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Voulez vous essayer à nouveau [\"O\" - \"N\"] ?  ");

                Console.ForegroundColor = ConsoleColor.Red;
            }while(!((char.TryParse(Console.ReadLine(), out choix)) && ((choix == 'N') || (choix == 'O'))));

            if (choix == 'O')
            {
                RecupereIHM(NbreOrdi);
            }
            else
                Console.ReadKey();
        }

        static void RecupereIHM(int NbreOrdi)
        {
            //On récupère le nombre de l'utilisateur
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Veuillez entrer un nombre [1- 6]");

            //On vérifie le format du nombre récupéré
            if ((int.TryParse(Console.ReadLine(), out int NbreUser)) && ((NbreUser >= 1) && (NbreUser <= 6)))
                VerifierNbre(NbreOrdi, NbreUser);
            else
                ContinuerIHM(NbreOrdi, NbreUser);

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            //On génère un nombre aléatoire
            Random Aleatoire = new Random();

            int NbreOrdi = Aleatoire.Next(1, 6);

            RecupereIHM(NbreOrdi);
        }
    }
}
