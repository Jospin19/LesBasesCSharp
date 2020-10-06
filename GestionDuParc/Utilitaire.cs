using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GestionDuParc
{
    [Serializable()]
    public class Utilitaire : Vehicule, ISerializable
    {
        //On défini l'attribut propre aux voiture
        int volumeUtile;

        //On défini la propriété qui encapsule l'attribut
        public int VolumeUtile { get => volumeUtile; set => volumeUtile = value; }

        //On défini le constructeur par défaut
        public Utilitaire() : base()
        {
            VolumeUtile = 50;
        }

        //On définit le constructeur avec paramètres
        public Utilitaire(string _immatriculation, string _marque, string _couleur, int _volumeUtile) : base(_immatriculation, _marque, _couleur)
        {
            VolumeUtile = _volumeUtile;
        }

        //On implémente l'interface ISerializable
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Immatriculation", ImmatriculationVeh);
            info.AddValue("Marque", MarqueVeh);
            info.AddValue("Couleur", CouleurVeh);
            info.AddValue("Volume utile", VolumeUtile);
        }

        //On défini le constructeur par défaut par sérialisation
        public Utilitaire(SerializationInfo info, StreamingContext context)
        {
            ImmatriculationVeh = (string)info.GetValue("Immatriculation", typeof(string));
            MarqueVeh = (string)info.GetValue("Marque", typeof(string));
            CouleurVeh = (string)info.GetValue("Couleur", typeof(string));
            VolumeUtile = (int)info.GetValue("Volume utile", typeof(int));
        }
    }
}
