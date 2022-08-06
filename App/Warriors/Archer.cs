namespace MiniGame.App.Warriors
{
    public class Archer : Warrior
    {
        public Archer()
        {
            Armor = 1;
            Strength = 20 - Armor;
        }

        // public override void AddSuperPower(ISuperPower superPower, int quantity)
        // {
        //     base.AddSuperPower(superPower, quantity * 2); // вдвічі більша сила
        // }
        public override string ToString()
        {
            return $"{this.GetType().Name}: HP:={HP} Armor:={Armor} Strength:={Strength}";
        }
    }
}