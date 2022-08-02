namespace MiniGame.App.HW2;

public class PlayerHelper
{
    public static int GetNumberOfPlayers ()
    {
        Console.WriteLine("===================================================================");
        Console.WriteLine("Choose even number of players (from 2 to 8), or 2 players (1x1): ");
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.D4:
                Console.WriteLine("\nYou chose '4' => 1x1 , 1x1");
                return 4;
            case ConsoleKey.D6:
                Console.WriteLine("\nYou chose '6' => 1x1 , 1x1, 1x1");
                return 6;
            case ConsoleKey.D8:
                Console.WriteLine("\nYou chose '8' => 1x1 , 1x1, 1x1, 1x1");
                return 8;
            
            default:
                Console.WriteLine("\nYou chose 'default: 2 players' => 1x1");
                return 2;
        }
    }
}