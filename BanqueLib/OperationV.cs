using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp
{
    public class OperationV:Operation
    {
        
        private static string libelle = "virement";
        
        public OperationV(double mont, Compte c) : base(mont, c)
        {

        }
        public override void afficher()
        {
            Console.WriteLine("\ntype op: " + OperationV.libelle);
            base.afficher();
        }
    }
}
