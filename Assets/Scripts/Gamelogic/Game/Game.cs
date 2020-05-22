using Assets.Scripts.Gamelogic.Interfaces;
using Assets.Scripts.Gamelogic.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Gamelogic.Game
{
    class Game : IGame
    {
        public int Money { get; set; }
        public void CreateArmies()
        {
            var unitFactory = new UnitFactory();



        }
        public void Turn()
        {
            throw new NotImplementedException();
        }

        public void TurnToEnd()
        {
            throw new NotImplementedException();
        }
    }
}
