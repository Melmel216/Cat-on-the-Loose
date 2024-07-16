using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_on_the_Loose
{
    using static Player;
    internal class Chapter2 : Chapter
    {
        public override void Start()
        {
            Console.Clear();
            Console.WriteLine("Kapitel 2: Der Park");
            Thread.Sleep(3000);
            Console.WriteLine("Nachdem du die dunkle Gasse hinter dir gelassen hast, traust du deinen Augen kaum.");
            Thread.Sleep(3000);
            Console.WriteLine("\nEin riesiger Park liegt vor dir. Alles scheint still und friedlich, es ist niemand in Sicht....");
            Thread.Sleep(3000);
            Console.WriteLine("\nDirekt vor dir steht ein hoch gewachsener Baum, er scheint sehr alt zu sein.");
            Thread.Sleep(4000);
            Console.WriteLine("\nPlötzlich stürzt eine große graue Eule mit gefährlichen Augen aus dem Baum auf dich herab!");
            Thread.Sleep(4000);
            Console.WriteLine("\nDu erschrickst und flüchtest in letzter Sekunde in den nächstgelegenen Busch.\nHier bist du erstmal in Sicherheit...");
            Thread.Sleep(3000);
            Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
            Console.ReadKey();
            Console.Clear();

            bool inChapter2 = true;

            while (inChapter2)
            {
                Player.CurrentPlayer.GetStatusInfo();
                Console.WriteLine();
                Console.WriteLine("\nWas möchtest du tun?\n");
                Console.WriteLine("1. Vorsichtig prüfen, ob die Luft rein ist");
                Console.WriteLine("2. Nach Nahrung suchen");
                Console.WriteLine("3. Ein Nickerchen machen");
                Console.WriteLine("4. ...");  //eventuell weglassen
                Console.WriteLine("Deine Wahl: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Du stellst dich auf die Hinterbeine und streckst vorsichtig den Kopf aus dem Busch, um zu sehen, ob die Eule noch da ist.");
                        Thread.Sleep(3000);
                        EventsChapter2.Chapter2Owl();
                        inChapter2 = false; //Chapter beenden
                        Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Glücklicherweise (für dich) hat ein Vögelchen sein Nest in den Busch gebaut, in dem du dich gerade befindest.");
                        Thread.Sleep(3000);
                        Console.WriteLine("\nDer arme Vogel schläft tief und fest, er hat keine Chance...");
                        Thread.Sleep(3000);
                        Console.WriteLine("\nYummi!");
                        Thread.Sleep(3000);
                        CurrentPlayer.Eat(30);
                        Player.CurrentPlayer.GetStatusInfo();
                        Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Du machst ein Nickerchen und träumst von Filzbällen...");
                        Thread.Sleep(4000);
                        CurrentPlayer.Sleep(30);
                        CurrentPlayer.IncreaseHunger(20);
                        Player.CurrentPlayer.GetStatusInfo();
                        Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("");
                        //EventsChapter1.Chapter1Cardboard();
                        inChapter2 = false; //Chapter beenden
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
        }
    }
}
