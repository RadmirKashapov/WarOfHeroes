using System.Collections;

namespace Assets.Scripts.Interfaces
{
    public interface IUnit
    {
        public int Cost { get; } // "стоимость" создания
        public int Hp { get; set; } // оставшаяся жизнь
        public int Ad { get; set; } // сила атаки
        public int Df { get; set; } // уровень защиты
        public void TakeDamage(int ad);
    }
}
