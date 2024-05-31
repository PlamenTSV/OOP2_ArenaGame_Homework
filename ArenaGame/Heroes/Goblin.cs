using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Goblin : Hero
    {
        private double stolenMAgic;

        public Goblin(string name, double armor, double strenght, IWeapon weapon) : 
            base(name, armor, strenght, weapon)
        {
            stolenMAgic = 0;
        }

        public override double Attack()
        {
            double damage = base.Attack() + stolenMAgic;

            double doubleAttack = random.NextDouble();
            if (doubleAttack < 0.5)
            {
                damage *= 2;
            }
            return damage;
        }

        public override double StealMagic()
        {
            double stealingChance = random.NextDouble();
            
            if (stealingChance < 0.3)
            {
                stolenMAgic++;
            }
            return stolenMAgic;
        }
    }
}