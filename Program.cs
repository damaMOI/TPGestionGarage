using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionGarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // affiche les caractères spéciaux dans la console
            Console.OutputEncoding = Encoding.UTF8;
            
            // crée deux moteurs
            Moteur moteurClio = new Moteur("1.5 DCI", 85, TypeMoteur.Diesel);
            Moteur moteurC3 = new Moteur("1.2 L PureTech", 62, TypeMoteur.Essence);

            //moteurClio.Afficher();
            //moteurC3.Afficher();

            // créer 4 options
            Option toitOuvrant = new Option("Toit Ouvrant", 450);
            Option peintureMetaliser = new Option("Peinture Métalisée", 700);
            Option gps = new Option("GPS", 900);
            Option jante19Pouce = new Option("Jante 19\"", 600);

            //toitOuvrant.Afficher();
            //peintureMetaliser.Afficher();
            //gps.Afficher();
            //jante19Pouce.Afficher();

            // création d'un objet Vehicule impossible car classe Abstract
            //Vehicule v = new Vehicule();

            // crée des motos
            Moto thunderbird = new Moto("THUNDERBIRD 900", 5000,
                Marque.Triumph, new Moteur("3 Cylindres", 83, TypeMoteur.Essence), 885);

            //thunderbird.Afficher();

            // crée des voitures
            Voiture clio = new Voiture("Clio", 15000, Marque.Renault, moteurClio, 6, 5, 4, 300);

            //clio.Afficher();

            // crée des camions
            Camion master = new Camion("Master", 46000, Marque.Renault, new Moteur("DCI 150", 150, TypeMoteur.Diesel), 2, 2000, 8);

            //master.Afficher();

            // crée un Garage
            Garage garage = new Garage("Garage des botes");

            // ajout des vehicules
            garage.AjouterVehicule(clio);
            garage.AjouterVehicule(thunderbird);
            garage.AjouterVehicule(master);

            // ajout des options
            garage.AjouterOption(toitOuvrant);
            garage.AjouterOption(gps);
            garage.AjouterOption(jante19Pouce);
            garage.AjouterOption(peintureMetaliser);

            // ajout des moteurs
            garage.AjouterMoteur(moteurClio);
            garage.AjouterMoteur(moteurC3);
            garage.AjouterMoteur(new Moteur("3 Cylindres", 83, TypeMoteur.Essence));
            garage.AjouterMoteur(new Moteur("DCI 150", 150, TypeMoteur.Diesel));

            // tester Afficher
            garage.Afficher();

            // tester AfficherVoitue
            garage.AfficherVoiture();

            // tester AfficherCamion
            garage.AfficherCamion();

            // tester AfficherMoto
            garage.AfficherMoto();
            // tester le tri
            garage.TrierVehicule();

            Console.ReadKey();
        }
    }
}
