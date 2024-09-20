using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CompteBancaire
{
    public class Compte
    {
        private int numero;
        private string nom;
        private double solde;
        private double decouvertAutorise;


        public Compte()
        {
            numero = 0;
            nom = "";
            solde = 0;
            decouvertAutorise = 0; 
        }

        public Compte (int numero, string nom, double solde, double decouvertAutorise)
        {
            this.numero = numero;
            this.nom = nom;
            this.solde = solde;
            this.decouvertAutorise = decouvertAutorise;
        }

        public int getNumero()
        {
            return numero;
        }

        public string getNom() 
        {
            return nom;
        }

        public double getSolde() 
        {
            return solde;
        }

        public double GetDecouvertAutorise()
        {
            return decouvertAutorise;
        }

        public override string ToString()
        {
            return $"Compte numéro : , {numero}, nom du compte : {nom}, solde : {solde}, decouvertAutorise : {decouvertAutorise}";
        }

        public void Crediter(double montant)
        {
            solde += montant;
        }

        public bool Debiter(double montant)
        {
            bool flag = true;
            {
                if (solde - montant >= decouvertAutorise)
                {
                    solde -= montant;
                    return flag;
                }

                return false;

            }
        }

        public bool Transferer(double montant, Compte b)
        {
            bool flag = true;
            {
                if (this.Debiter(montant))
                {
                    b.Crediter(montant);
                    flag = false;
                }

                return flag;
                    
            }

        }

    }

}