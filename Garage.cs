using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionGarage
{
    public class Garage
    {
        private string nom;
        private List<Vehicule> vehicules = new List<Vehicule>();
        private List<Option> options = new List<Option>();  
        private List<Moteur> moteurs = new List<Moteur>();

        public string Nom { get => nom; set => nom = value; }

        public Garage()
        {

        }

        public Garage(string nom)
        {
            this.nom = nom;
        }

        public void AjouterVehicule(Vehicule vehicule)
        {
            vehicules.Add(vehicule);
        }

        public void AjouterOption(Option option)
        {
            options.Add(option);
        }

        public void AjouterMoteur(Moteur moteur)
        {
            moteurs.Add(moteur);
        }

        public void Afficher()
        {
            Console.WriteLine("Garage {0}", nom);

            // boucle sur la liste
            foreach(Vehicule vehicule in vehicules)
            {
                vehicule.Afficher();
            }
        }

        public void AfficherVoiture()
        {
            // boucle sur la liste
            foreach(Vehicule vehicule in vehicules)
            {
                // cast le vehicule en voiture
                Voiture voiture = vehicule as Voiture;
                // si la conversion c'est bien faite
                if(voiture != null)
                {
                    voiture.Afficher();
                }
            }
        }

        public void AfficherCamion()
        {
            // boucle sur la liste
            foreach (Vehicule vehicule in vehicules)
            {
                // cast le vehicule en voiture
                Camion camion = vehicule as Camion;
                // si la conversion c'est bien faite
                if (camion != null)
                {
                    camion.Afficher();
                }
            }
        }

        public void AfficherMoto()
        {
            // boucle sur la liste
            foreach (Vehicule vehicule in vehicules)
            {
                // cast le vehicule en voiture
                Moto moto = vehicule as Moto;
                // si la conversion c'est bien faite
                if (moto != null)
                {
                    moto.Afficher();
                }
            }
        }

        public void TrierVehicule()
        {
            // trie les véhicules
            vehicules.Sort();
        }

        public Vehicule GetVehicule(int id)
        {
            Vehicule vehicule = vehicules.Find(v => v.Id == id);

            return vehicule;
        }
    }
}
