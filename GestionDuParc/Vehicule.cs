using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDuParc
{
    public class Vehicule
    {
        //On définit les Attributs
        protected string immatriculationVeh;
        protected string marqueVeh;
        protected string couleurVeh;

        //On défini la propriété qui va permettre de connaitre le nombre de véhicule du parc
        private static int nombreVehicule;

        //On défini les prorpiété pour encapsuler les attributs
        public string ImmatriculationVeh { get => immatriculationVeh; set => immatriculationVeh = value; }
        public string MarqueVeh { get => marqueVeh; set => marqueVeh = value; }
        public string CouleurVeh { get => couleurVeh; set => couleurVeh = value; }
        protected static int NombreVehicule { get => nombreVehicule; set => nombreVehicule = value; }


        /**
         * On définit les différentes méthode de la classe
         * */

        //On défini le constructeur par défaut
        public Vehicule()
        {
            ImmatriculationVeh = "XXX11";
            MarqueVeh = "Mercedes";
            CouleurVeh = "Vert";

            //On incrémente le nombre de véhicule
            NombreVehicule++;
        }

        //On définit le constructuer avec paramètres
        public Vehicule(string _immatricultation, string _marque, string _couleur)
        {
            ImmatriculationVeh = _immatricultation;
            MarqueVeh = _marque;
            CouleurVeh = _couleur;

            //On incrémente le nombre de véhicule
            NombreVehicule++;
        }
        
    }
}
