using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GestionDuParc
{
    [Serializable]
    public class Voiture : Vehicule, ISerializable
    {
        //On défini l'attribut propre aux voiture
        int nombrePorte;

        //On défini la propriété qui encapsule l'attribut
        public int NombrePorte { get => nombrePorte; set => nombrePorte = value; }

        //On défini le constructeur par défaut
        public Voiture() : base()
        {
            NombrePorte = 4;
        }

        //On définit le constructeur avec paramètres
        public Voiture(string _immatriculation, string _marque, string _couleur, int _nombrePorte) : base(_immatriculation, _marque, _couleur)
        {
            NombrePorte = _nombrePorte;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Immatriculation", ImmatriculationVeh);
            info.AddValue("Marque", MarqueVeh);
            info.AddValue("Couleur", CouleurVeh);
            info.AddValue("Nombre de porte", NombrePorte);
        }

        //On définit un constructeur par défaut par sérialisation
        public Voiture(SerializationInfo info, StreamingContext context)
        {
            ImmatriculationVeh = (string)info.GetValue("Immatriculation", typeof(string));
            MarqueVeh = (string)info.GetValue("Marque", typeof(string));
            CouleurVeh = (string)info.GetValue("Couleur", typeof(string));
            NombrePorte = (int)info.GetValue("Nombre de porte", typeof(int));
        }
    }
}
