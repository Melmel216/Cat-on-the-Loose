using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_on_the_Loose
{
    public class Player
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Hunger { get; set; }
        public int Fatigue { get; set; }


        public Player(string name, string gender, int health, int damage, int hunger, int fatigue)
        {
            Name = name;
            Gender = gender;
            Health = health;
            Damage = damage;
            Hunger = hunger;
            Fatigue = fatigue;
        }

        public static Player CurrentPlayer = new Player("", "", 200, 10, 0, 0);

        public static string ChooseGender()
        {
            while (true)
            {
                Console.WriteLine("Bist du eine Katze oder ein Kater?");
                Console.WriteLine("1. Katze");
                Console.WriteLine("2. Kater");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string gender = "Katze";
                        return gender;
                    case "2":
                        gender = "Kater";
                        return gender;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Bitte versuche es erneut.");
                        break;
                }
            }
        }

        public static string GetName() 
        {
            Console.WriteLine("\nBitte gib deinen Namen ein:");
            string name = Console.ReadLine();
            return name;
        }

        public void GetStatusInfo()
        {
            Console.WriteLine("Gesundheit: (" + CurrentPlayer.Health + "/200) | " + "Hunger: (" + CurrentPlayer.Hunger + "/100) | " + "Müdigkeit: (" + CurrentPlayer.Fatigue + "/100)");
        }

        public void Eat(int menge)
        {
            Hunger -= menge;
            if (Hunger < 0)
            {
                Hunger = 0;
            }
            Console.WriteLine($"Nach dem Essen beträgt dein Hunger nun {Hunger}/100");
        }

        public void Sleep(int menge)
        {
            Fatigue -= menge;
            if (Fatigue < 0)
            {
                Fatigue = 0;
            }
            Console.WriteLine($"Nach dem Nickerchen beträgt deine Müdigkeit nun {Fatigue}/100");
        }

        public void IncreaseHunger(int menge)
        {
            Hunger += menge;
            if (Hunger > 100)
            {
                Hunger = 100;
            }
            Console.WriteLine($"Dein Hunger hat zugenommen, er liegt nun bei {Hunger}/100");
        }

        public void IncreaseFatigue(int menge)
        {
            Fatigue += menge;
            if (Fatigue > 100)
            {
                Fatigue = 100;
            }
            Console.WriteLine($"Deine Müdigkeit hat zugenommen, sie liegt nun bei {Fatigue}/100");
        }

        public void ReduceHealth(int damage)
        {
            CurrentPlayer.Health -= damage;
            if (CurrentPlayer.Health < 0)
            {
                CurrentPlayer.Health = 0;
            }
            Console.WriteLine($"Deine Gesundheit ist gesunken, sie liegt nun bei {Health}/200");
        }

        public static void GameOver(StateOfGame gameState, bool isPlaying)
        {
            Console.Clear();
            Console.WriteLine("Du hast zu viel Schaden erlitten, deine Gesundheit ist bei 0. Game Over!");

            Console.WriteLine("Möchtest du das Spiel von vorn beginnen? (ja/nein)");
            string input = Console.ReadLine().ToLower();
            if (input != "ja")
            {
                isPlaying = false;
            }
            else
            {
                gameState.Chapter1Done = false;
                gameState.Chapter2Done = false;
                //....
                Console.Clear();
            }
        }
    }
}
