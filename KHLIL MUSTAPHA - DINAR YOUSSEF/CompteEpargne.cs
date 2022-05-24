using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHLIL_MUSTAPHA___DINAR_YOUSSEF
{
    class CompteEpargne:Compte
    {
        private double TauxInteret;

            public CompteEpargne(Client Prop,Devise Solde,double TauxInteret) : base(Prop, Solde)
        {
            this.TauxInteret = (TauxInteret >= 0 && TauxInteret <= 100) ? TauxInteret : 0;
        }

        public override void print()
        {
             base.print();
            Console.Write("Taux Interet : " + this.TauxInteret);
        }

        public override bool RetirerArgent(Devise Montant)
        {
            return base.RetirerArgent(Montant + InteretSolde(this.TauxInteret));
        }

        public void CalculInteret(double taux)
        {
            this.InteretSolde(taux);
        }




    }
}
