namespace MiniGame.App
{
    public abstract class Warrior
    {
        public int HP { get; set; } = 100;
        public int Armor { get; set; }
        public int Strength { get; set; }
        public bool IsAlive => HP > 0;

        public virtual void AddSuperPower(ISuperPower superPower, int quantity)
        {
            superPower.AddSuperPower(this, quantity);
        }
        
        public int Attack()
        {
            if (this.Armor > 0) return this.Strength;
            
            return this.Strength > 1 ? --this.Strength : 1;
        }

        public void Defense(int attack)
        {
            if (this.Armor > 0 && this.Armor > (attack + 1) / 2)
            {
                attack = Convert.ToInt32(Math.Ceiling((double)attack / 2));

                this.Armor -= attack;
                this.HP -= attack;
            }
            else if (this.Armor > 0 && this.Armor <= attack)
            {
                attack -= this.Armor;
                this.Armor = 0;
                this.HP -= attack;
            }
            else this.HP -= attack;
        }
    }
}