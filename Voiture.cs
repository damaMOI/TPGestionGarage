using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionGarage
{
    public class Voiture : Vehicule
    {
        private int chevauxFiscaux;
        private int nbPorte;
        private int nbSiege;
        private int tailleCoffre;

        public int ChevauxFiscaux { get => chevauxFiscaux; set => chevauxFiscaux = value; }
        public int NbPorte { get => nbPorte; set => nbPorte = value; }
        public int NbSiege { get => nbSiege; set => nbSiege = value; }
        public int TailleCoffre { get => tailleCoffre; set => tailleCoffre = value; }

        public Voiture() : base()
        {
        }

        public Voiture(string nom, decimal prixHT, Marque marque, Moteur moteur, int chevauxFiscaux, int nbPorte, int nbSiege, int tailleCoffre)
            : base(nom, prixHT, marque, moteur)
        {
            this.chevauxFiscaux = chevauxFiscaux;
            this.nbPorte = nbPorte;
            this.nbSiege = nbSiege;
            this.tailleCoffre = tailleCoffre;
        }

        public override decimal CalculerTaxe()
        {
            return this.chevauxFiscaux * 10;
        }

        public override void Afficher()
        {
            Console.Write("Moto ");

            // appel la méthode de la classe parent
            base.Afficher();

            Console.WriteLine("Chevaux Fiscaux : {0}, Nb Porte : {1}, Nb Siege : {2}, Taille Coffre : {3}", chevauxFiscaux, nbPorte, nbSiege, tailleCoffre);

            AfficherOption();
        }
    }
}
