using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHLIL_MUSTAPHA___DINAR_YOUSSEF
{
    class Client
    {
        private readonly int Numero;
        static int Cpt=0;
        private string Nom;
        private string Prenom;
        private string Adresse;
        List<Compte> ListCompte;
        public Client()
        {
            Numero = ++Cpt;
            this.Nom = "";
            this.Prenom = "";
            this.Adresse = "";
            ListCompte = new List<Compte>();
        }

        public Client(string Nom,string Prenom,string Adresse)
        {
            Numero = ++Cpt;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Adresse = Adresse;
            ListCompte = new List<Compte>();
        }

        public void Affecter(Compte c)
        {
            ListCompte.Add(c);
        }

        public void Supprimer(Compte c1)
        {
            foreach(Compte c in ListCompte)
            {
                if(c == c1)
                {
                    ListCompte.Remove(c1);
                }
            }
        }

        public void Afficher()
        {
            Console.Write("Numero :" + this.Numero + " Nom :" + this.Nom +" Prenom : " + this.Prenom + " Adresse :" + this.Adresse);
            Console.Write("\n");
        }

    }
}
