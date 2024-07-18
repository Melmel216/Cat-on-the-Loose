using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_on_the_Loose
{
    public class Fight
    {
        public static void Fighting(Player CurrentPlayer, Enemy CurrentEnemy)
        {
            Console.WriteLine($"Der Kampf zwischen dir und {CurrentEnemy.Name} beginnt!");
            Thread.Sleep(1000);
            Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
            Console.ReadKey();

            while (CurrentPlayer.Health > 0 && CurrentEnemy.Health > 0)
            {
                Console.Clear();
                Player.CurrentPlayer.GetStatusInfo();
                Console.WriteLine("Was möchtest du tun?");
                Console.WriteLine("1. Angreifen");
                Console.WriteLine("2. CATDRINK schlabbern");
                Console.WriteLine("3. Versuchen, zu fliehen");
                Console.WriteLine("Deine Wahl:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        CurrentPlayer.AttackEnemy(CurrentEnemy);
                        Thread.Sleep(1000);
                        Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        CurrentPlayer.Heal(30);
                        Thread.Sleep(1000);
                        Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Nice Try!\nDu hast keine Chance zu entkommen!");
                        Thread.Sleep(1000);
                        Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ungültige Wahl. Bitte versuche es erneut.");
                        Thread.Sleep(1000);
                        Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                        Console.ReadKey();
                        break;
                }

                if (CurrentEnemy.Health > 0)
                {
                    Console.Clear();
                    Console.WriteLine($"{CurrentEnemy.Name} greift an!");
                    Thread.Sleep(1000);
                    Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                    Console.ReadKey();
                    Console.Clear();
                    CurrentEnemy.AttackPlayer(CurrentPlayer);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Du hast {CurrentEnemy.Name} besiegt!");
                    Thread.Sleep(1000);
                    Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                    Console.ReadKey();
                    return;
                }

                if (CurrentPlayer.Health == 0)
                {
                    Console.WriteLine("Du wurdest im Kampf besiegt. Game Over!");
                    Thread.Sleep(3000);
                    Console.WriteLine("\nDrücke <Enter> um das Spiel zu verlassen.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
    }
}
