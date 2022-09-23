using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Menu
{
    public class MenuItem : IMenu
    {
       

        public void Execute()
        {
            Method.Invoke();
        }
    }
}
