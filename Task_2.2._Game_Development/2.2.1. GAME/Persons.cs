using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1.GAME
{
    public abstract class Persons
    {
        public int HealthOfSomethingAlive { get; set; } = 100;

        private int SpeedOfSomethingAlive;

        public int Speed
        {
            get => SpeedOfSomethingAlive;

            set
            {
                if (Speed > 0 && Speed <= 100)
                {
                    SpeedOfSomethingAlive = Speed;
                }
            }
        }

        private int DamageOfSomethingAlive;

        public int Damage
        {
            get => DamageOfSomethingAlive;

            set
            {
                if (Damage > 0 && Damage <= 50)
                {
                    DamageOfSomethingAlive = Damage;
                }
            }
        }

        public Persons(int Damage, int Speed)
        {
            DamageOfSomethingAlive = Damage;
            SpeedOfSomethingAlive = Speed;
        }

        public abstract int ToGiveDamage();

        public abstract int GetHealth();
    }
}
