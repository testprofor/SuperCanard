using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Canard
{
    public class CanardAnimal : IAnimal
    {
        public ICanard Canard { get; set; }

        public void Crier()
        {
            Canard.EffectuerCancan();
        }

        public void Déplacer()
        {
            Canard.EffectuerVol();
        }

        public CanardAnimal(Canard c)
        {
            Canard = c;
        }
    }
}
