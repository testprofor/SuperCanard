using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Comportements
{
    public class Alternant : IComportementCancan
    {
        public IComportementCancan Cancan { get; set; }
        public IComportementCancan Cancan2 { get; set; }
        private bool SwitchCris = true;
        public void Cancaner()
        {
            if (SwitchCris)
            {
                Cancan.Cancaner();
            }
            else
            {
                Cancan2.Cancaner();
            }
            SwitchCris = !SwitchCris;
        }
        public Alternant(IComportementCancan cancan, IComportementCancan cancan2)
        {
            this.Cancan = cancan;
            this.Cancan2 = cancan2;
        }
    }
}
