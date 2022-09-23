using SuperCanard.Canard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard
{
    public class Chasseur
    {
        private static Chasseur? _chasseur;
        public void Tirer(IAnimal a)
        {
            Console.WriteLine("Je tire");
            a.Déplacer();
            a.Crier();
        }

        private Chasseur()
        {

        }

        public static Chasseur GetInstance()
        {
            //    if (_chasseur is null)
            //    {
            //        _chasseur = new Chasseur();
            //    }
            //    return _chasseur;
            //

            return _chasseur ??= new Chasseur();
        }
    }
}
