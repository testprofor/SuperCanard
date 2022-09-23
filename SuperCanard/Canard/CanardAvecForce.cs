using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Canard
{
    public class CanardAvecForce : ICanard
    {
        private ICanard _c;
        private int _Force;
        public void Afficher()
        {
            _c.Afficher();
        }

        public CanardAvecForce(ICanard c)
        {
            _c = c;
            _Force = 10;
        }

        public void EffectuerCancan()
        {
            if (_Force > 0)
            {
                _c.EffectuerCancan();
                _Force--;
            }
            else
            {
                Console.WriteLine("Plus de force");
            }
        }

        public void EffectuerVol()
        {
            if (_Force > 1)
            {
                _c.EffectuerVol();
                _Force -= 2;
            }
            else
            {
                Console.WriteLine("Plus de force");
            }
        }
        public void Manger()
        {
            _Force += 5;
        }
    }
}
