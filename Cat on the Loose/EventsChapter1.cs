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
            Console.WriteLine("\nWas möchtest du tun?\n");
            Console.WriteLine("1. Kämpfen");
            Console.WriteLine("2. Versuchen vorbei zu schleichen");
            Console.WriteLine("Deine Wahl: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Helpers.TypeWriter("Es kommt zum Kampf!", 70);
                    Thread.Sleep(2000);
                    Helpers.TypeWriter("\nDie Ratten stürzen sich auf dich!", 70);
                    Thread.Sleep(2000);
                    Helpers.TypeWriter("\nObwohl die Ratten sehr flink und in Überzahl waren, konntest du sie besiegen.\nDu hast allerdings ein paar Hiebe eingefangen und dadurch Gesundheit eingebüßt.\nHunger und Müdigkeit sind gestiegen.", 70);
                    Thread.Sleep(2000);
                    Player.CurrentPlayer.ReduceHealth(100);
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
                    Helpers.TypeWriter("Obwohl die Ratten sehr aufmerksam sind, gelingt es dir, dich unbemerkt an Ihnen vorbei zu schleichen.\n\nDas war knapp!", 70);
                    Thread.Sleep(3000);
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
            Console.WriteLine("Du gehst weiter und entdeckst einen Karton, der an die Mauer gelehnt ist.");
            Thread.Sleep(3000);
            Console.WriteLine("\nDu untersuchst den Karton...");
            Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ein mopsiger Kater hat es sich unter dem Karton gemütlich gemacht.\nEr starrt dich mit großen Augen an und fühlt sich gestört.");
            Thread.Sleep(3000);
            Console.WriteLine("\nEr greift dich an!");
            Thread.Sleep(2000);
            Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Es kommt zum Kampf!");
            Thread.Sleep(3000);
            Console.WriteLine("Ihr teilt beide ordentlich aus");
            Thread.Sleep(3000);
            Console.WriteLine("Du hast es geschafft, den Kater in die Flucht zu schlagen!\nDu hast allerdings ein paar Hiebe eingefangen und dadurch Gesundheit eingebüßt. Hunger und Müdigkeit sind gestiegen.");
            Thread.Sleep(2000);
            Player.CurrentPlayer.ReduceHealth(100);
            Player.CurrentPlayer.IncreaseHunger(30);
            Player.CurrentPlayer.IncreaseFatigue(40);
            Player.CurrentPlayer.GetStatusInfo();
            Thread.Sleep(2000);
            Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Du entdeckst hinter dem Karton eine Öffnung in der Mauer und schlüpfst hindurch.");
        }
    }
}
