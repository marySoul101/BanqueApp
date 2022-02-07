﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp
{
    public class OperationR:Operation
    {
        
        private static string libelle= "retrait";
        
        public OperationR(double mont, Compte c) : base(mont, c)
        {

        }
        public override void afficher()
        {
            Console.WriteLine("\ntype op: " + OperationR.libelle);
            base.afficher();
        }
    }
}
