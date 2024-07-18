using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_on_the_Loose
{
    using static Player;
    using ConsoleHelpers;
    internal class Chapter2 : Chapter
    {
        public override void Start()
        {
            Console.Clear();
            Helpers.TypeWriter("Kapitel 2: Der Park", 80);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Nachdem du die dunkle Gasse hinter dir gelassen hast, traust du deinen Augen kaum.", 80);
            Thread.Sleep(2000);
            Helpers.TypeWriter("\nEin riesiger Park liegt vor dir. Alles scheint still und friedlich, es ist niemand in Sicht....", 80);
            Thread.Sleep(2000);
            Console.Clear();
            Helpers.TypeWriter("Direkt vor dir steht ein hoch gewachsener Baum, er scheint sehr alt zu sein.", 80);
            Thread.Sleep(2000);
            Helpers.TypeWriter("\nPlötzlich stürzt eine große graue Eule mit gefährlichen Augen aus dem Baum auf dich herab!", 80);
            Thread.Sleep(2000);
            Helpers.TypeWriter("\nDu erschrickst und flüchtest in letzter Sekunde in den nächstgelegenen Busch.\nHier bist du erstmal in Sicherheit...", 80);
            Thread.Sleep(2000);
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
                Console.WriteLine("4. Im Busch bleiben");
                Console.WriteLine("Deine Wahl: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Helpers.TypeWriter("Du stellst dich auf die Hinterbeine und streckst vorsichtig den Kopf aus dem Busch,\num zu sehen, ob die Eule noch da ist.", 80);
                        Thread.Sleep(2000);
                        EventsChapter2.Chapter2Owl();
                        inChapter2 = false; //Chapter beenden
                        //Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                        //Console.ReadKey();
                        //Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Helpers.TypeWriter("Glücklicherweise (für dich) hat ein Vögelchen sein Nest in den Busch gebaut, in dem du dich gerade befindest.", 80);
                        Thread.Sleep(2000);
                        Helpers.TypeWriter("\nDer arme Vogel schläft tief und fest, er hat keine Chance...", 80);
                        Thread.Sleep(2000);
                        Helpers.TypeWriter("\nYummi!", 80);
                        Thread.Sleep(2000);
                        CurrentPlayer.Eat(40);
                        Player.CurrentPlayer.GetStatusInfo();
                        Thread.Sleep(2000);
                        Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Helpers.TypeWriter("Du machst ein Nickerchen und träumst von bunten Filzbällen...", 80);
                        Thread.Sleep(3000);
                        CurrentPlayer.Sleep(40);
                        CurrentPlayer.IncreaseHunger(15);
                        Player.CurrentPlayer.GetStatusInfo();
                        Thread.Sleep(2000);
                        Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Helpers.TypeWriter("Du beschließt vorerst im Busch in Sicherheit zu bleiben,\nwo dich die Eule nicht finden kann.", 80);
                        Thread.Sleep(2000);
                        Helpers.TypeWriter("Plötzlich hörst du ein Rascheln hinter dir...", 80);
                        EventsChapter2.Chapter2Rabbit();
                        inChapter2 = false; //Chapter beenden
                        //Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                        //Console.ReadKey();
                        //Console.Clear();
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
