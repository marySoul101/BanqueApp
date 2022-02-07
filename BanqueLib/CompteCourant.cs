using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp
{
    public class CompteCourant : Compte
    {
        
		private static double decouvert = 200;
		public CompteCourant(double s, Client c,int num) :base(s, c,num)
        {

        }
		public void afficher()
        {
            Console.WriteLine( "\ndecouvert: "+ CompteCourant.decouvert);
            base.afficher();

        }
        public override void retrait(double d)
        {
            //throw new NotImplementedException();

            if ((this.solde_suffisant(d)) && (this.test_sup(d+(CompteCourant.decouvert))))
            {
                base.retrait(d);
            }
        }

        public override void virement(double d)
        {
            //throw new NotImplementedException();
            base.virement(d);
        }

        public override void transfert(Compte cmp, double montant)
        {
            this.retrait(montant);
            cmp.virement(montant);
        }
    }
}
