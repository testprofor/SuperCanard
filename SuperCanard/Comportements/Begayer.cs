using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Comportements
{
    public class Begayer : IComportementCancan
    {
        public IComportementCancan Cancan { get; set; }
        public void Cancaner()
        {
            Console.WriteLine("Oups je bagaye");
            Cancan.Cancaner();
            Cancan.Cancaner();
        }
        public Begayer(IComportementCancan cancan)
        {
            this.Cancan = cancan;
        }
    }
}
