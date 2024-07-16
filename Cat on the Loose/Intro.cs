using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_on_the_Loose
{
    internal class Intro
    {
        public static void GameStart()
        {
            Console.WriteLine("Willkommen zu \"Cat on the Loose\"");
            Player.CurrentPlayer.Gender = Player.ChooseGender();

            Player.CurrentPlayer.Name = Player.GetName();
            Console.Clear();

            Console.WriteLine("Du spielst als " + Player.CurrentPlayer.Gender + " namens " + Player.CurrentPlayer.Name + ".");
            Console.WriteLine("\nDrücke eine beliebige Taste, um in dein Abenteuer zu starten!");
            Console.ReadKey();
        }
    }
}
