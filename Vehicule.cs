using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionGarage
{
    public enum Marque
    {
        Audi,
        Citroen,
        Peugeot,
        Renault,
        Mercedes,
        Triumph,
        Yamaha
    }

    public abstract class Vehicule : IComparable
    {
        private static int inc = 1;

        protected int id;
        protected string nom;
        protected decimal prixHT;
        protected Marque marque;
        protected Moteur moteur;
        protected List<Option> options = new List<Option>();

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public decimal PrixHT { get => prixHT; set => prixHT = value; }
        public Marque Marque { get => marque; set => marque = value; }
        public Moteur Moteur { get => moteur; set => moteur = value; }

        public Vehicule()
        {

        }
        protected Vehicule(string nom, decimal prixHT, Marque marque, Moteur moteur)
        {
            this.id = inc++;
            this.nom = nom;
            this.prixHT = prixHT;
            this.marque = marque;
            this.moteur = moteur;
        }

        public void AjouterOption(Option option)
        {
            options.Add(option);
        }

        public abstract decimal CalculerTaxe();

        public decimal PrixTotal()
        {
            decimal prixTotal = prixHT + CalculerTaxe();

            // boucle sur les options pour ajouter le prix
            foreach (Option option in options)
            {
                prixTotal += option.Prix;
            }

            return prixTotal;
        }

        public void AfficherOption()
        {
            // boucle pour afficher les options
            foreach(Option option in options)
            {
                option.Afficher();
            }
        }

        public virtual void Afficher()
        {
            Console.WriteLine("id : {0}, nom : {1}, marque : {2}, prix HT : {3:C2}", id, nom, marque, prixHT);
            moteur.Afficher();
            Console.WriteLine("Prix Total : {0:C2}", PrixTotal());
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Vehicule vehicule = obj as Vehicule;
            if (vehicule != null)
                return this.PrixTotal().CompareTo(vehicule.PrixTotal());

            throw new ArgumentException("Object is not a Vehicule");
        }
    }
}
