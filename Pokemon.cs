using Microsoft.VisualBasic;

namespace game1401_la_starter
{
    internal class Pokemon
    {
        protected int health;
        protected string name;
        protected int baseDamage;



        virtual public void Fight(Pokemon target)
        {
            Console.WriteLine("This should be overridden!");
            target.Hurt(0);
        }
        
        public void Item()
        {
            //restores hp, always the same amount
            Console.WriteLine();
        }

        public void Run()
        {
            //no running away allowed
            Console.WriteLine("No running allowed!");
        }

        public int GetHP()
        {
            return this.health;
        }

        public void Hurt(int hp)
        {
            this.health -= hp;
        }
    }
    
}
