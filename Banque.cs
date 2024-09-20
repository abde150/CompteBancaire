using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompteBancaire
{
    public class Banque
    {
        private List<Compte> comptes;

        public Banque()
        {
            comptes = new List<Compte>();
        }

        public void AjouteCompte(Compte c) 
        {
            comptes.Add(c); 
        }

        public void AjouteCompte(int num, string nom, double solde, double decouvertAutorise)
        {
            Compte c = new Compte(num, nom, solde, decouvertAutorise);
            comptes.Add(c);
        }
    }


}