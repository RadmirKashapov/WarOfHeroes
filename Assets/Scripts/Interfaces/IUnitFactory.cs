﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Interfaces
{
    interface IUnitFactory
    {
        IUnit CreateUnit(int maxPrice);
    }
}
