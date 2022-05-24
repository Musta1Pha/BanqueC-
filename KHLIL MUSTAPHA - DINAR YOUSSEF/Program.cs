using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHLIL_MUSTAPHA___DINAR_YOUSSEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cl = new Client("Azerty", "Qwerty", "A");
            Devise d = new Devise(100);
            Compte c = new Compte(cl, d);

           // c.DeposerArgent(d);
            c.print();
            Console.Write("\n\n");

            Devise d2 = new Devise(400);
            CompteCourant cc = new CompteCourant(cl, d2, 50);
            cc.RetirerArgent(d);
            cc.print();

            Console.Write("\n\n");

            Devise d3 = new Devise(300);
            CompteEpargne Ce = new CompteEpargne(cl, d3,10);
            Ce.print();
            
            Ce.RetirerArgent(d);

            Console.Write("\n");

            Ce.print();
            


            Console.ReadKey();
        }
    }
}
