namespace game1401_la_starter
{
    internal class WaterPokemon : Pokemon
    {
        public WaterPokemon(string name, int health, int baseDamage)
        {
            this.baseDamage = baseDamage;
            this.name = name;
            this.health = health;
        }

        public override void Fight(Pokemon target)
        {
            if (target is FirePokemon)
            {
                target.Hurt((int)(baseDamage * 1.2));
            }
            else if (target is WaterPokemon || target is GrassPokemon)
            {
                target.Hurt((int)(baseDamage * 0.8));
            }
            else
            {
                target.Hurt(baseDamage);
            }

        }
    }
}
