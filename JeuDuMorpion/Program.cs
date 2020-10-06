using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDuMorpion
{

    class Program
    {
        /**
         * Création du type Position
         **/
        public struct Position
        {
            public int Ligne;
            public int Colonne;

            //Constructeur par défaut
            public Position(int i, int j)
            {
                Ligne = i;
                Colonne = j;
            }
        }


        /**
         * Fonction qui va retourner les indices d'une valeur dans un tableau multidimentionnel/
         **/
        static Position GetIndice(string[,] Tableau, string valeur)
        {
            Position Coordonne = new Position();

            //On parcourt le tableau pour récupérer l'indice correspondant à la valeur passée en paramète
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Tableau[i, j] == valeur)
                    {
                        Coordonne.Ligne = i;
                        Coordonne.Colonne = j;
                    }
                }
            }

            //On retourne les coordonnées
            return Coordonne;
        }


        /// <summary>
        /// Fonction qui va tracer le cadre du jeu 
        /// </summary>
        /// <param name="args"></param>
        static void TracerCadre()
        {
            //On affecte a une variable caractère la vealuer ASCII un caractère a affcher
            char caractère = (char)177;

            //On défini la couleur du caractère a afficher
            Console.ForegroundColor = ConsoleColor.DarkGray;

            /**
             * On trace le cadre du jeu
             * */
            // Sur la verticale
            for (int i = 0; i < 20; i += 5)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.SetCursorPosition(45 + j, 5 + i);
                    Console.WriteLine(caractère.ToString());
                }
            }
            //Sur l'horizontale
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 40; j += 10)
                {
                    Console.SetCursorPosition(45 + j, 5 + i);
                    Console.WriteLine(caractère.ToString());
                }
            }

            //Message qui indique les règles du jeu
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Règles :");
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("1---> Choisissez un nombre entre [1 - 8] et valider");
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("2---> Votre réponse est validé sur le morpion par le signe X et l'ordinateur par le signe C");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("3---> Vous devez aligner trois cases consécutives marquées de votre signe pour gagner");

            //Les caractère qui seront affcihés par la suite le seront en DarkGray
            Console.ForegroundColor = ConsoleColor.DarkGray;

        }


        /// <summary>
        /// Fonction de gestion du Morpion
        /// </summary>
        static void InitializeMoprion(string[,] TableauMorpionCopie)
        {
            //Déclaration de la variable de nombre entier aléatoire
            Random Aleatoire = new Random();

            int nbreAleatoire = 0;


            //Création du tableau de gestion du Morpion
            int[,] TableauMoprion = new int[3, 3];

            //Création de la liste de vérification
            List<int> VerifList = new List<int>();


            //Initialisation du tableau
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    do
                    {
                        nbreAleatoire = Aleatoire.Next(0, 9);
                    } while(VerifList.Contains(nbreAleatoire));

                    VerifList.Add(nbreAleatoire);

                    //J'affecte la valeur recupérée au tableau
                    TableauMoprion[i, j] = nbreAleatoire;
                }
            }

            /*
            //Clonage du tableau initialsé dans un autr tableau et transformation en chaine de caractère
            int[,] TableauMorpionCopie = (int[,])TableauMoprion.Clone();

            //On retourne le tableau transformé en chaine de caractère
            return TableauMorpionCopie.ToString();
            */

            //On va copier chaque élément du tableau généré en le transformant à chaque fois en string
            //Initialisation du tableau
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TableauMorpionCopie[i, j] = TableauMoprion[i, j].ToString();
                }
            }
            

        }


        /// <summary>
        /// Fonction qui va afficher le tavbealu de morpion
        /// </summary>
        /// <param name="TableauMorpion"></param>
        static void AfficheTableau(string[,] TableauMorpion)
        {
            int o = 0, p = 0;

            for (int i = 0; i < 15; i += 5)
            {
                for (int j = 0; j < 30; j += 10)
                {
                    Console.SetCursorPosition(50 + j, 8 + i);

                    //On passe à l'indice suivant du tableau (dans le sens des colonnes)
                    if (p >= 2)
                        p = 0;
                    else
                        p++;

                    Console.WriteLine(TableauMorpion[o, p]);
                }
                //On passe à l'indice suivant du tableau (dans le sens des lignes)
                o++;
            }

        }

        //Fonction va récuprérer la réponse de l'utilisateur
        static string GetAnswer(List<int> VerifList, bool tour)
        {
            string Reponse = "";
            int convertit = 0;
            if (tour)
            {
                do
                {
                    //On affiche le message de demamnde de choix de l'utilisateur
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.SetCursorPosition(30, 25);
                    Console.WriteLine("Veuillez sélectionner le chiffre correspondant à une case :  ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(90, 25);
                    Reponse = Console.ReadLine();

                    
                    int.TryParse(Reponse, out convertit);

                } while ((!((Reponse.Equals("0")) || (Reponse.Equals("1")) || (Reponse.Equals("2")) || (Reponse.Equals("3")) || (Reponse.Equals("4")) || (Reponse.Equals("5")) || (Reponse.Equals("6")) || (Reponse.Equals("7")) || (Reponse.Equals("8")))) || (VerifList.Contains(convertit)));
                VerifList.Add(convertit);
            }
            else
            {
                //Déclaration de la variable de nombre entier aléatoire
                Random Aleatoire = new Random();

                int nbreAleatoire = 0;

                //Récupération d'un nouveau chiffre
                do
                {
                    nbreAleatoire = Aleatoire.Next(0, 9);
                } while (VerifList.Contains(nbreAleatoire));

                VerifList.Add(nbreAleatoire);
                
                Reponse = nbreAleatoire.ToString();
            }

            return Reponse;
        }


        //Fonction qui va valider la réponse du joueur (ordi /user)
        //Focntion qui va écrire X quand un utilisateur choisi une case
        static string[,] ValidateAnswer(string[,] TableauMorpion, string valeur, ref bool tour)
        {
            if (tour)
            {
                Position Coordonnees = GetIndice(TableauMorpion, valeur);

                int Ligne = Coordonnees.Ligne;
                int Colonne = Coordonnees.Colonne;

                TableauMorpion[Ligne, Colonne] = "X";
                tour = false;
            }
            else
            {
                Position Coordonnees = GetIndice(TableauMorpion, valeur);

                int Ligne = Coordonnees.Ligne;
                int Colonne = Coordonnees.Colonne;

                TableauMorpion[Ligne, Colonne] = "C";
                tour = true;
            }

            return TableauMorpion;
        }

        //Fonction qui va vérifier si l'ordinateur ou la machine à gagner
        static bool Winner(string[,] TableauMorpion)
        {
            bool reponse = false;
            if(
                ((TableauMorpion[0,0] == "X") && (TableauMorpion[0,1] == "X") && (TableauMorpion[0,2] == "X")) || ((TableauMorpion[0, 0] == "X") && (TableauMorpion[1, 0] == "X") && (TableauMorpion[2, 0] == "X")) || ((TableauMorpion[0,0] == "X") && (TableauMorpion[0,1] == "X") && (TableauMorpion[0,2] == "X")) || ((TableauMorpion[0, 0] == "X") && (TableauMorpion[1, 1] == "X") && (TableauMorpion[2, 2] == "X")) ||
                ((TableauMorpion[0, 1] == "X") && (TableauMorpion[1, 1] == "X") && (TableauMorpion[2, 1] == "X")) || ((TableauMorpion[0, 2] == "X") && (TableauMorpion[1, 1] == "X") && (TableauMorpion[2, 0] == "X")) || ((TableauMorpion[1, 0] == "X") && (TableauMorpion[1, 1] == "X") && (TableauMorpion[1, 2] == "X")) || ((TableauMorpion[2, 0] == "X") && (TableauMorpion[1, 0] == "X") && (TableauMorpion[0, 0] == "X")) ||
                ((TableauMorpion[2, 0] == "X") && (TableauMorpion[2, 1] == "X") && (TableauMorpion[2, 2] == "X")) || ((TableauMorpion[2, 0] == "X") && (TableauMorpion[1, 1] == "X") && (TableauMorpion[0, 2] == "X")) || ((TableauMorpion[2, 1] == "X") && (TableauMorpion[1, 1] == "X") && (TableauMorpion[0, 1] == "X")) || ((TableauMorpion[2, 2] == "X") && (TableauMorpion[1, 2] == "X") && (TableauMorpion[0, 2] == "X")) || ((TableauMorpion[2, 2] == "X") && (TableauMorpion[1, 1] == "X") && (TableauMorpion[0, 0] == "X"))
                )
            {
                //On affiche le message de réussite
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(30, 25);
                Console.WriteLine("               Fellicitations. Vous avez gagné !!!!!!!               ");

                //Cela veut dire que nous avons l'utilisateur vainqueur
                reponse = true;
            }
            else if(
                ((TableauMorpion[0, 0] == "C") && (TableauMorpion[0, 1] == "C") && (TableauMorpion[0, 2] == "C")) || ((TableauMorpion[0, 0] == "C") && (TableauMorpion[1, 0] == "C") && (TableauMorpion[2, 0] == "C")) || ((TableauMorpion[0, 0] == "C") && (TableauMorpion[0, 1] == "C") && (TableauMorpion[0, 2] == "C")) || ((TableauMorpion[0, 0] == "C") && (TableauMorpion[1, 1] == "C") && (TableauMorpion[2, 2] == "C")) ||
                ((TableauMorpion[0, 1] == "C") && (TableauMorpion[1, 1] == "C") && (TableauMorpion[2, 1] == "C")) || ((TableauMorpion[0, 2] == "C") && (TableauMorpion[1, 1] == "C") && (TableauMorpion[2, 0] == "C")) || ((TableauMorpion[1, 0] == "C") && (TableauMorpion[1, 1] == "C") && (TableauMorpion[1, 2] == "C")) || ((TableauMorpion[2, 0] == "C") && (TableauMorpion[1, 0] == "C") && (TableauMorpion[0, 0] == "C")) ||
                ((TableauMorpion[2, 0] == "C") && (TableauMorpion[2, 1] == "C") && (TableauMorpion[2, 2] == "C")) || ((TableauMorpion[2, 0] == "C") && (TableauMorpion[1, 1] == "C") && (TableauMorpion[0, 2] == "C")) || ((TableauMorpion[2, 1] == "C") && (TableauMorpion[1, 1] == "C") && (TableauMorpion[0, 1] == "C")) || ((TableauMorpion[2, 2] == "C") && (TableauMorpion[1, 2] == "C") && (TableauMorpion[0, 2] == "C")) || ((TableauMorpion[2, 2] == "C") && (TableauMorpion[1, 1] == "C") && (TableauMorpion[0, 0] == "C"))
                )
            {
                //On affiche le message de réussite
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(30, 25);
                Console.WriteLine("               Désolé. Vous avez perdu !!!!!!!               ");

                //Cela veut dire que nous avons l'ordinateur vainqueur
                reponse = true;
            }
            //Les caractère qui seront affcihés par la suite le seront en DarkGray
            Console.ForegroundColor = ConsoleColor.DarkGray;

            return reponse;
        }


        //Fonction qui va afficher le Morpion à l'éccran
        static void GestionMorpion(string[,] TableauMorpion)
        {
            //Déclaration des variables globales du programme
            string Reponse = "";
            bool jouer = true;
            List<int> VerifList = new List<int>();
            do
            {
                //On efface d'abord l'écran
                Console.Clear();

                //On trace le cadre à l'écran
                TracerCadre();

                //On affiche les différentes valeurs du tableau
                AfficheTableau(TableauMorpion);

                //On attend le choix de l'utilisateur
                Reponse = GetAnswer(VerifList, jouer);

                //On valide la réponse du joueur
                TableauMorpion = ValidateAnswer(TableauMorpion, Reponse, ref jouer);
            } while (!Winner(TableauMorpion));

            //On affiche les différentes valeurs du tableau
            AfficheTableau(TableauMorpion);
        }



        static void Main(string[] args)
        {
            //Déclaration de la varibale tableau de gestion du morpion
            string[,] TableauMorpion = new string[3,3];

            //On copie le tableau initialisé dans notre variable tableau
            InitializeMoprion(TableauMorpion);

            GestionMorpion(TableauMorpion);

            Console.ReadKey();
        }
    }
}
