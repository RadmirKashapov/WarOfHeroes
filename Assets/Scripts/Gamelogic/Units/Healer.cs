using Assets.Scripts.Gamelogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Gamelogic.Units
{
    class Healer : IUnit, ICloneable
    {
        public int Cost { get; }
        public int Hp { get; set; }
        public int Ad { get; set; }
        public int Df { get; set; }

        public Healer(int cost, int hp, int ad, int df)
        {
            this.Cost = Cost;
            this.Hp = Hp;
            this.Ad = Ad;
            this.Df = Df;
        }
        public Healer(Healer healer)
        {
            this.Cost = healer.Cost;
            this.Hp = healer.Hp;
            this.Ad = healer.Ad;
            this.Df = healer.Df;
        }
        public object Clone()
        {
            return new Healer(this);
        }

        public void TakeDamage(int ad)
        {
            throw new NotImplementedException();
        }
    }
}
