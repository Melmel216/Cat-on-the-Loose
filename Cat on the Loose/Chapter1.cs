using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Cat_on_the_Loose
{
    using static Player;
    using ConsoleHelpers;

    internal class Chapter1 : Chapter
    {
        public override void Start()
        {
            Console.Clear();
            Helpers.TypeWriter("Kapitel 1: Das Erwachen", 70);
            Thread.Sleep(3000);
            Helpers.TypeWriter("Du öffnest deine Augen und findest dich in einer dunklen, engen Gasse wieder.", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Du kannst dich nicht mehr erinnern, wie du hierher gekommen bist.\nDu weißt nur, dass irgendwo ein schönes, warmes und sicheres Zuhause auf dich wartet.", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Dein Ziel ist es, so schnell wie möglich dorthin zurück zu gelangen.", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Es ist bitter kalt und dir ist bewusst, dass du bald etwas zu essen brauchen wirst.", 70);
            Thread.Sleep(2000);
            Console.WriteLine("\n\n\nTipp: Behalte deine Gesundheit, Hunger und Müdigkeit immer im Blick!\n\nUm deinen Hunger zu stillen, suche etwas zu essen.\nUm deine Müdigkeit zu reduzieren, halte ein Nickerchen.\nÜberall in der Spielwelt kannst du schmackhafte CatDrinks finden, die Gesundheit wiederherstellen.\n\nWenn entweder deine Gesundheit bei 0 ist,\noder Hunger oder Müdigkeit bei 100 sind,\nwirst du ohnmächtig und das Spiel ist vorbei.");
            Thread.Sleep(2000);
            Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
            Console.ReadKey();
            Console.Clear();

            bool inChapter1 = true;

            while (inChapter1)
            {
                Player.CurrentPlayer.GetStatusInfo();
                Console.WriteLine();
                Helpers.TypeWriter("Die Gasse sieht ziemlich gruselig aus...", 70);
                Thread.Sleep(2000);
                Console.WriteLine("\nWas möchtest du tun?\n");
                Console.WriteLine("1. Die Umgebung untersuchen");
                Console.WriteLine("2. Nach Nahrung suchen");
                Console.WriteLine("3. Ein Nickerchen machen");
                Console.WriteLine("4. Einen Ausweg aus der Gasse suchen.");
                Console.WriteLine("Deine Wahl: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Helpers.TypeWriter("Du untersuchst die Umgebung und siehst eine Gruppe von mutierten Riesen-Ratten, die den Weg versperren.",  70);
                        Thread.Sleep(2000);
                        EventsChapter1.Chapter1Rats();
                        inChapter1 = false; //Chapter beenden
                        //Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                        //Console.ReadKey();
                        //Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Zum Glück gibt es in der Gasse genug Mülltonnen, in denen du bestimmt etwas zu essen findest.\nDu durchwühlst die erste Tonne und findest eine geöffnete, noch halbvolle Dose Thunfisch.\nYummi!");
                        CurrentPlayer.Eat(20);
                        Player.CurrentPlayer.GetStatusInfo();
                        Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Du machst ein Nickerchen und träumst von fliegenden Fischen...");
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
                        Console.WriteLine("Du suchst nach einem Ausweg, jedoch sind auf den ersten Blick nur Mülltonnen und leere Kisten zu sehen.");
                        EventsChapter1.Chapter1Cardboard();
                        inChapter1 = false; //Chapter beenden
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
