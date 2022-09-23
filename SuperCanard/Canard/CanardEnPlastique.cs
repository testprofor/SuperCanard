using SuperCanard.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Canard
{
    public class CanardEnPlastique : Canard
    {
        public CanardEnPlastique()
        {
            ComportementVol = new NePasVoler();
            ComportementCanCan = new CanardMuet();
        }
        public override void Afficher()
        {
            Console.WriteLine("Je suis aussi disponible version batman.");
        }
    }
}
