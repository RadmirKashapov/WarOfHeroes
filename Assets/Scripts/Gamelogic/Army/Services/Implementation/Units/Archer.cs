using Assets.Scripts.Gamelogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Gamelogic.Units
{
    class Archer : IUnit, ICloneable
    {
        public int Cost { get; }
        public int Hp { get; set; }
        public int Ad { get; set; }
        public int Df { get; set; }

        public Archer(int cost, int hp, int ad, int df)
        {
            this.Cost = cost;
            this.Hp = hp;
            this.Ad = ad;
            this.Df = df;
        }

        public Archer(Archer archer)
        {
            this.Cost = archer.Cost;
            this.Hp = archer.Hp;
            this.Ad = archer.Ad;
            this.Df = archer.Df;
        }
        public object Clone()
        {
            return new Archer(this);
        }

        public void TakeDamage(int ad)
        {
            throw new NotImplementedException();
        }
    }
}
