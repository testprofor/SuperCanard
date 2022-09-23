using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Menu
{
    public class MenuBase : IMenu
    {
        private List<IMenu> items { get; set; }
        public Action Method { get; set; }
        public char Key { get; set; }
        public string Text { get; set; }


        public void Execute()
        {
            ConsoleKeyInfo choice;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*-------------------------------------------------------------*");
                foreach (IMenu menu in items)
                {
                    Console.WriteLine($"<{menu.Key}> {Text}");
                }
                Console.Write("\nVotre choix :");
                choice = Console.ReadKey();
                Console.WriteLine("*-------------------------------------------------------------*");
            }
            
        }
    }
}
