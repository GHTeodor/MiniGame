namespace MiniGame.App.HW2;

public static class NewGameAgain
{
    public static bool RepeatGame()
    {
        Console.WriteLine("\n_________________________________________________________________________________");
        Console.WriteLine("\nIf you want to PLAY AGAIN press any number (0,1,2,3,4,5,6,7,8,9), else if you want to end game press any letter\n");
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.D0:
            case ConsoleKey.D1:
            case ConsoleKey.D2:
            case ConsoleKey.D3:
            case ConsoleKey.D4:
            case ConsoleKey.D5:
            case ConsoleKey.D6:
            case ConsoleKey.D7:
            case ConsoleKey.D8:
            case ConsoleKey.D9:
                Console.WriteLine("\n_________________________________________________________________________________");
                Console.WriteLine("New Game");
                return true;
            default:
                Console.WriteLine("\nBye!!!");
                return false;
        }
    }
}