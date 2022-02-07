using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp
{
    public class CompteEpargne:Compte
    {
		
		private double taux_interet;
		private static double min_taux = 0;
		private static double max_taux=100;
	
		public CompteEpargne(double t, double s, Client c,int num) : base(s,c,num)
        {
			if ((t>= (CompteEpargne.min_taux)) && (t<= (CompteEpargne.max_taux)))
				this.taux_interet = t;
		}
		public override void retrait(double d)
        {
			if (this.check_retrait_CE(d))
			{
				base.retrait(d);
			}
		}
		public override void virement(double d)
        {
			base.virement(d);
        }

        public override void transfert(Compte cmp, double montant)
        {
			this.retrait(montant);
			cmp.virement(montant);
        }
        public double calcul_interet()
        {
			return this.times_solde(this.taux_interet);
		}
		public bool check_retrait_CE(double d)
        {
			double d1 = 0.5;
			return (d<= (this.times_solde(d1)));
		}
		public void afficher()
        {
			Console.WriteLine("\ntaux interet: \n"+this.taux_interet);
			
			base.afficher();
		}
		public void afficher_taux_interet()
        {
			Console.WriteLine("\ntaux interet: \n"+ this.taux_interet);
		}
	}
}
