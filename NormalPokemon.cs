namespace game1401_la_starter
{
    internal class NormalPokemon : Pokemon
    {
        public NormalPokemon(string name, int health, int baseDamage)
        {
            this.baseDamage = baseDamage;
            this.name = name;
            this.health = health;
        }
        public override void Fight(Pokemon target)
        { 
            target.Hurt(baseDamage);
        }
    }
}
