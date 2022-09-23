using SuperCanard.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCanard.Factory
{
    public class ComportementFactory
    {
        private IComportementCancan? _can;
        private IComportementCancan? _coin;
        private IComportementCancan? _canCan;
        private IComportementCancan? _coinCoin;
        private IComportementCancan? _muet;
        private IComportementCancan? _coinCan;
        private IComportementCancan? _canCoin;
        private IComportementCancan? _canCanCoin;
        public IComportementCancan GetCan()
        {
            return _can ??= new Cancan();
        }

        public IComportementCancan GetCoin()
        {
            return _coin ??= new Coincoin();
        }

        public IComportementCancan GetCanCan()
        {
            return _canCan ??= new Begayer(GetCan());
        }

        public IComportementCancan GetCoinCoin()
        {
            return _coinCoin ??= new Begayer(GetCoin());
        }

        public IComportementCancan GetMuet()
        {
            return _muet ??= new CanardMuet();
        }

        public IComportementCancan GetAltCanCoin()
        {
            return new Alternant(GetCan(), GetCoin());
        }

        public IComportementCancan GetAltCoinCan()
        {
            return new Alternant(GetCoin(), GetCan());
        }

        public IComportementCancan GetCoinCan()
        {
            return _coinCan ??= new Begayer(new Alternant(GetCoin(), GetCan()));
        }

        public IComportementCancan GetCanCoin()
        {
            return _canCoin ??= new Begayer(new Alternant(GetCan(), GetCoin()));
        }

        public IComportementCancan GetCanCanCoin()
        {
            return _canCanCoin ??= new Begayer(new Alternant(new Begayer(GetCan()), GetCoin()));
        }
    }
}
