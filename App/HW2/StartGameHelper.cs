namespace MiniGame.App.HW2;

public static class StartGameHelper
{
    public static bool RepeatGame()
    {
        Console.WriteLine("###################################################################" +
                          "\nIf you want to PLAY AGAIN press any number (0,1,2,3,4,5,6,7,8,9)," +
                          "\nelse if you want to END GAME press any letter");
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
                Console.WriteLine("\n___________________________________________________________________");
                Console.WriteLine("New Game");
                return true;
            default:
                Console.WriteLine("\nBye!!!");
                return false;
        }
    }
}