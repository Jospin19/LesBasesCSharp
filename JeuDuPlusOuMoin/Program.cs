using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDuPlusOuMoin
{
    class Program
    {
        /// <summary>
        /// Fonction qui va tracer l'interface graphique
        /// </summary>
        /// <param name="args"></param>
        static void TracerCadre()
        {
            //On affecte a une valriable entière la valeur du caracrtère ASCII a obtenir
            char Caractere = (char)177;

            //On utilise le caractère en question pour tracer différentes formes sur l'écran
            Console.ForegroundColor = ConsoleColor.DarkGray;
            //On trace le carré du coin supérieur gauche
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.SetCursorPosition(8 + i, 0 + j);
                    Console.WriteLine(Caractere.ToString());
                }
            }

            //On trace le carré du coin supérieur droit
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.SetCursorPosition(146 + i, 0 + j);
                    Console.WriteLine(Caractere.ToString());
                }
            }

            //On trace le carré du coin inférieur gauche
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.SetCursorPosition(8 + i, 39 + j);
                    Console.WriteLine(Caractere.ToString());
                }
            }


            //On trace le carré du coin inférieur droit
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.SetCursorPosition(146 + i, 39 + j);
                    Console.WriteLine(Caractere.ToString());
                }
            }




            
            //On trace la ligne supérieur
            for(int i = 0; i < 140; i++)
            {
                Console.SetCursorPosition(12 + i, 2);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(12 + i, 3);
                Console.WriteLine(Caractere.ToString());
            }


            //On trace la ligne verticale gauche
            for(int i = 0; i < 40; i++)
            {
                Console.SetCursorPosition(12, 2 + i);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(13, 2 + i);
                Console.WriteLine(Caractere.ToString());
            }

            //On trace la ligne horizontale inférieure
            for(int i = 0; i < 140; i++)
            {
                Console.SetCursorPosition(12 + i, 41);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(12 + i, 42);
                Console.WriteLine(Caractere.ToString());
            }

            //On trace la ligne verticale droite
            for(int i = 0; i < 40; i++)
            {
                Console.SetCursorPosition(150, 42 - i);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(151, 42 - i);
                Console.WriteLine(Caractere.ToString());
            }


            /**
             * On écrit le texte qui sera visible sur l'écran
             * */
            Console.ForegroundColor = ConsoleColor.Green;

            /**
             * On écrit le J
             * */
             //La barre horizontale supérieur
            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(28 + i, 6);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(28 + i, 7);
                Console.WriteLine(Caractere.ToString());
            }
            //La barre verticale
            for(int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(33, 6 + i);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(34, 6 + i);
                Console.WriteLine(Caractere.ToString());
            }
            //La barre horizontale inférieure
            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(33 - i, 12);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(33 - i, 13);
                Console.WriteLine(Caractere.ToString());
            }

            /**
             * On écrit le E
             * */
            //La barre horizontale supérieur
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(42 + i, 6);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(42 + i, 7);
                Console.WriteLine(Caractere.ToString());
            }
            //La barre verticale
            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(42, 6 + i);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(43, 6 + i);
                Console.WriteLine(Caractere.ToString());
            }
            //La barre horizontale du milieu
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(42 + i, 9);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(42 + i, 10);
                Console.WriteLine(Caractere.ToString());
            }
            //La barre horizontale inférieure
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(42 + i, 12);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(42 + i, 13);
                Console.WriteLine(Caractere.ToString());
            }

            /**
             * On écrit le U
             * */
            //La barre verticale
            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(54, 6 + i);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(55, 6 + i);
                Console.WriteLine(Caractere.ToString());
            }
            //La barre horizontale inférieure
            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(54 + i, 12);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(54 + i, 13);
                Console.WriteLine(Caractere.ToString());
            }
            //La barre verticale
            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(65, 13 - i);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(66, 13 - i);
                Console.WriteLine(Caractere.ToString());
            }

            /**
             * On écrit le D
             * */
            //La barre verticale
            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(73, 6 + i);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(74, 6 + i);
                Console.WriteLine(Caractere.ToString());
            }
            //La barre oblique supérieure
            for (int i = 0, j = 2; (i < j) && (j < 9); i++, j += 3)
            {
                Console.SetCursorPosition(74 + j, 6 + i);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(75 + j, 6 + i);
                Console.WriteLine(Caractere.ToString());
            }
            //La barre oblique inférieure
            for (int i = 0, j = 2; (i < j) && (j < 9); i++, j += 3)
            {
                Console.SetCursorPosition(74 + j, 13 - i);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(75 + j, 13 - i);
                Console.WriteLine(Caractere.ToString());
            }
            //La barre verticale
            for (int i = 0; i < 2; i++)
            {
                Console.SetCursorPosition(83, 9 + i);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(84, 9 + i);
                Console.WriteLine(Caractere.ToString());
            }

            /**
             * On écrit le U
             * */
            //La barre verticale
            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(87, 6 + i);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(88, 6 + i);
                Console.WriteLine(Caractere.ToString());
            }
            //La barre horizontale inférieure
            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(87 + i, 12);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(88 + i, 13);
                Console.WriteLine(Caractere.ToString());
            }
            //La barre verticale
            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(98, 13 - i);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(99, 13 - i);
                Console.WriteLine(Caractere.ToString());
            }

            /**
             * On écrit le signe +
             * */
            //La barre verticale
            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(110, 6 + i);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(111, 6 + i);
                Console.WriteLine(Caractere.ToString());
            }
            //La barre horizontale du milieu
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(106 + i, 9);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(106 + i, 10);
                Console.WriteLine(Caractere.ToString());
            }

            /**
             * On écrit la barre \
             * */
            //La barre verticale
            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(117 + i, 6 + i);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(118 + i, 6 + i);
                Console.WriteLine(Caractere.ToString());
            }

            /**
             * On écrit le signe -
             * */
            //La barre horizontale du milieu
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(128 + i, 9);
                Console.WriteLine(Caractere.ToString());

                Console.SetCursorPosition(128 + i, 10);
                Console.WriteLine(Caractere.ToString());
            }

            /**
             * On défini nos règles du jeu du plus ou moins
             * */
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(42, 15);
            Console.WriteLine("Règles");

            for(int i = 0; i < 6; i++)
            {
                Console.SetCursorPosition(42 + i, 16);
                Console.Write("*");
            }

            Console.SetCursorPosition(50, 15);
            Console.WriteLine("1) L\'ordinateur choisi un nombre entre [1 - 18] ");
            Console.SetCursorPosition(50, 16);
            Console.WriteLine("2) Vous avez droit a 7 réponse incorrecte");
            Console.SetCursorPosition(50, 17);
            Console.WriteLine("3) A chaque mauvaises réponses l\'ordinateur vous met sur la piste de la bone");
            Console.SetCursorPosition(50, 18);
            Console.WriteLine("   Réponse en vous indiquant si le nombre est plus ou oins que celui que vous avez donné");
        }


        /// <summary>
        /// Fonction principale qui inter agit avec l'utilisateur
        /// </summary>
        /// <param name="args">int nbreAleatoire</param>
        static void  IHM(int nbreAleatoire)
        {
            bool trouve = false;
            int nbreEssai = 1, ligne = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(20, 20 + (++ligne));
                Console.Write("Veuillez entrer un nombre : ");

                //On récupère le nombre
                bool conversion = int.TryParse(Console.ReadLine(), out int nbreUser);
                if ((conversion) && (nbreUser == nbreAleatoire))
                {
                    Console.SetCursorPosition(20, 20 + (++ligne));
                    Console.WriteLine("Vous avez gagné!!!! :-)");
                    trouve = true;

                    Console.ReadKey();
                    Console.Clear();
                    TracerCadre();

                    Random Aleatoire = new Random();
                    int NewNbreAleatoire = Aleatoire.Next(1, 18);
                    IHM(NewNbreAleatoire);
                }
                else
                {
                    if ((!conversion) || (nbreUser > 18))
                    {
                        Console.SetCursorPosition(22, 20 + (++ligne));
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Le nombre entré est invalide :-(");
                    }
                    else if (nbreUser > nbreAleatoire)
                    {
                        Console.SetCursorPosition(22, 20 + (++ligne));
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Le nombre est inférieur!!");
                    }
                    else if (nbreUser < nbreAleatoire)
                    {
                        Console.SetCursorPosition(22, 20 + (++ligne));
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Le nombre est supérieur!!");
                    }

                }
                nbreEssai++;
            } while (nbreEssai <= 8);

            if (nbreEssai >= 8)
            {
                Console.SetCursorPosition(20, 20 + (++ligne));
                Console.WriteLine("Vous avez perdu!!!! :-(");

                Console.ReadKey();
                Console.Clear();
                TracerCadre();

                Random Aleatoire = new Random();
                int NewNbreAleatoire = Aleatoire.Next(1, 18);
                IHM(NewNbreAleatoire);
            }

        }


        static void Main(string[] args)
        {
            //Déclaration de la variable qui va recevoir le nombre aléatoire
            Random Aleatoire = new Random();
            int nbreAleatoire = Aleatoire.Next(1, 18);


            TracerCadre();

            IHM(nbreAleatoire);
            Console.ReadKey();
        }
    }
}
