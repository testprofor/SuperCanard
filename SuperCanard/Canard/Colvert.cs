using SuperCanard.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Canard
{
    public class Colvert : Canard
    {
        public override void Afficher()
        {
            Console.WriteLine("C'est un beau canard vert");
        }
        public Colvert()
        {
            ComportementVol = new VolerAvecDesAiles();
            ComportementCanCan = new Cancan();
        }
    }
}
