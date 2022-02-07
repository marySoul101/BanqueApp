using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BanqueApp
{
    public class Operation
    {
		private static int compt = 0;
		private readonly int num_op;
		private DateTime date_op;
		private double montant_op;
		private Compte compte_banq;
		
		public Operation(double mont, Compte c) 
		{
			this.date_op = DateTime.Now;
			this.montant_op = mont;
			this.compte_banq = c;
			this.num_op = ++compt;
		}
        ~Operation()
        {

        }
		public virtual void afficher()
        {
			Console.WriteLine("\nnum op: " +this.num_op + "\ndate op: " + this.date_op+"\nmontant operation: "+this.montant_op+"\n");
		}
	}
}
