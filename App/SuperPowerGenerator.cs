namespace MiniGame.App
{
    public class SuperPowerGenerator
    {
        public int GetRandom()
        {
            int number = DateTime.Now.Millisecond;

            number %= number.ToString().Last();

            while (number < 5 || number > 10)
            {
                if (number < 5) number += 5;
                else if (number > 10) number /= 2;
            }

            return number;
        }
    }
}