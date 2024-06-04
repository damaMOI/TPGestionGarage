using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionGarage
{
    public class Camion : Vehicule
    {
        private int nbEssieu;
        private int poids;
        private int volume;

        public int NbEssieu { get => nbEssieu; set => nbEssieu = value; }
        public int Poids { get => poids; set => poids = value; }
        public int Volume { get => volume; set => volume = value; }

        public Camion() : base()
        {

        }

        public Camion(string nom, decimal prixHT, Marque marque, Moteur moteur, 
            int nbEssieu, int poids, int volume)
            : base(nom, prixHT, marque, moteur)
        {
            this.nbEssieu = nbEssieu;
            this.poids = poids;
            this.volume = volume;
        }

        public override decimal CalculerTaxe()
        {
            return nbEssieu * 50;
        }

        public override void Afficher()
        {
            Console.Write("Camion ");

            // appel la méthode de la classe parent
            base.Afficher();

            Console.WriteLine("Nb Essieu : {0}, Poids : {1}, Volume : {2}", nbEssieu, poids, volume);

            AfficherOption();
        }
    }
}
