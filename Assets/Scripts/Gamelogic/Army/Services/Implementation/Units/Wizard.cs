using Assets.Scripts.Gamelogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Gamelogic.Units
{
    class Wizard : IUnit, ICloneable
    {
        public int Cost { get; }

        public int Hp { get; set; }
        public int Ad { get; set; }
        public int Df { get; set; }

        public Wizard(int cost, int hp, int ad, int df)
        {
            this.Cost = cost;
            this.Hp = hp;
            this.Ad = ad;
            this.Df = df;
        }
        public Wizard(Wizard wizard)
        {
            this.Cost = wizard.Cost;
            this.Hp = wizard.Hp;
            this.Ad = wizard.Ad;
            this.Df = wizard.Df;
        }
        public object Clone()
        {
            return new Wizard(this);
        }

        public void TakeDamage(int ad)
        {
            throw new NotImplementedException();
        }
    }
}
