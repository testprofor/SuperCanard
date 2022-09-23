using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Canard
{
    public class CanardBavard : ICanard
    {
        ICanard _c;

        public CanardBavard(ICanard c)
        {
            _c = c;
        }

        public void Afficher()
        {
            _c.Afficher();
        }

        public void EffectuerCancan()
        {
            Console.Write("Je suis un :");
            _c.Afficher();
            Console.Write("Mon cris est :");
            _c.EffectuerCancan();
        }

        public void EffectuerVol()
        {
            Console.Write("Je suis un :");
            _c.Afficher();
            Console.Write("Et je vole de cette manière :");
            _c.EffectuerCancan();
        }
    }
}
