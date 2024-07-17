using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleHelpers;

namespace Cat_on_the_Loose
{
    internal class EventsChapter2
    {
        public static void Chapter2Owl()
        {
            Helpers.TypeWriter("Im ersten Moment kannst du nichts erkennen, der Park ist dunkel und die Eule scheint nicht mehr da zu sein...", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Da!", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Du entdeckst die Eule, sie steht gut 2 Meter vom Busch entfernt und hat dich fest im Blick.", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Ihr starrt euch für einen unendlich langen Moment in die Augen.", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Die Eule unterbricht die gespannte Stille:", 70);
            Helpers.TypeWriter("\"Hallo, du scheinst, dich verlaufen zu haben?\"", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Du bist verwundert, die Eule spricht!\nUnd sie scheint sogar ganz freundlich zu sein.", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Die Eule weiter:\"Hab keine Angst, ich beobachte dich schon eine ganze Weile und kann dir helfen. Ich weiß, wie du nach Hause kommst.\"", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Du bist misstrauisch und wartest ab..", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Eule: \"Warum so zögerlich? Ich erkläre es dir, also....\"", 70);
            Thread.Sleep(3000);
            Helpers.TypeWriter("Nachdem die Eule zuende gesprochen hat, bist du froh,\ndass du dich getraut hast, aus dem Busch zu schauen.\n\nDu weißt jetzt, wie du nach Hause kommst und folgst den Hinweisen der Eule...", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Es dauert nicht lange, bis du dein Zuhause in der Ferne erkennst!\nNur noch wenige Meter...", 70);
            Helpers.TypeWriter("Geschafft!\nDu hast dein Zuhause erreicht und schlüpfst erleichtert durch die vertraute Katzenklappe hinein in Sicherheit!", 70);
            Thread.Sleep(2000);
            //Player.CurrentPlayer.ReduceHealth(50);
            //Player.CurrentPlayer.IncreaseHunger(20);
            //Player.CurrentPlayer.IncreaseFatigue(30);
            //Player.CurrentPlayer.GetStatusInfo();
            //Thread.Sleep(2000);
            Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Chapter2Rabbit()
        {
            Helpers.TypeWriter("Du drehst dich um und siehst, wie ein Hase zu dir in den Busch kriecht!", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Du machst einen Buckel und bringst dich in Angriffsstellung!", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Ihr starrt euch für einen unendlich langen Moment in die Augen.", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Der Hase unterbricht die gespannte Stille:", 70);
            Helpers.TypeWriter("\"Hallo, hast du dich verlaufen?\"\n\"Ich kann dir helfen!\"", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Du bist verwundert, der Hase spricht!", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Der Hase weiter:\"Ganz ruhig, wenn du mich nicht angreifst, kann ich dir den Weg zu deinem Zuhause zeigen.\"", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Du bist misstrauisch und wartest ab..", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Hase: \"Warum so zögerlich? Ich zeig es dir, komm mit!\"", 70);
            Thread.Sleep(3000);
            Helpers.TypeWriter("Der Hase führt dich auf einem sicheren Weg an der immernoch lauernden Eule vorbei,\naus dem Park hinaus und eine lange Straße hinunter...", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Plötzlich fällst du in ein tiefes Loch!", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Alles um dich herum wird schwarz und du fällst in Ohnmacht...", 70);
            Thread.Sleep(2000);
            Helpers.TypeWriter("Als du zu dir kommst, stellst du fest,\ndass du in deinem Lieblings-Körbchen liegst.\nUm dich herum liegen alle deine Spielsachen, du bist zuhause!\nEs war zum Glück alles nur ein furchtbarer Traum.", 70);
            Thread.Sleep(2000);
            //Player.CurrentPlayer.ReduceHealth(50);
            //Player.CurrentPlayer.IncreaseHunger(20);
            //Player.CurrentPlayer.IncreaseFatigue(30);
            //Player.CurrentPlayer.GetStatusInfo();
            //Thread.Sleep(2000);
            Console.WriteLine("\nDrücke <Enter> um fortzufahren.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
