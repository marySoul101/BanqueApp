using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows;
namespace BanqueApp
{
    public class Client
    {
		private string prenom;
		private string nom;
		private string adresse;
        private string login;
        private string mdp;
		private List<Compte> liste_comptes;
		public Client(string p, string n, string adr,string log,string pass)
        {
            this.prenom = p;
            this.nom = n;
            this.adresse = adr;
            this.login = log;
            this.mdp = pass;
            this.liste_comptes = new List<Compte>();
        }
        ~Client()
        {

        }
		public void ajouter_compte(Compte c)
        {
            this.liste_comptes.Add(c);
        }

        public String getPrenom()
        {
            return this.prenom;
        }

        public String getNom()
        {
            return this.nom;
        }

        public String getAdresse()
        {
            return this.adresse;
        }
        public void afficher()
        {
            Console.WriteLine( "\nnom client: "+ this.nom + "\nprenom client: "+ this.prenom+ "\nadresse client: "+ this.adresse );
            for (int i = 0; i < this.liste_comptes.Count(); i++)
            {
                this.liste_comptes[i].afficher();
                Console.WriteLine("");
            }
        }
	}
}
