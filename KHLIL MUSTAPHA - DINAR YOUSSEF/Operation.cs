using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHLIL_MUSTAPHA___DINAR_YOUSSEF
{
    class Operation
    {
        private readonly int NumOpr;
        static int Cpt=0;
        string Libelle;
        DateTime dateOpr;
        Devise MontantOpr;
        public Operation(string Libelle,Devise MontantOpr)
        {
            this.NumOpr = ++Cpt;
            this.dateOpr = new DateTime();
            this.Libelle = Libelle;
            this.MontantOpr = MontantOpr;
        }

        public override string ToString()
        {
            string s;
            s = this.dateOpr.ToString() + "|" + this.NumOpr + "|" + this.Libelle + this.MontantOpr;
            return s;
         } 



    }
}
