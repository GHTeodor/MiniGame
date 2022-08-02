namespace MiniGame.App
{
    public class AddHP : ISuperPower
    {
        public virtual void AddSuperPower(Warrior warrior, int hp)
        {
            warrior.HP += hp;
        }
    }
}