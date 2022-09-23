using SuperCanard.Canard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Factory
{
    public interface IFactoryCanard
    {
        public ICanard GetColvert();
        public ICanard GetMandarin();
        public ICanard GetCanardEnPlastique();
        public ICanard GetLeurre();
    }
}
