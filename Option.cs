using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionGarage
{
    public class Option
    {
        private static int inc = 1;

        private int id;
        private string nom;
        private decimal prix;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public decimal Prix { get => prix; set => prix = value; }

        public Option()
        {

        }

        public Option(string nom, decimal prix)
        {
            this.Id = inc++;
            this.nom = nom;
            this.prix = prix;
        }

        public void Afficher()
        {
            Console.WriteLine("Option id : {0}, nom : {1}, prix : {2:C2}", id, nom, prix);
        }
    }
}
