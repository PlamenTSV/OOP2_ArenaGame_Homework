using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Necromancer : Hero
    {
        private double undeadMinions;

        public Necromancer(string name, double armor, double strenght, IWeapon weapon) : 
            base(name, armor, strenght, weapon)
        {
            undeadMinions = 0;
        }

        public override double Attack()
        {
            if(undeadMinions == 0) return 0;

            double damage = base.Attack() * undeadMinions;

            return damage;
        }

        public override double SummonUndead()
        {
            undeadMinions++;
            return undeadMinions;
        }

        public override double Defend(double damage)
        {
            if(undeadMinions == 0) return base.Defend(damage);

            undeadMinions--;
            return 0;
        }
    }
}