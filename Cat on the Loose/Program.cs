
using System.Transactions;
using Cat_on_the_Loose;
using ConsoleHelpers;

StateOfGame GameState = new StateOfGame();

//Einleitung
Intro.GameStart();

//Programm-Ablauf:
bool isPlaying = true;
while (isPlaying == true && Player.CurrentPlayer.Health >= 0)
{
    if (!GameState.Chapter1Done)
    {
        Chapter1 chapter1 = new Chapter1();
        chapter1.Start();
        GameState.Chapter1Done = true;
    }

    if (GameState.Chapter1Done && !GameState.Chapter2Done)
    {
        Chapter2 chapter2 = new Chapter2();
        chapter2.Start();
        GameState.Chapter2Done = true;
    }
    Helpers.TypeWriter("Gratulation!\nDu hast alle Kapitel geschafft!", 70);
    Thread.Sleep(1000);
    Console.WriteLine("Möchtest du das Spiel beenden? (ja/nein)");
    string input = Console.ReadLine().ToLower();
    if (input == "ja")
    {
        isPlaying = false;
    }
}
//if (Player.CurrentPlayer.Health == 0)
//{
//    Player.GameOver(GameState, isPlaying);
//}
Console.Clear();
Console.WriteLine("Danke für's Spielen! Bis zum nächsten Mal.");
//ENDE
