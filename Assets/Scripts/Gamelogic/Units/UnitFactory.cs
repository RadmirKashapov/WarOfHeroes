using Assets.Scripts.Gamelogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Gamelogic.Units
{
    enum UnitType
    {
        INFANTRY, KNIGHT, HEALER, ARCHER, WIZARD
    }
    class UnitFactory: IUnitFactory
    {
        public IUnit CreateUnit(int maxPrice)
        {
            Random random = new Random();
            var unitTypeNum = random.Next(0, Enum.GetNames(typeof(UnitType)).Length);

            switch (unitTypeNum)
            {
                case (int)UnitType.INFANTRY:

                    break;
            }
                    
        }
    }
}
