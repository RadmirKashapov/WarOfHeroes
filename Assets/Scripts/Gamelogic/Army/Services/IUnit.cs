using System;
using System.Collections;

namespace Assets.Scripts.Gamelogic.Interfaces
{
    public interface IUnit: ICloneable
    {
        int Cost { get; } // "стоимость" создания
        int Hp { get; set; } // оставшаяся жизнь
        int Ad { get; set; } // сила атаки
        int Df { get; set; } // уровень защиты
        void TakeDamage(int ad);
    }
}
