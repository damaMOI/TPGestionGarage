using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionGarage
{
    public enum TypeMoteur
    {
        Diesel,
        Essence,
        Hybride,
        Electrique
    }

    public class Moteur
    {
        // crée la static pour générer les id
        private static int inc = 1;

        // attributs
        private int id;
        private string nom;
        private int puissance;
        private TypeMoteur typeMoteur;

        // getters et setters
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Puissance { get => puissance; set => puissance = value; }
        public TypeMoteur TypeMoteur { get => typeMoteur; set => typeMoteur = value; }

        // constucteurs
        public Moteur()
        {

        }

        public Moteur(string nom, int puissance, TypeMoteur typeMoteur)
        {
            // génère l'id avec la valeur de inc qui est ensuite incrémentée
            this.id = inc++;
            this.nom = nom;
            this.puissance = puissance;
            this.typeMoteur = typeMoteur;
        }

        public void Afficher()
        {
            Console.WriteLine("Moteur id : {0}, nom : {1}, puissance : {2}, type : {3}", id, nom, puissance, typeMoteur);
        }
    }
}
