using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BanqueApp
{
    public class Compte
    {

        //private static int compt = 0;
        private int num_compte;
        private double solde { get; set; }
        private static double plafond= 2000;
        private Client titulaire;
        private List<Operation> liste_operations;

        public Compte(double d, Client c,int num) 
        {
            this.num_compte = num;
            this.solde = d;
            this.titulaire = c;
            this.liste_operations = new List<Operation>();
        }
       ~Compte()
        {
            
        }
        public bool solde_suffisant(double mont)
        {
            return ((this.solde>= (mont))&& (mont<= (Compte.plafond)));
        }

        public bool num_equals(int numero)
        {
            if (this.num_compte == numero) return true;
            return false;
        }
        public double minus_solde(double d)
        {
            return this.solde-d;
        }
        public double plus_solde(double d)
        {
            return this.solde+d;
        }
        public double times_solde(double d)
        {
            return this.solde*d;
        }
        public bool check_solde(double d)
        {
            return this.solde>=d;
        }
        public bool check_solde(double d1, double d2)
        {
            return this.solde>=(d1*d2) ;
        }
        public virtual void retrait(double d)
        {
            this.solde = this.solde - d;
            OperationR o = new OperationR(d, this);
            this.ajouter_operation(o);
        }

        public virtual void transfert(Compte cmp,double montant)
        {
            this.retrait(montant);
            cmp.virement(montant);
        }
		public virtual void virement(double d)
        {

                this.solde = this.solde + d;
                OperationV o = new OperationV(d, this);
                this.ajouter_operation(o);
        }
		public void ajouter_operation(Operation o)
        {
            this.liste_operations.Add(o);
        }
        public bool test_sup(double d)
        {
            return this.solde>=d;
        }

        public override string ToString()
        {
            return "num compte: " + this.num_compte + " solde: " + this.solde;
        }
        public void  afficher() 
        {
            Console.WriteLine ("\nnum compte: " + this.num_compte );
            Console.WriteLine("\n le solde: "+this.solde);
            //this->titulaire->Client::afficher();
            for (int i = 0; i < this.liste_operations.Count() ; i++)
            {
                this.liste_operations[i].afficher();
                Console.WriteLine("");
            }
        }
	}
}
