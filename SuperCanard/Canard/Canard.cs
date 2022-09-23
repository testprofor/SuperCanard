using SuperCanard.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Canard
{
    public abstract class Canard : ICanard
    {
        public IComportementVol ComportementVol { get; set; }
        public IComportementCancan ComportementCanCan { get; set; }

        public void Nager()
        {

        }

        public abstract void Afficher();

        public void EffectuerCancan()
        {
            ComportementCanCan.Cancaner();
        }

        public void EffectuerVol()
        {
            ComportementVol.Voler();
        }




    }
}
