using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHLIL_MUSTAPHA___DINAR_YOUSSEF
{
    class Compte
    {
        private readonly int NumCompte;
        static int Cpt=0;
        private readonly Client Proprietaire;
        private Devise Solde;
        private List<Operation> ListOpr;

        public Compte(Client prop,Devise Solde)
        {
            NumCompte = ++Cpt;
            this.Proprietaire = prop;
            this.Solde = Solde;
            this.ListOpr = new List<Operation>();
        }

        virtual public void print()
        {
            Console.Write("NumCompte : " + this.NumCompte);
            Console.Write("\n");
            this.Proprietaire.Afficher();
            this.Solde.Aficher();
        }

        virtual public void DeposerArgent(Devise Montant)
        {
            this.Solde = this.Solde + Montant;
            Operation Opr = new Operation("+", Montant);
            this.ListOpr.Add(Opr);
        }

        virtual public bool RetirerArgent(Devise Montant)
        {
            double n=1;
            if (this is CompteEpargne)
            {
                n = 2;  
            }
            Devise d = new Devise(this.Solde.DeviseCompte(this.Solde, n));
            if (d > Montant) { 
                this.Solde = this.Solde - Montant;
                Operation Opr = new Operation("-", Montant);
                this.ListOpr.Add(Opr);
                return true;
            }

            else return false;
        }

        virtual public bool TransfererArgent(Compte c,Devise Montant)
        {
            if (this.RetirerArgent(Montant))
            {
                c.DeposerArgent(Montant);
                return true;
            }
            else return false;
        }

        public Devise InteretSolde(double taux)
        {
            Devise d = new Devise(taux / 100);
            return this.Solde * d;

        }

        public static bool operator==(Compte d1,Compte d2)
        {
            if (d1.NumCompte == d2.NumCompte)
                return true;
            else return false;
        }

        public static bool operator !=(Compte d1, Compte d2)
        {
            return !(d1 == d2);
        }

        public bool CheckSoldeDec(double Value,Devise Montant) {
            Devise d = new Devise(Value);
            return (this.Solde - Montant) > d;    
        }



    }
}

