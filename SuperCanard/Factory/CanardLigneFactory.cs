using SuperCanard.Canard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Factory
{
     public class CanardLigneFactory : IFactoryCanard
    {
        public ICanard GetCanardEnPlastique()
        {
            return new CanardLigne(new CanardEnPlastique());
        }

        public ICanard GetColvert()
        {
            return new CanardLigne(new Colvert());
        }

        public ICanard GetLeurre()
        {
            return new CanardLigne(new Leurre());
        }

        public ICanard GetMandarin()
        {
            return new CanardLigne(new Mandarin());
        }
    }
}
