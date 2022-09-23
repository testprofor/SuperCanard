using SuperCanard.Canard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Factory
{
    public class CanardBavardFactory : IFactoryCanard
    {
        public ICanard GetCanardEnPlastique()
        {
            return new CanardBavard(new CanardEnPlastique());
        }

        public ICanard GetColvert()
        {
            return new CanardBavard(new Colvert());
        }

        public ICanard GetLeurre()
        {
            return new CanardBavard(new Leurre());
        }

        public ICanard GetMandarin()
        {
            return new CanardBavard(new Mandarin());
        }
    }
}
