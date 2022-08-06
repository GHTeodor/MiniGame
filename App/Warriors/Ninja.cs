namespace MiniGame.App.Warriors
{
    public class Ninja : Warrior
    {
        public Ninja()
        {
            Armor = 13;
            Strength = 20 - Armor;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: HP:={HP} Armor:={Armor} Strength:={Strength}";
        }
    }
}