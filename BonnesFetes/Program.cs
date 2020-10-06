using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonnesFetes
{
    class Program
    {
        /// <summary>
        /// Fonction qui contiend tous le code d'écriture des caractères à l'écran
        /// </summary>
        static void MessageBonneFetes()
        {
            /**
             * On défini le caractère d'affichage à l'écran
             * */
            char Caractere = (char) 165;

            
            

            //On initialise les variables
            //int i = 0, j = 0;

            /**
             * Ecriture de BONNES
             * */

            //Ecriture du B de "Bonnes"
            //Trait oblique de la base montant /
            for(int i = 0, j = 0; (i < 8) && (j < 8); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(4 + i, 18 - j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(3 + i, 18 - j);
                Console.WriteLine(Caractere);
            }

            //Trait oblique de la base descendant \
            for (int i = 0, j = 0; (i < 8) && (j < 8); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(4 + i, 18 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(3 + i, 18 + j);
                Console.WriteLine(Caractere);
            }
            //Trait \

            for (int i = 0, j = 0; (i < 16) && (j < 5); i+=2, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(12 + i, 10 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(11 + i, 10 + j);
                Console.WriteLine(Caractere);
            }

            //Trait /
            for (int i = 0, j = 0; (i < 16) && (j < 5); i += 2, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(20 - i, 14 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(19 - i, 14 + j);
                Console.WriteLine(Caractere);
            }

            //Trait \
            for (int i = 0, j = 0; (i < 16) && (j < 5); i += 2, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(12 + i, 18 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(11 + i, 18 + j);
                Console.WriteLine(Caractere);
            }

            //Trait /
            for (int i = 0, j = 0; (i < 16) && (j < 5); i += 2, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(20 - i, 22 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(19 - i, 22 + j);
                Console.WriteLine(Caractere);
            }


            /**
             * Ecriture du O de BONNES
             * */

            //Trait /
            for (int i = 0, j = 0; (i < 7) && (j < 7); i ++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27 - i, 14 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(26 - i, 14 + j);
                Console.WriteLine(Caractere);
            }

            //Trait \
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(21 + i, 20 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(20 + i, 20 + j);
                Console.WriteLine(Caractere);
            }

            //Trait /
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27 + i, 26 - j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(26 + i, 26 - j);
                Console.WriteLine(Caractere);
            }

            //Trait \
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(33 - i, 20 - j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(32 - i, 20 - j);
                Console.WriteLine(Caractere);
            }


            /**
             * Ecriture du N de BONNES
             * */

            //Trait /
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(42 - i, 14 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(41 - i, 14 + j);
                Console.WriteLine(Caractere);
            }

            //Trait \
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(36 + i, 20 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(35 + i, 20 + j);
                Console.WriteLine(Caractere);
            }

            //Trait \
            int cpt = 0;
            for (int i = 0, j = 0; (i < 13) && (j < 13); i += (cpt == 2) ? 1 : 0, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(42 + i, 14 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(41 + i, 14 + j);
                Console.WriteLine(Caractere);
                if (cpt == 2)
                    cpt = 0;
                else
                    cpt++;
            }

            //Trait /
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(46 + i, 26 - j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(45 + i, 26 - j);
                Console.WriteLine(Caractere);
            }

            //Trait /
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(52 - i, 20 - j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(51 - i, 20 - j);
                Console.WriteLine(Caractere);
            }


            /**
             * Ecriture du deuxième N de BONNES
             * */

            //Trait /
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(61 - i, 14 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(60 - i, 14 + j);
                Console.WriteLine(Caractere);
            }

            //Trait \
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(55 + i, 20 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(54 + i, 20 + j);
                Console.WriteLine(Caractere);
            }

            //Trait \
            int cpt2 = 0;
            for (int i = 0, j = 0; (i < 13) && (j < 13); i += (cpt2 == 2) ? 1 : 0, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(61 + i, 14 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(60 + i, 14 + j);
                Console.WriteLine(Caractere);
                if (cpt2 == 2)
                    cpt2 = 0;
                else
                    cpt2++;
            }

            //Trait /
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(65 + i, 26 - j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(64 + i, 26 - j);
                Console.WriteLine(Caractere);
            }

            //Trait /
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(71 - i, 20 - j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(70 - i, 20 - j);
                Console.WriteLine(Caractere);
            }


            /**
             * Ecriture du E de BONNES
             * */

            //Trait /
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(80 - i, 14 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(79 - i, 14 + j);
                Console.WriteLine(Caractere);
            }

            //Trait \
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(74 + i, 20 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(73 + i, 20 + j);
                Console.WriteLine(Caractere);
            }
            //Trait -
            for (int i = 0, j = 0; (i < 6) && (j < 6); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(73 + i, 20);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(73 + i, 21);
                Console.WriteLine(Caractere);
            }

            /**
             * Ecriture du S de BONNES
             * */

            //Chapeau supérieur |
            for (int i = 0, j = 0; (i < 4) && (j < 4); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(89, 14 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(88, 14 + j);
                Console.WriteLine(Caractere);
            }

            //Trait /
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(89 - i, 14 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(88 - i, 14 + j);
                Console.WriteLine(Caractere);
            }

            //Trait -
            for (int i = 0, j = 0; (i < 6) && (j < 6); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(82 + i, 20);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(82 + i, 21);
                Console.WriteLine(Caractere);
            }
            

            //Trait /
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(89 - i, 20 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(88 - i, 20 + j);
                Console.WriteLine(Caractere);
            }

            //Chapeau inférieur |
            for (int i = 0, j = 0; (i < 4) && (j < 4); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(83, 26 - j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(82, 26 - j);
                Console.WriteLine(Caractere);
            }


            /**
             * Ecriture du F de FETES
             * */

            //Trait - supérieur
            for (int i = 0, j = 0; (i < 8) && (j < 8); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(97 + i, 11);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(97 + i, 10);
                Console.WriteLine(Caractere);
            }

            //Trait |
            for (int i = 0, j = 0; (i < 8) && (j < 8); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(98, 11 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(97, 11 + j);
                Console.WriteLine(Caractere);
            }

            //Trait \
            for (int i = 0, j = 0; (i < 8) && (j < 8); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(98 + i, 19 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(97 + i, 19 + j);
                Console.WriteLine(Caractere);
            }
            //Trait - inférieur
            for (int i = 0, j = 0; (i < 8) && (j < 8); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(97 + i, 19);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(97 + i, 18);
                Console.WriteLine(Caractere);
            }

            /**
             * Ecriture du E de FETES
             * */

            //Trait /
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(113 - i, 14 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(112 - i, 14 + j);
                Console.WriteLine(Caractere);
            }

            //Trait \
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(107 + i, 20 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(106 + i, 20 + j);
                Console.WriteLine(Caractere);
            }
            //Trait -
            for (int i = 0, j = 0; (i < 6) && (j < 6); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(106 + i, 20);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(106 + i, 21);
                Console.WriteLine(Caractere);
            }


            /**
             * Ecriture du T de FETES
             * */

            //Trait /
            for (int i = 0, j = 0; (i < 10) && (j < 4); i+=2, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(120 - i, 14 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(119 - i, 14 + j);
                Console.WriteLine(Caractere);
            }

            //Trait |
            for (int i = 0, j = 0; (i < 13) && (j < 13); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(120, 14 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(119, 14 + j);
                Console.WriteLine(Caractere);
            }

            //Trait \
            for (int i = 0, j = 0; (i < 10) && (j < 4); i+=2, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(120 + i, 14 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(119 + i, 14 + j);
                Console.WriteLine(Caractere);
            }

            /**
             * Ecriture du E de FETES
             * */

            //Trait /
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(133 - i, 14 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(132 - i, 14 + j);
                Console.WriteLine(Caractere);
            }

            //Trait \
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(127 + i, 20 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(126 + i, 20 + j);
                Console.WriteLine(Caractere);
            }
            //Trait -
            for (int i = 0, j = 0; (i < 6) && (j < 6); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(126 + i, 20);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(126 + i, 21);
                Console.WriteLine(Caractere);
            }

            /**
             * Ecriture du S de FETES
             * */

            //Chapeau supérieur |
            for (int i = 0, j = 0; (i < 4) && (j < 4); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(143, 14 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(142, 14 + j);
                Console.WriteLine(Caractere);
            }

            //Trait /
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(143 - i, 14 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(142 - i, 14 + j);
                Console.WriteLine(Caractere);
            }

            //Trait -
            for (int i = 0, j = 0; (i < 6) && (j < 6); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(136 + i, 20);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(136 + i, 21);
                Console.WriteLine(Caractere);
            }


            //Trait /
            for (int i = 0, j = 0; (i < 7) && (j < 7); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(142 - i, 20 + j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(141 - i, 20 + j);
                Console.WriteLine(Caractere);
            }

            //Chapeau inférieur |
            for (int i = 0, j = 0; (i < 4) && (j < 4); i++, j++)
            {
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(136, 26 - j);
                Console.WriteLine(Caractere);
                //On défini la couleur d'affichage du message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(135, 26 - j);
                Console.WriteLine(Caractere);
            }





        }






        static void Main(string[] args)
        {
            MessageBonneFetes();

            Console.ReadKey();
            
        }
    }
}
