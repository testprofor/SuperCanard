using SuperCanard.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Canard
{
    public class Mandarin : Canard
    {
        public Mandarin()
        {
            ComportementVol = new VolerAvecDesAiles();
            ComportementCanCan = new Coincoin();
        }
        public override void Afficher()
        {
            Console.WriteLine("C'est le plus beau des canards");
        }
    }
}
