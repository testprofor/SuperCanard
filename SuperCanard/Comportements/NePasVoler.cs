using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Comportements
{
    public class NePasVoler : IComportementVol
    {
        public void Voler()
        {
            Console.WriteLine("Peux pas voler");
        }
    }
}
