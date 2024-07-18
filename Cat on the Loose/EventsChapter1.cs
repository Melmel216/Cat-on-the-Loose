using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleHelpers;

namespace Cat_on_the_Loose
{
    
    internal class EventsChapter1
    {
        public static void Chapter1Rats()
        {
            Thread.Sleep(2000);
            Helpers.TypeWriter("Schnell, sonst entdecken sie dich!", 50);
            Thread.Sleep(2000);
            Console.WriteLine("\nWas möchtest du tun?\n");
            Console.WriteLine("1. Kämpfen");
            Console.WriteLine("2. Versuchen vorbei zu schleichen");
            Console.WriteLine("Deine Wahl: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Helpers.TypeWriter("Du gehst mutig auf die Ratten zu...", 50);
                    Thread.Sleep(2000);
                    Helpers.TypeWriter("Es kommt zum Kampf!", 50);
                    Thread.Sleep(2000);
                    Helpers.TypeWriter("\nDie Ratten stürzen sich auf dich!", 50);
                    Thread.Sleep(2000);
                    Console.Clear();

                    Enemy.CurrentEnemy.Name = "Eine Schar Ratten";
                    Fight.Fighting(Player.CurrentPlayer, Enemy.CurrentEnemy);


                    Console.Clear();
                    Helpers.TypeWriter("\nObwohl die Ratten sehr flink und in Überzahl waren, konntest du sie besiegen.\nDu hast allerdings ein paar Hiebe eingefangen und dadurch Gesundheit eingebüßt.\nHunger und Müdigkeit sind gestiegen.", 50);
                    Thread.Sleep(2000);
                    //Player.CurrentPlayer.ReduceHealth(30);

                    Player.CurrentPlayer.IncreaseHunger(20);
                    Player.CurrentPlayer.IncreaseFatigue(20);
                    Player.CurrentPlayer.GetStatusInfo();
                    Thread.Sleep(2000);
                    Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                    Console.ReadKey();
                    Console.Clear();
                    Chapter1Cardboard();
                    Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    Helpers.TypeWriter("Obwohl die Ratten sehr aufmerksam sind, gelingt es dir, dich unbemerkt an Ihnen vorbei zu schleichen.\n\nDas war knapp!", 50);
                    Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                    Console.ReadKey();
                    Console.Clear();
                    Helpers.TypeWriter("Hoppla! Was war das?", 50);
                    Helpers.TypeWriter("Du bist über etwas gestolpert, das sich angefühlt wie....\n\neine Dose CATDRINK!\nYei!", 50);
                    Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                    Console.ReadKey();
                    Console.Clear();
                    Helpers.TypeWriter("Du schleichst dich weiter auf leisen Sohlen davon....", 50);
                    Thread.Sleep(2000);
                    Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                    Console.ReadKey();
                    Chapter1Cardboard();
                    Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ungültige Eingabe. Bitte versuche es erneut.");
                    Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }

        public static void Chapter1Cardboard()
        {
            Console.Clear();
            Helpers.TypeWriter("Du gehst weiter und entdeckst einen Karton, der an die Mauer gelehnt ist.", 50);
            Thread.Sleep(2000);
            Helpers.TypeWriter("\nDu beschnupperst den Karton und hebst ihn mit einer Pfote vorsichtig an...", 50);
            Thread.Sleep(2000);
            Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
            Console.ReadKey();
            Console.Clear();
            Helpers.TypeWriter("Ein mopsiger Kater hat es sich unter dem Karton gemütlich gemacht.\n\nEr starrt dich mit großen Augen an und fühlt sich gestört.", 50);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Er greift dich an!", 50);
            Thread.Sleep(2000);
            Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
            Console.ReadKey();
            Console.Clear();
            Helpers.TypeWriter("Es kommt zum Kampf!", 50);
            Thread.Sleep(2000);
            Console.Clear();
            //KAMPF 
            Enemy.CurrentEnemy.Name = "Böser Kater";
            Enemy.CurrentEnemy.Health = 50;
            Enemy.CurrentEnemy.Damage = 20;
            Fight.Fighting(Player.CurrentPlayer, Enemy.CurrentEnemy);

            Console.Clear();
            Helpers.TypeWriter("Du hast es geschafft, den Kater in die Flucht zu schlagen!\nDu hast jedoch Einiges abbekommen und dadurch Gesundheit eingebüßt.\nHunger und Müdigkeit sind gestiegen.", 50);
            Thread.Sleep(2000);
            Player.CurrentPlayer.IncreaseHunger(20);
            Player.CurrentPlayer.IncreaseFatigue(30);
            Player.CurrentPlayer.GetStatusInfo();
            Thread.Sleep(2000);
            Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
            Console.ReadKey(); //KAMPF ENDE
            Console.Clear();
            Helpers.TypeWriter("Du entdeckst hinter dem Karton eine Öffnung in der Mauer und schlüpfst hindurch...", 50);
            Thread.Sleep(2000);
        }
    }
}
