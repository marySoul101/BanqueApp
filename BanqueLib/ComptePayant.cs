using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp
{
    class ComptePayant:CompteCourant
    {
        
        private static double price =0.05;
        
        public ComptePayant(double d, Client c,int num):base(d,c,num)
        {

        }
        public override void retrait(double d)
        {
            if (this.check_retrait_CP(d))
            {

                base.retrait(d);
                base.retrait(d * ComptePayant.price);
            }
           
           
         }
        
        public override void virement(double d)
        {
            base.virement(d);
            base.retrait(d*ComptePayant.price);
        }

        public override void transfert(Compte cmp, double montant)
        {
            this.retrait(montant);
            cmp.virement(montant);
        }
        public bool check_retrait_CP(double d)
        {
            return (this.check_solde((d * (ComptePayant.price))));
        }
    
        public void afficher()
        {
            Console.WriteLine("\nprix d'op: \n"+ ComptePayant.price); 
            base.afficher();
        
        }
    }
}
