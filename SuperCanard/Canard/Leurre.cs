using SuperCanard.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Canard
{
    public class Leurre : Canard
    {
        public Leurre()
        {
            ComportementVol = new NePasVoler();
            ComportementCanCan = new CanardMuet();
        }
        public override void Afficher()
        {
            Console.WriteLine("C'est un canard pas comme les autres");
        }
    }
}
