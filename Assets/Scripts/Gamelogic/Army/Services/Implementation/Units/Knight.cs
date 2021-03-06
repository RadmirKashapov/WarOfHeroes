﻿using Assets.Scripts.Gamelogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Gamelogic.Units
{
    class Knight : IUnit, ICloneable
    {
        public int Cost { get; }

        public int Hp { get; set; }
        public int Ad { get; set; }
        public int Df { get; set; }

        public Knight(int cost, int hp, int ad, int df)
        {
            this.Cost = cost;
            this.Hp = hp;
            this.Ad = ad;
            this.Df = df;
        }
        public Knight(Knight knight)
        {
            this.Cost = knight.Cost;
            this.Hp = knight.Hp;
            this.Ad = knight.Ad;
            this.Df = knight.Df;
        }
        public object Clone()
        {
            return new Knight(this);
        }

        public void TakeDamage(int ad)
        {
            throw new NotImplementedException();
        }
    }
}
