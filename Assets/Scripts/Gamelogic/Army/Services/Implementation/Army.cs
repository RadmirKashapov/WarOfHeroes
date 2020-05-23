using Assets.Scripts.Gamelogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Gamelogic.Game
{
    class Army: IArmy
    {
        protected int Money { get; set; }

        public Army(int money)
        {
            Money = money;
        }

        public void CreateArmy(IUnitFactory factory)
        {
            while (this.Money > 0)
            {
                var unit = factory.CreateUnit(this.Money);
                this.Money -= unit.Cost;
            }
        }
    }
}
