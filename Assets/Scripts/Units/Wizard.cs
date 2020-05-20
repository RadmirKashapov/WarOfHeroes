using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Units
{
    class Wizard : IUnit, ICloneable
    {
        public int Cost => throw new NotImplementedException();

        public int Hp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Ad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Df { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int ad)
        {
            throw new NotImplementedException();
        }
    }
}
