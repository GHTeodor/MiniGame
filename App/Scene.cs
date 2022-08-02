namespace MiniGame.App
{
    public static class Scene
    {
        public static void Fight(Warrior warrior1, Warrior warrior2)
        {
            int round = 0;
            while (warrior1.IsAlive && warrior2.IsAlive)
            {
                round++;
                warrior1.Defense(warrior2.Attack());
                warrior2.Defense(warrior1.Attack());
                Console.WriteLine(round + " round:\n" + warrior1 + "\n" + warrior2 + "\n");
            }

            if (!warrior1.IsAlive && !warrior2.IsAlive) Console.WriteLine("Draw in " + round + "round");
            else if (!warrior1.IsAlive && warrior2.IsAlive)
                Console.WriteLine($"Winner in {round} round \n \t{warrior2} \n \t \tLooser {warrior1}");

            else if (!warrior2.IsAlive && warrior1.IsAlive)
                Console.WriteLine($"Winner in {round} round \n \t{warrior1} \n \t \tLooser {warrior2}");
        }
    }
}