namespace MiniGame.App
{
    public class AddStrength : ISuperPower
    {
        public virtual void AddSuperPower(Warrior warrior, int strength)
        {
            warrior.Strength += strength;
        }
    }
}