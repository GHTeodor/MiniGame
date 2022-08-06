namespace MiniGame.App
{
    public class AddArmor : ISuperPower
    {
        public virtual void AddSuperPower(Warrior warrior, int armor)
        {
            warrior.Armor += armor;
        }
    }
}