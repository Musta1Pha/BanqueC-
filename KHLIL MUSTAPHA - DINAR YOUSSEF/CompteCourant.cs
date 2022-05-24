using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHLIL_MUSTAPHA___DINAR_YOUSSEF
{
    class CompteCourant:Compte
    {
        private double Decouvert;

        public CompteCourant(Client prop, Devise Solde,double Decouvert):base(prop,Solde) {
            this.Decouvert = Decouvert;
        }

        override public bool RetirerArgent(Devise Montant) {
            if (this.CheckSoldeDec(this.Decouvert,Montant))
            {
                return base.RetirerArgent(Montant);
            }

            else return false;
        }

    }
}
