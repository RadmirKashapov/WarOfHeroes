using Assets.Scripts.Gamelogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Gamelogic.Units
{
    class Infantry : IUnit, ICloneable
    {
        public int Cost { get; }

        public int Hp { get; set; }
        public int Ad { get; set; }
        public int Df { get; set; }

        public Infantry(int cost, int hp, int ad, int df)
        {
            this.Cost = Cost;
            this.Hp = Hp;
            this.Ad = Ad;
            this.Df = Df;
        }

        public Infantry(Infantry infantry)
        {
            this.Cost = infantry.Cost;
            this.Hp = infantry.Hp;
            this.Ad = infantry.Ad;
            this.Df = infantry.Df;
        }
        public object Clone()
        {
            return new Infantry(this);
        }

        public void TakeDamage(int ad)
        {
            throw new NotImplementedException();
        }
    }
}
