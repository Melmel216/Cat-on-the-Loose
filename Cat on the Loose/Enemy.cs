using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_on_the_Loose
{
    internal class Enemy
    {
        public int Health { get; set; }
        public int Damage { get; set; }

        public Enemy(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }

        public static Enemy LittleRat = new Enemy(30, 5);

        public static Enemy MediumRat = new Enemy(50, 10);

        public static Enemy BigRat = new Enemy(70, 15);


        public static Enemy AngryCat = new Enemy(100, 10);
    }
}
