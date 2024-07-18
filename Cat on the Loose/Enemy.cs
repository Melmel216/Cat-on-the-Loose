using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleHelpers;

namespace Cat_on_the_Loose
{

    //wird noch nicht verwendet !!

    public class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public Enemy(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public static Enemy CurrentEnemy = new Enemy("", 30, 10);
        //public static Enemy LittleRat = new Enemy("Ratte", 30, 5);

        //public static Enemy MediumRat = new Enemy("mutierte Ratte", 50, 10);

        //public static Enemy BigRat = new Enemy("Riesen-Ratte", 70, 15);

        //public static Enemy AngryCat = new Enemy("Kater", 100, 10);

        public void GetStatusInfoEnemy()
        {
            Console.WriteLine("Gegner Gesundheit: (" + CurrentEnemy.Health + ") |");
        }

        public void ReduceHealthEnemy(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
            //Console.WriteLine($"Die Gesundheit von {CurrentEnemy.Name} ist gesunken!");
            //Player.CurrentPlayer.CheckPlayerState();
            //Enemy.CurrentEnemy.CheckEnemyState();
        }
        public void AttackPlayer(Player CurrentPlayer)
        {
            CurrentPlayer.ReduceHealthPlayer(CurrentEnemy.Damage);
            Console.WriteLine($"{CurrentEnemy.Name} greift dich an und verursacht {CurrentEnemy.Damage} Schaden. Deine Gesundheit ist gesunken, sie liegt nun bei {CurrentPlayer.Health}/200");
            Thread.Sleep(2000);
            Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
            Console.ReadKey();
            Player.CurrentPlayer.CheckPlayerState();
        }

        public void CheckEnemyState()
        {
            if (Health == 0)
            {
                EnemyDefeated();
            }
        }

        public void EnemyDefeated()
        {
            Console.WriteLine($"{Name} wurde besiegt!");
        }
    }

    

}
