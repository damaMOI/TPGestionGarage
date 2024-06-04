using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionGarage
{
    public class Moto : Vehicule
    {
        private int cylindree;

        public int Cylindree { get => cylindree; set => cylindree = value; }

        public Moto() : base()
        {
        }

        public Moto(string nom, decimal prixHT, Marque marque, Moteur moteur, int cylindree)
            : base(nom, prixHT, marque, moteur) // appel le constructeur de la classe parent
        {
            this.cylindree = cylindree;
        }

        public override decimal CalculerTaxe()
        {
            // retourne que la partie entière
            return (int)(cylindree * (decimal)0.3);
        }

        public override void Afficher()
        {
            Console.Write("Moto ");

            // appel la méthode de la classe parent
            base.Afficher();

            Console.WriteLine("Cylindree : {0}", cylindree);

            AfficherOption();        
        }
    }
}
