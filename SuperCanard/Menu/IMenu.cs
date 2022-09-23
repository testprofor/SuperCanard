using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Menu
{
    public interface IMenu
    {
        public Action Method { get; };
        public char Key { get; }
        public string Text { get; }
        public void Execute();


    }
}
