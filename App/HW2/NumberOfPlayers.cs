namespace MiniGame.App.HW2;

public static class NumberOfPlayers
{
    public static int Players()
    {
        Console.WriteLine("\nОберіть парну кількість гравців (від 2 до 8), інакше 2 гравці (1x1): ");
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.D4:
                Console.WriteLine("Ви обрали '4' => 1x1 , 1x1\n");
                return 4;
                break;
            case ConsoleKey.D6:
                Console.WriteLine("Ви обрали '6' => 1x1 , 1x1, 1x1\n");
                return 6;
                break;
            case ConsoleKey.D8:
                Console.WriteLine("Ви обрали '8' => 1x1 , 1x1, 1x1, 1x1\n");
                return 8;
                break;
            default:
                Console.WriteLine("Ви обрали '2' => 1x1\n");
                return 2;
        }
    }
}