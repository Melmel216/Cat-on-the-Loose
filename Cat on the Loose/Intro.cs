using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_on_the_Loose
{
    using ConsoleHelpers;
    internal class Intro
    {
        public static void GameStart()
        {
            Console.Clear();
            Player.CurrentPlayer.Name = "";
            Player.CurrentPlayer.Gender = "";
            Player.CurrentPlayer.Health = 200;
            Player.CurrentPlayer.Hunger = 50;
            Player.CurrentPlayer.Fatigue = 50;

            Console.WriteLine("Willkommen zu \"Cat on the Loose\"");
            Thread.Sleep(2000);
            Console.WriteLine();
            Player.CurrentPlayer.Gender = Player.ChooseGender();
            Player.CurrentPlayer.Name = Player.GetName();
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("Du spielst als " + Player.CurrentPlayer.Gender + " namens " + Player.CurrentPlayer.Name + ".");
            Thread.Sleep(2000);
            Console.WriteLine("\nDrücke eine beliebige Taste, um in dein Abenteuer zu starten!");
            Console.ReadKey();
        }
    }
}
