using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Canard
{
    public class CanardLigne : ICanard
    {
        ICanard _c;

        public CanardLigne(ICanard c)
        {
            _c = c;
        }

        public void Afficher()
        {
            _c.Afficher();
        }

        public void EffectuerCancan()
        {
            Console.WriteLine("___________________");
            _c.EffectuerCancan();
            Console.WriteLine("___________________");
        }

        public void EffectuerVol()
        {
            Console.WriteLine("___________________");
            _c.EffectuerVol();
            Console.WriteLine("___________________");
        }
    }
}
