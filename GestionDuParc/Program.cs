using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace GestionDuParc
{
    
    class Program
    {
        /// <summary>
        /// Fonction qui facilite la saisie à l'écran
        /// </summary>
        /// <param name="caratereASaisir">Caratère à saisir</param>
        /// <param name="x">Coordonée horizontale</param>
        /// <param name="y">Coordonée vertical</param>
        /// <param name="couleur">Couleur du texte a afficher</param>
        static void saisieXY(dynamic caratereASaisir, int x, int y, ConsoleColor couleur = ConsoleColor.DarkGray)
        {
            //On défini la couleur du caractère
            Console.ForegroundColor = couleur;

            //On défini la position sur l'écran
            Console.SetCursorPosition(x, y);

            //On écrit le texte à saisir
            Console.WriteLine(caratereASaisir);
        }


        /// <summary>
        /// Fonction qui va récupérer les saisies utilisateurs
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="couleur"></param>
        /// <returns></returns>
        static string recupereSaisie(int x, int y, ConsoleColor couleur = ConsoleColor.Green)
        {
            //On défini la couleur du caractère
            Console.ForegroundColor = couleur;

            //On défini la position sur l'écran
            Console.SetCursorPosition(x, y);

            //On écrit le texte à saisir
            return Console.ReadLine();
        }


        /// <summary>
        /// Fonction qui va tracer le cadre principal de l'application
        /// </summary>
        static void TracerCadre()
        {
            //On efface d'abord l'écran
            Console.Clear();

            //On séléction le caractère a afficher
            char caractre = (char) 35;


            /**
             * On trace le cadre de l'application
             * */

            //Trait horizontal supérieur
            for (int i = 0; i < 110; i++)
                saisieXY((char) 35, 4 + i, 1);

            //Trait vertival gauche
            for (int i = 0; i < 27; i++)
                saisieXY((char) 35, 4, 1 + i);

            //Trait horizontal inférieur
            for (int i = 0; i < 110; i++)
                saisieXY((char)35, 4 + i, 28);

            //Trait vertival droit
            for (int i = 0; i < 28; i++)
                saisieXY((char)35, 114, 28 - i);

            //On affiche le nom de l'application
            saisieXY("APPLICATION DE GESTION DES VEHICULES", 40, 4, ConsoleColor.Blue);

            //On défini la couleur par défaut du reste de l'application
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }


        /// <summary>
        /// Fonction qui va tracer le cadre principal de l'application
        /// </summary>
        static void TracerCadreDynamique(int nombreElement)
        {
            //On efface d'abord l'écran
            Console.Clear();

            //On séléction le caractère a afficher
            char caractre = (char)35;

            /**
             * On trace le cadre de l'application
             * */

            //Trait horizontal supérieur
            for (int i = 0; i < 110; i++)
                saisieXY((char)35, 4 + i, 1);

            //Trait vertival gauche
            for (int i = 0; i < 27 + (nombreElement * 9); i++)
                saisieXY((char)35, 4, 1 + i);

            //Trait horizontal inférieur
            for (int i = 0; i < 110; i++)
                saisieXY((char)35, 4 + i, 28 + (nombreElement * 9));

            //Trait vertival droit
            for (int i = 0; i < 28 + (nombreElement * 9); i++)
                saisieXY((char)35, 114, 28 + (nombreElement * 9) - i);
            //Pour qu'il commence effectivement vers le bas pour tracer la ligne verticale
            //Nous avons ajouté la variable de tracage ( + (nombreElement * 9) que nous décrémentons progressivement

            //On affiche le nom de l'application
            saisieXY("APPLICATION DE GESTION DES VEHICULES", 40, 4, ConsoleColor.Blue);

            //On défini la couleur par défaut du reste de l'application
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        
        /// <summary>
        /// Fonction qui affiche la barre de progression des opération
        /// </summary>
        /// <param name="messageDeProgression"> Message qui s'affiche lors de la progresion d'une opération </param>
        static void barreDeChargement(string messageDeProgression)
        {
            // Code pour pouvoir utiliser les caractères Unicode Site : https://unicode-table.com/en/
            Console.OutputEncoding = Encoding.Unicode;

            char caract1 = '┏';
            saisieXY(caract1, 33, 20, ConsoleColor.Gray); //Caractere du coin sup�rier gauche

            char caract2 = '━';
            for (int i = 0; i <= 49; i++)
                saisieXY(caract2, 34 + i, 20, ConsoleColor.Gray); // Ligne horizontale supérieure

            char caract3 = '┓';
            //Console.WriteLine(caract3); //Coin sup�rieur droit
            saisieXY(caract3, 84, 20, ConsoleColor.Gray);

            char caract4 = '┃';
            for (int i = 0; i <= 0; i++)
                saisieXY(caract4, 84, 21 + i, ConsoleColor.Gray); //Ligne verticale gauche

            char caract6 = '┛';
            saisieXY(caract6, 84, 22, ConsoleColor.Gray); //Coin inf�rieur droit

            for (int i = 0; i <= 50; i++)
                saisieXY(caract2, 83 - i, 22, ConsoleColor.Gray); //Ligne horizontale inf�rieure

            char caract5 = '┗';
            saisieXY(caract5, 33, 22, ConsoleColor.Gray); //Coin inf�rieur gauche

            for (int i = 0; i <= 0; i++)
                saisieXY(caract4, 33, 21 + i, ConsoleColor.Gray); //Ligne verticale droite


            // On affiche le message de progression de l'opération
            saisieXY(messageDeProgression, 48, 24, ConsoleColor.Green);

            // for (int i = 0; i >= 0; i--)
            // saisieXY(caract4, 134, 21 - i, ConsoleColor.Gray);

            char progressionCar = '▒';
            for (int i = 0; i < 50; i++)
            {
                saisieXY(progressionCar, 34 + i, 21, ConsoleColor.Green);

                if ((i * 2) == 98)
                    saisieXY(50 * 2, 86, 21, ConsoleColor.Green);
                else
                    saisieXY(i * 2, 86, 21, ConsoleColor.Green);

                saisieXY("%", 89, 21, ConsoleColor.Green);

                System.Threading.Thread.Sleep(50);
            }
        }


        /// <summary>
        /// Fonction qui efface et initialise l'écran
        /// </summary>
        static void InitialiseEcran()
        {
            Console.Clear();
            TracerCadre();
        }


        /// <summary>
        /// Fonction qui efface et initialise l'écran dans le sous menu de Consultation des véhicules
        /// </summary>
        /// <param name="nombreElement"></param>
        static void InitialiseEcranConsultation(int nombreElement)
        {
            Console.Clear();
            TracerCadreDynamique(nombreElement);
        }

        /// <summary>
        /// On déclarre la fonction qui va gérer le menu principal
        /// </summary>
        /// <param name="listeDesVehicules">Paramètre ayant une portée globale et qui contiendra l'ensemble des véhicules</param>
        static void AfficheMenuPrincipal(List<Voiture> listeDesVoiture, List<Utilitaire> listeDesUtilitaire)
        {
            //On initialise d'abord l'écran
            TracerCadre();

            //Menu qui va permettre d'ajouter des véhicules
            saisieXY("1------> Ajouter un véhicule", 20, 9);

            //Menu qui va permettre de supprimer un véhicule
            saisieXY("2------> Supprimer un véhicule", 20, 12);

            //Menu qui va permettre de consulter la liste des véhicules enregistrés
            saisieXY("3------> Consulter les véhicules", 20, 15);

            //Menu qui va permettre de sauvegarder des véhicules dans un fichier
            saisieXY("4------> Sauvegarder dans un fichier", 20, 18);

            //Menu qui va permettre de restaurer les véhicules savegardés dans les fichier
            saisieXY("5------> Restaurer à partir d un fichier", 20, 21);

            saisieXY("Veuillez effectuer votre choix :  ", 40, 25);

            //On appel la fonction qui récupère le choix de l'utilisateur au menu principal
            DirigeSousMenu(RecupereChoixPrincipal(), ref listeDesVoiture, ref listeDesUtilitaire);
        }


        /// <summary>
        /// Fonction qui va récupérer le choix de l'utilisateur
        /// </summary>
        /// <returns> On retourne un entier représentant le choix de l'utilisateur au niveau du menu principal </returns>
        static int RecupereChoixPrincipal()
        {
            int Reponse;
            Console.ForegroundColor = ConsoleColor.Green;

            //on veut une réponse comprise entre 1-5
            do
            {
                Console.SetCursorPosition(74, 25);
                int.TryParse(Console.ReadLine(), out Reponse);
            } while ((Reponse != 1) && (Reponse != 2) && (Reponse != 3) && (Reponse != 4) && (Reponse != 5));

            return Reponse;
        }


        /// <summary>
        /// Fonction qui va récupérer le choix de l'utilisateur
        /// </summary>
        /// <returns> On retourne un entier représentant le choix de l'utilisateur au niveau des sous menu </returns>
        //
        static int RecupereChoixSousMenu()
        {
            int Reponse;
            Console.ForegroundColor = ConsoleColor.Green;

            //on veut une réponse comprise entre 1-5
            do
            {
                Console.SetCursorPosition(74, 25);
                int.TryParse(Console.ReadLine(), out Reponse);
            } while ((Reponse != 1) && (Reponse != 2) && (Reponse != 3));

            return Reponse;
        }


        /// <summary>
        /// Fonction qui va gérer le menu d'ajout des véhicules
        /// </summary>
        /// <param name="listeDesVehicules"> Paramètre ayant une portée globale et qui contiendra l'ensemble des véhicules </param>
        static void GestionMenuAjouter(List<Voiture> listeDesVoiture, List<Utilitaire> listeDesUtilitaire)
        {
            //Fonction qui va ajouter une voiture
            void AjouterVoiture(ref List<Voiture> _listeDesVoiture)
            {
                //On défini un véhicule qui va nous servir de base
                Voiture nouvelleVoiture;

                bool continuer = false;

                string reponseCont = "";

                int porte = 4;

                //On boucle pour récupérer les informations d"une voiture
                do
                {
                    //On alloue un nouvel emplacement en mémoire pour la nouvelle voiture
                    nouvelleVoiture = new Voiture();
                    
                    //On initialise l'écran
                    InitialiseEcran();
                    
                    //On affiche un message indiquant que nous somme entrain d'ajouter une voiture
                    saisieXY("AJOUTER UNE VOITURE : ", 10, 12);

                    //On récupère l'immatriculation du véhicule
                    saisieXY("Immatriculation :  ", 20, 15, ConsoleColor.Gray);
                    nouvelleVoiture.ImmatriculationVeh = recupereSaisie(39, 15);

                    //On récupère la marque du véhicule
                    saisieXY("Marque : ", 50, 15, ConsoleColor.Gray);
                    nouvelleVoiture.MarqueVeh = recupereSaisie(60, 15);

                    //On récupère la couleur du véhicule
                    saisieXY("Couleur : ", 70, 15, ConsoleColor.Gray);
                    nouvelleVoiture.CouleurVeh = recupereSaisie(80, 15);

                    //On récupère le nombre de porte de la voiture
                    saisieXY("Nombre de porte : ", 20, 17, ConsoleColor.Gray);
                    int.TryParse(recupereSaisie(38, 17), out porte);
                    nouvelleVoiture.NombrePorte = porte;

                    //On boucle en attendant le choix de l'utilisateur
                    do
                    {
                        saisieXY("Voulez-vous continuer ? [O / N] :  ", 40, 25, ConsoleColor.Gray);
                        reponseCont = recupereSaisie(75, 25);
                    }while((reponseCont != "O") && (reponseCont != "o") && (reponseCont != "N") && (reponseCont != "n"));

                    if ((reponseCont.Equals("O")) || (reponseCont.Equals("o")))
                        continuer = true;
                    if ((reponseCont.Equals("N")) || (reponseCont.Equals("n")))
                        continuer = false;

                    //On ajoute la vouture comme nouveau véhicule
                    _listeDesVoiture.Add(nouvelleVoiture);

                } while (continuer == true);
                
                //On retourne au sous menu ajouter un véhicule
                GestionMenuAjouter(listeDesVoiture, listeDesUtilitaire);
            }

            //Fonction qui va ajouter un utilitaire
            void AjouterUtilitaire(ref List<Utilitaire> _listeDesUtilitaire)
            {
                //On défini un utilitaire qui va nous servir de base
                Utilitaire nouveauUtilitaire;

                bool continuer = false;

                string reponseCont = "";

                int voulumeUtile = 30;

                //On boucle pour récupérer les informations d"une voiture
                do
                {
                    //On allou un nouvel emplacement en mémoire pour le nouvel utilitaire
                    nouveauUtilitaire = new Utilitaire();

                    //On initialise l'écran
                    InitialiseEcran();
                    
                    //On affiche un message indiquant que nous somme entrain d'ajouter une voiture
                    saisieXY("AJOUTER UN UTILITAIRE : ", 10, 12, ConsoleColor.Gray);

                    //On récupère l'immatriculation du véhicule
                    saisieXY("Immatriculation :  ", 20, 15, ConsoleColor.Gray);
                    nouveauUtilitaire.ImmatriculationVeh = recupereSaisie(39, 15);

                    //On récupère la marque du véhicule
                    saisieXY("Marque : ", 50, 15, ConsoleColor.Gray);
                    nouveauUtilitaire.MarqueVeh = recupereSaisie(60, 15);

                    //On récupère la couleur du véhicule
                    saisieXY("Couleur : ", 70, 15, ConsoleColor.Gray);
                    nouveauUtilitaire.CouleurVeh = recupereSaisie(80, 15);

                    //On récupère le volume utile
                    saisieXY("Volume utile : ", 20, 17, ConsoleColor.Gray);
                    int.TryParse(recupereSaisie(35, 17), out voulumeUtile);
                    nouveauUtilitaire.VolumeUtile = voulumeUtile;

                    //On boucle en attendant le choix de l'utilisateur
                    do
                    {
                        saisieXY("Voulez-vous continuer ? [O / N] :  ", 40, 25, ConsoleColor.Gray);
                        reponseCont = recupereSaisie(75, 25);
                    } while ((reponseCont != "O") && (reponseCont != "o") && (reponseCont != "N") && (reponseCont != "n"));

                    if ((reponseCont.Equals("O")) || (reponseCont.Equals("o")))
                        continuer = true;
                    if ((reponseCont.Equals("N")) || (reponseCont.Equals("n")))
                        continuer = false;

                    //On ajoute la vouture comme nouveau véhicule
                    _listeDesUtilitaire.Add(nouveauUtilitaire);

                } while (continuer == true);

                //On retourne au sous menu ajouter un véhicule
                GestionMenuAjouter(listeDesVoiture, listeDesUtilitaire);

            }

            //On éfface l'écran et on trace le cadre
            InitialiseEcran();

            //Menu qui va permettre d'ajouter une voiture
            saisieXY("1------> Ajouter une voiture", 20, 12);

            //Menu qui va permettre d'ajouter un utilitaire
            saisieXY("2------> Ajouter un utilitaire", 20, 15);

            //Menu qui va permettre de retourner au menu principal
            saisieXY("3------> Retourner au menu principal", 20, 18);

            // On attend la décision de l'utilisateur
            saisieXY("Veuillez effectuer votre choix :  ", 40, 25);
            
            //On redirige vers l'ajout d'une voiture ou d'un utilitaire
            switch(RecupereChoixSousMenu())
            {
                case 1:
                    AjouterVoiture(ref listeDesVoiture);
                    break;
                case 2:
                    AjouterUtilitaire(ref listeDesUtilitaire);
                    break;
                case 3:
                    AfficheMenuPrincipal(listeDesVoiture, listeDesUtilitaire);
                    break;
            }
        }


        /// <summary>
        /// Fonction qui gérer le menu de suppression des véhicules
        /// </summary>
        /// <param name="listeDesVehicules"> Paramètre ayant une portée globale et qui contiendra l'ensemble des véhicules </param>
        static void GestionMenuSupprimer(List<Voiture> listeDesVoiture, List<Utilitaire> listeDesUtilitaire)
        {
            bool enleverVoiture(ref List<Voiture> _listeDesVoiture, ref List<Utilitaire> _listeDesUtilitaire, string immatriculationVeh)
            {
                //Variable qui indiquera si la recherche a réussie
                bool reussiTrouve = false;

                for (int i = 0; i < _listeDesVoiture.Count(); i++)
                {
                    if (_listeDesVoiture[i].ImmatriculationVeh == immatriculationVeh)
                    {
                        //La recherche a reussie
                        reussiTrouve = true;

                        _listeDesVoiture.RemoveAt(i);
                        barreDeChargement("Suppression en cours...");
                        GestionMenuSupprimer(_listeDesVoiture, _listeDesUtilitaire);
                    }
                }
                return reussiTrouve;
            }

            bool enleverUtilitaire(ref List<Voiture> _listeDesVoiture, ref List<Utilitaire> _listeDesUtilitaire, string immatriculationVeh)
            {
                //Variable qui indiquera si la recherche a réussie
                bool reussiTrouve = false;

                for (int i = 0; i < _listeDesUtilitaire.Count(); i++)
                {
                    if (_listeDesUtilitaire[i].ImmatriculationVeh == immatriculationVeh)
                    {
                        //La recherche a reussie
                        reussiTrouve = true;

                        _listeDesUtilitaire.RemoveAt(i);
                        barreDeChargement("Suppression en cours...");
                        GestionMenuSupprimer(_listeDesVoiture, _listeDesUtilitaire);
                    }
                }
                return reussiTrouve;
            }

            //Fonction qui va ajouter une voiture
            void SupprimerVoiture(ref List<Voiture> _listeDesVoiture, ref List<Utilitaire> _listeDesUtilitaire)
            {
                //On défini un véhicule qui va nous servir de base
                Voiture nouvelleVoiture = new Voiture();

                bool continuer = false;

                string reponseCont = "", immatriculationVeh = "";

                //On boucle pour récupérer les informations d"une voiture
                do
                {
                    //On initialise l'écran
                    InitialiseEcran();

                    //On affiche un message indiquant que nous somme entrain d'ajouter une voiture
                    saisieXY("SUPPRIMER UNE VOITURE : ", 10, 12, ConsoleColor.Gray);

                    //On récupère l'immatriculation du véhicule
                    saisieXY("Veuillez entrer l\'immatriculation de la voiture : ", 34, 16, ConsoleColor.Gray);
                    immatriculationVeh = recupereSaisie(84, 16);

                    //On appel la fonction qui enlève une voiture
                    if (enleverVoiture(ref _listeDesVoiture, ref  _listeDesUtilitaire, immatriculationVeh) == false)
                    {
                        saisieXY("Aucune voiture avec cette immatriculation. Veuillez reesayer !", 30, 24, ConsoleColor.Red);
                        Console.SetCursorPosition(92, 24);

                        Console.ReadKey();

                        //On retourne au sous menu de suppression
                        GestionMenuSupprimer(_listeDesVoiture, _listeDesUtilitaire);
                    }
                    else
                    {
                        //On boucle en attendant le choix de l'utilisateur
                        do
                        {
                            saisieXY("Voulez-vous continuer ? [O / N] :  ", 40, 25, ConsoleColor.Gray);
                            reponseCont = recupereSaisie(75, 25);
                        } while ((reponseCont != "O") || (reponseCont != "o") || (reponseCont != "N") || (reponseCont != "n"));

                        if ((reponseCont.Equals("O")) || (reponseCont.Equals("o")))
                            continuer = true;
                        if ((reponseCont.Equals("N")) || (reponseCont.Equals("n")))
                            continuer = false;
                    }  
                } while (continuer == true);

                //On retourne au sous menu de suppression
                GestionMenuSupprimer(_listeDesVoiture, _listeDesUtilitaire);
            }

            //Fonction qui va ajouter un utilitaire
            void SupprimerUtilitaire(ref List<Voiture> _listeDesVoiture, ref List<Utilitaire> _listeDesUtilitaire)
            {
                //On défini un véhicule qui va nous servir de base
                Utilitaire nouvelUtilitaire = new Utilitaire();

                bool continuer = false;

                string reponseCont = "", immatriculationVeh = "";

                //On boucle pour récupérer les informations d"une voiture
                do
                {
                    //On initialise l'écran
                    InitialiseEcran();

                    //On affiche un message indiquant que nous somme entrain d'ajouter une voiture
                    saisieXY("SUPPRIMER UN UTILITAIRE : ", 10, 12, ConsoleColor.Gray);

                    //On récupère l'immatriculation du véhicule
                    saisieXY("Veuillez entrer l\'immatriculation de l\'utilitaire : ", 34, 16, ConsoleColor.Gray);
                    immatriculationVeh = recupereSaisie(86, 16);

                    //On appel la fonction qui enlève une voiture
                    if (enleverUtilitaire(ref _listeDesVoiture, ref _listeDesUtilitaire, immatriculationVeh) == false)
                    {
                        saisieXY("Aucune voiture avec cette immatriculation. Veuillez reesayer !", 30, 24, ConsoleColor.Red);
                        Console.SetCursorPosition(92, 24);

                        Console.ReadKey();

                        //On retourne au sous menu de suppression
                        GestionMenuSupprimer(_listeDesVoiture, _listeDesUtilitaire);
                    }
                    else
                    {
                        //On boucle en attendant le choix de l'utilisateur
                        do
                        {
                            saisieXY("Voulez-vous continuer ? [O / N] :  ", 40, 25, ConsoleColor.Gray);
                            reponseCont = recupereSaisie(75, 25);
                        } while ((reponseCont != "O") || (reponseCont != "o") || (reponseCont != "N") || (reponseCont != "n"));

                        if ((reponseCont.Equals("O")) || (reponseCont.Equals("o")))
                            continuer = true;
                        if ((reponseCont.Equals("N")) || (reponseCont.Equals("n")))
                            continuer = false;
                    }
                } while (continuer == true);

                //On retourne au sous menu de suppression
                GestionMenuSupprimer(_listeDesVoiture, _listeDesUtilitaire);
            }

            //On éfface l'écran et on trace le cadre
            InitialiseEcran();

            //Menu qui va permettre d'ajouter une voiture
            saisieXY("1------> Supprimer une voiture", 20, 12);

            //Menu qui va permettre d'ajouter un utilitaire
            saisieXY("2------> Supprimer un utilitaire", 20, 15);

            //Menu qui va permettre de retourner au menu principal
            saisieXY("3------> Retourner au menu principal", 20, 18);

            saisieXY("Veuillez effectuer votre choix :  ", 40, 25);

            //On redirige vers l'ajout d'une voiture ou d'un utilitaire
            switch (RecupereChoixSousMenu())
            {
                case 1:
                    SupprimerVoiture(ref listeDesVoiture, ref listeDesUtilitaire);
                    break;
                case 2:
                    SupprimerUtilitaire(ref listeDesVoiture, ref listeDesUtilitaire);
                    break;
                case 3:
                    AfficheMenuPrincipal(listeDesVoiture, listeDesUtilitaire);
                    break;
            }
        }


        /// <summary>
        /// Fonction qui va gérer le menu de consultation des véhicules
        /// </summary>
        /// <param name="listeDesVehicules"> Paramètre ayant une portée globale et qui contiendra l'ensemble des véhicules </param>
        static void GestionMenuConsulter(List<Voiture> listeDesVoiture, List<Utilitaire> listeDesUtilitaire)
        {
            int i = 0, y = 0, z = 0, cpte = 0;
            
            //On initialise l'écran
            InitialiseEcranConsultation(listeDesVoiture.Count() + listeDesUtilitaire.Count());

            //On affiche un message indiquant que nous somme entrain d'ajouter une voiture
            saisieXY("LISTE DES VEHICULES : ", 10, 10, ConsoleColor.Blue);

            saisieXY("VOITURES : ", 10, 14, ConsoleColor.Cyan);

            //On entre dans la boucle qui va afficher la liste des voitures
            for(i = 0; i < listeDesVoiture.Count(); i++)
            {
                saisieXY($"VOITURE {i + 1} : ", 14, 16 + (i * 6), ConsoleColor.DarkBlue);

                //On affiche l'immatriculation de la voiture
                saisieXY("Immatriculation :  ", 20, 18 + (i * 6), ConsoleColor.Gray);
                saisieXY(listeDesVoiture[i].ImmatriculationVeh, 39, 18 + (i * 6), ConsoleColor.DarkGreen);

                //On affiche la marque de la voiture
                saisieXY("Marque : ", 58, 18 + (i * 6), ConsoleColor.Gray);
                saisieXY(listeDesVoiture[i].MarqueVeh, 68, 18 + (i * 6), ConsoleColor.DarkGreen);

                //On affiche la couleur du véhicule
                saisieXY("Couleur : ", 84, 18 + (i * 6), ConsoleColor.Gray);
                saisieXY(listeDesVoiture[i].CouleurVeh, 94, 18 + (i * 6), ConsoleColor.DarkGreen);

                //On affiche le nombre de porte de la voiture
                saisieXY("Nombre de porte: ", 20, 20 + (i * 6), ConsoleColor.Gray);
                saisieXY(listeDesVoiture[i].NombrePorte, 39, 20 + (i * 6), ConsoleColor.DarkGreen);
            }


            /*
             * Sans comprendre pourquoi mais après la boucle précédente, on gagne +2 ligne
             * en ajoutant +1 dans l'instruction (y = i + 1) on crée ainsi un écart de +6 par rapport au mot UTILITAIRES
             * On a ainsi ajouté +2 par rapport au paramètre y d'origine de saisyeXY de UTILITAIRES
             * Et dans la boucle suivante on a réduit -2 a tous les paramètres y d'origine
             * */
            saisieXY("UTILLITAIRES : ", 10, 18 + (i * 6), ConsoleColor.Cyan);

            //On entre dans la boucle qui va afficher la liste des utilitaires
            for (y = i + 1, z = 0; ((y < listeDesVoiture.Count() + listeDesUtilitaire.Count() + 1) && (z < listeDesUtilitaire.Count())); y++, z++)
            {
                saisieXY($"UTILITAIRE {z + 1} : ", 14, 14 + (y * 6), ConsoleColor.DarkBlue);

                //On affiche l'immatriculation de la voiture
                saisieXY("Immatriculation :  ", 20, 16 + (y * 6), ConsoleColor.Gray);
                saisieXY(listeDesUtilitaire[z].ImmatriculationVeh, 39, 16 + (y * 6), ConsoleColor.DarkGreen);

                //On affiche la marque de la voiture
                saisieXY("Marque : ", 50, 16 + (y * 6), ConsoleColor.Gray);
                saisieXY(listeDesUtilitaire[z].ImmatriculationVeh, 60, 16 + (y * 6), ConsoleColor.DarkGreen);

                //On affiche la couleur du véhicule
                saisieXY("Couleur : ", 70, 16 + (y * 6), ConsoleColor.Gray);
                saisieXY(listeDesUtilitaire[z].ImmatriculationVeh, 80, 16 + (y * 6), ConsoleColor.DarkGreen);

                //On affiche le nombre de porte de la voiture
                saisieXY("Nombre de porte: ", 20, 18 + (y * 6), ConsoleColor.Gray);
                saisieXY(listeDesUtilitaire[z].VolumeUtile, 37, 18 + (y * 6), ConsoleColor.DarkGreen);
            }


            saisieXY("Appuyez sur une touche pour retourner au menu principal !", 30, 20 + (y * 6), ConsoleColor.Red);
            Console.SetCursorPosition(88, 20 + (y * 6));

            Console.ReadKey();

            //On retourne au sous menu de suppression
            AfficheMenuPrincipal(listeDesVoiture, listeDesUtilitaire);
        }


        /// <summary>
        /// Fonction qui va gérer le menu de sauvegarde des véhicules dans un fichier
        /// </summary>
        /// <param name="listeDesVehicules"> Paramètre ayant une portée globale et qui contiendra l'ensemble des véhicules </param>
        static void GestionMenuSauvegarder(List<Voiture> listeDesVoiture, List<Utilitaire> listeDesUtilitaire)
        {
            /**
             * Dans cette partie nous allons principalement appliquer le principe de la SERIALISATION
             * SERIALISATION : Principe consistant à rendre les objets d'une classe enregistrable sur un disque
             * */

            //Fonction qui va écrire l'ensemble des voitures de la liste des voitures dans un fichier
            void saveVoiture(List<Voiture> _listeDesVoiture, string nomFichier)
            {
                /**
                 * On ajoute un préfixe au nom du fichier pour le différencier des fichiers des utilitaires
                 * Et on ajoute l'extension ".xml" au nom du fichier
                 * */
                nomFichier = nomFichier + "_voit" + ".xml";

                //On crée un flux vers le fichier
                var fichier = Path.Combine(Directory.GetCurrentDirectory(), nomFichier);

                try
                {
                    //Création de l'objet qui va permettre la sérialisation
                    XmlSerializer formatter = new XmlSerializer(typeof(List<Voiture>));

                    using (FileStream writerStream = new FileStream(fichier, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        //On écrit dans le fichier chaque voiture de la liste des voitures
                        formatter.Serialize(writerStream, _listeDesVoiture);

                        barreDeChargement("Sauvegarde en cours ...");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(Environment.NewLine + ex.Message);
                }
            }

            //try
            //{
            //    // Set a variable to the My Documents path.
            //    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //    List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));

            //    foreach (var dir in dirs)
            //    {
            //        Console.WriteLine($"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}");
            //    }
            //    Console.WriteLine($"{dirs.Count} directories found.");
            //}
            //catch (UnauthorizedAccessException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (PathTooLongException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        

        //Fonction qui va écrire l'ensemble des utilitaires de la liste des utilitaires dans un fichier
        void saveUtilitaire(List<Utilitaire> _listeDesUtilitaire, string nomFichier)
            {
                /**
                 * On ajoute un préfixe au nom du fichier pour le différencier des fichiers des utilitaires
                 * Et on ajoute l'extension ".xml" au nom du fichier
                 * */
                nomFichier = nomFichier + "_util" + ".xml";

                //On crée un flux vers le fichier
                var fichier = Path.Combine(Directory.GetCurrentDirectory(), nomFichier);

                try
                {
                    //Création de l'objet qui va permettre la sérialisation
                    XmlSerializer formatter = new XmlSerializer(typeof(List<Utilitaire>));

                    using (FileStream writerStream = new FileStream(fichier, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        //On écrit dans le fichier chaque voiture de la liste des voitures
                        formatter.Serialize(writerStream, _listeDesUtilitaire);

                        barreDeChargement("Sauvegarde en cours ...");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(Environment.NewLine + ex.Message);
                }
            }

            //Fonction qui va gérer l'IHM pour la sauvegardes des voitures
            void GereSauvegardeVoiture(List<Voiture> _listeDesVoiture, List<Utilitaire> _listeDesUtilitaire)
            {
                string nomFichier = "";

                //On initialise l'écran
                InitialiseEcran();

                //On affiche un message indiquant que nous somme entrain d'ajouter une voiture
                saisieXY("SAUVEGARDER LA LISTE DES VOITURES : ", 10, 12, ConsoleColor.Gray);

                //On récupère l'immatriculation du véhicule
                saisieXY("Veuillez entrer le nom du fichier : ", 34, 16, ConsoleColor.Gray);
                nomFichier = recupereSaisie(72, 16);

                saveVoiture(_listeDesVoiture, nomFichier);

                //On appel la fonction qui enlève une voiture
                saisieXY("Sauvegarde effectuee avec succes. Appuyez sur une touche !", 30, 24, ConsoleColor.Red);
                Console.SetCursorPosition(92, 24);

                Console.ReadKey();

                //On retourne au sous menu de suppression
                GestionMenuSauvegarder(_listeDesVoiture, _listeDesUtilitaire);
            }

            //Fonction qui va gérer l'IHM pour la sauvegardes des voitures
            void GereSauvegardeUtilitaire(List<Voiture> _listeDesVoiture, List<Utilitaire> _listeDesUtilitaire)
            {
                string nomFichier = "";

                //On initialise l'écran
                InitialiseEcran();

                //On affiche un message indiquant que nous somme entrain d'ajouter une voiture
                saisieXY("SAUVEGARDER LA LISTE DES UTILITAIRES : ", 10, 12, ConsoleColor.Gray);

                //On récupère l'immatriculation du véhicule
                saisieXY("Veuillez entrer le nom du fichier : ", 34, 16, ConsoleColor.Gray);
                nomFichier = recupereSaisie(72, 16);

                saveUtilitaire(_listeDesUtilitaire, nomFichier);

                //On appel la fonction qui enlève une voiture
                saisieXY("Sauvegarde effectuee avec succes. Appuyez sur une touche !", 30, 24, ConsoleColor.Red);
                Console.SetCursorPosition(92, 24);

                Console.ReadKey();

                //On retourne au sous menu de suppression
                GestionMenuSauvegarder(_listeDesVoiture, _listeDesUtilitaire);
            }
            
            //On éfface l'écran et on trace le cadre
            InitialiseEcran();

            //Menu qui va permettre d'ajouter une voiture
            saisieXY("1------> Sauvegarder les voitures", 20, 12);

            //Menu qui va permettre d'ajouter un utilitaire
            saisieXY("2------> Sauvegarder les utilitaires", 20, 15);

            //Menu qui va permettre de retourner au menu principal
            saisieXY("3------> Retourner au menu principal", 20, 18);

            saisieXY("Veuillez effectuer votre choix :  ", 40, 25);

            //On redirige vers l'ajout d'une voiture ou d'un utilitaire
            switch (RecupereChoixSousMenu())
            {
                case 1:
                    GereSauvegardeVoiture(listeDesVoiture, listeDesUtilitaire);
                    break;
                case 2:
                    GereSauvegardeUtilitaire(listeDesVoiture, listeDesUtilitaire);
                    break;
                case 3:
                    AfficheMenuPrincipal(listeDesVoiture, listeDesUtilitaire);
                    break;
            }
        }


        /// <summary>
        /// Fonction qui va gérer le menu de restauration des véhicules à partir d'un fichier
        /// </summary>
        /// <param name="listeDesVehicules"> Paramètre ayant une portée globale et qui contiendra l'ensemble des véhicules </param>
        static void GestionMenuRestaurer(ref List<Voiture> listeDesVoiture, ref List<Utilitaire> listeDesUtilitaire)
        {
            /**
             * Dans cette partie nous allons principalement appliquer le principe de la DESERIALISATION
             * DESERIALISATION : Principe consistant à initiliser ou créer un objet à partir d'informations provenant d'un fichier
             * */

            //Fonction qui va écrire l'ensemble des voitures de la liste des voitures dans un fichier
            void restoreVoiture(ref List<Voiture> _listeDesVoiture, string nomFichier)
            {
                /**
                 * On ajoute un préfixe au nom du fichier pour le différencier des fichiers des utilitaires
                 * Et on ajoute l'extension ".xml" au nom du fichier
                 * */
                nomFichier = nomFichier + "_voit" + ".xml";

                //On va créer un liste tampon de façon à ne pas perdre les données en cours lors de la restauration
                List<Voiture> listeTampon = new List<Voiture>();

                //On crée un flux vers le fichier
                var fichier = Path.Combine(Directory.GetCurrentDirectory(), nomFichier);
                
                try
                {
                    if(File.Exists(fichier))
                    {
                        //Création de l'objet qui va permettre la sérialisation
                        XmlSerializer formatter = new XmlSerializer(typeof(List<Voiture>));

                        using (FileStream readerStream = new FileStream(fichier, FileMode.Open, FileAccess.Read))
                        {
                            //On récupère le contenu du fichier XML sous forme de liste de voiture
                            listeTampon = (List<Voiture>)formatter.Deserialize(readerStream);

                            barreDeChargement("Restauration en cours ...");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(Environment.NewLine + ex.Message);
                }

                //On ajoute les éléments récupérés du fichiers dans la liste courante
                foreach(Voiture newVoiture in listeTampon)
                {
                    _listeDesVoiture.Add(newVoiture);
                }
            }

            //Fonction qui va écrire l'ensemble des utilitaires de la liste des utilitaires dans un fichier
            void restoreUtilitaire(ref List<Utilitaire> _listeDesUtilitaire, string nomFichier)
            {
                /**
                 * On ajoute un préfixe au nom du fichier pour le différencier des fichiers des utilitaires
                 * Et on ajoute l'extension ".xml" au nom du fichier
                 * */
                nomFichier = nomFichier + "_util" + ".xml";

                //On va créer un liste tampon de façon à ne pas perdre les données en cours lors de la restauration
                List<Utilitaire> listeTampon = new List<Utilitaire>();

                //On crée un flux vers le fichier
                var fichier = Path.Combine(Directory.GetCurrentDirectory(), nomFichier);

                try
                {
                    if (File.Exists(fichier))
                    {
                        //Création de l'objet qui va permettre la sérialisation
                        XmlSerializer formatter = new XmlSerializer(typeof(List<Utilitaire>));

                        using (FileStream readerStream = new FileStream(fichier, FileMode.Open, FileAccess.Read))
                        {
                            //On récupère le contenu du fichier XML sous forme de liste de voiture
                            listeTampon = (List<Utilitaire>)formatter.Deserialize(readerStream);

                            barreDeChargement("Restauration en cours ...");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(Environment.NewLine + ex.Message);
                }

                //On ajoute les éléments récupérés du fichiers dans la liste courante
                foreach(Utilitaire newUtilitaire in listeTampon)
                {
                    _listeDesUtilitaire.Add(newUtilitaire);
                }
            }

            //Fonction qui va gérer l'IHM pour la sauvegardes des voitures
            void GereRestaurationVoiture(List<Voiture> _listeDesVoiture, List<Utilitaire> _listeDesUtilitaire)
            {
                string nomFichier = "";

                //On initialise l'écran
                InitialiseEcran();

                //On affiche un message indiquant que nous somme entrain d'ajouter une voiture
                saisieXY("RESTAURER LA LISTE DES VOITURES : ", 10, 12, ConsoleColor.Gray);

                //On récupère l'immatriculation du véhicule
                saisieXY("Veuillez entrer le nom du fichier : ", 34, 16, ConsoleColor.Gray);
                nomFichier = recupereSaisie(72, 16);

                restoreVoiture(ref _listeDesVoiture, nomFichier);

                //On appel la fonction qui enlève une voiture
                saisieXY("Restauration effectuee avec succes. Appuyez sur une touche !", 30, 24, ConsoleColor.Red);
                Console.SetCursorPosition(92, 24);

                Console.ReadKey();

                //On retourne au sous menu de suppression
                GestionMenuRestaurer(ref _listeDesVoiture, ref _listeDesUtilitaire);
            }

            //Fonction qui va gérer l'IHM pour la sauvegardes des voitures
            void GereRestaurationUtilitaire(List<Voiture> _listeDesVoiture, List<Utilitaire> _listeDesUtilitaire)
            {
                string nomFichier = "";

                //On initialise l'écran
                InitialiseEcran();

                //On affiche un message indiquant que nous somme entrain d'ajouter une voiture
                saisieXY("RESTAURER LA LISTE DES UTILITAIRES : ", 10, 12, ConsoleColor.Gray);

                //On récupère l'immatriculation du véhicule
                saisieXY("Veuillez entrer le nom du fichier : ", 34, 16, ConsoleColor.Gray);
                nomFichier = recupereSaisie(72, 16);

                restoreUtilitaire(ref _listeDesUtilitaire, nomFichier);

                //On appel la fonction qui enlève une voiture
                saisieXY("Restauration effectuee avec succes. Appuyez sur une touche !", 30, 24, ConsoleColor.Red);
                Console.SetCursorPosition(92, 24);

                Console.ReadKey();

                //On retourne au sous menu de suppression
                GestionMenuRestaurer(ref _listeDesVoiture, ref _listeDesUtilitaire);
            }

            //On éfface l'écran et on trace le cadre
            InitialiseEcran();

            //Menu qui va permettre d'ajouter une voiture
            saisieXY("1------> Restaurer les voitures", 20, 12);

            //Menu qui va permettre d'ajouter un utilitaire
            saisieXY("2------> Restaurer les utilitaires", 20, 15);

            //Menu qui va permettre de retourner au menu principal
            saisieXY("3------> Retourner au menu principal", 20, 18);

            saisieXY("Veuillez effectuer votre choix :  ", 40, 25);

            //On redirige vers l'ajout d'une voiture ou d'un utilitaire
            switch (RecupereChoixSousMenu())
            {
                case 1:
                    GereRestaurationVoiture(listeDesVoiture, listeDesUtilitaire);
                    break;
                case 2:
                    GereRestaurationUtilitaire(listeDesVoiture, listeDesUtilitaire);
                    break;
                case 3:
                    AfficheMenuPrincipal(listeDesVoiture, listeDesUtilitaire);
                    break;
            }
        }

        /// <summary>  
        /// Fonction qui va diriger vers les sous menus de l'application
        /// </summary>
        /// <param name="Reponse">Représente le numéro du sous menu</param>
        static void DirigeSousMenu(int Reponse, ref List<Voiture> listeDesVoiture, ref List<Utilitaire> listeDesUtilitaire)
        {
            switch(Reponse)
            {
                case 1 :
                    GestionMenuAjouter(listeDesVoiture, listeDesUtilitaire);
                    break;

                case 2:
                    GestionMenuSupprimer(listeDesVoiture, listeDesUtilitaire);
                    break;

                case 3:
                    GestionMenuConsulter(listeDesVoiture, listeDesUtilitaire);
                    break;

                case 4:
                    GestionMenuSauvegarder(listeDesVoiture, listeDesUtilitaire);
                    break;

                case 5:
                    GestionMenuRestaurer(ref listeDesVoiture, ref listeDesUtilitaire);
                    break;

                default :
                    Console.Clear();
                    Console.WriteLine("Erreur");
                    break;

            }
        }

        static void Main(string[] args)
        {
            //On défini les liste de gestion du programme
            List<Voiture> listeDesVoitures = new List<Voiture>();
            List<Utilitaire> listeDesUtilitaires = new List<Utilitaire>();


            AfficheMenuPrincipal(listeDesVoitures, listeDesUtilitaires);

            Console.ReadKey();
        }
    }
}
