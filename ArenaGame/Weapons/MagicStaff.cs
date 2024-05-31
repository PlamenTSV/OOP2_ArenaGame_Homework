using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class MagicStaff : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public MagicStaff(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 0;
        }

        public double Heal(double currHealth){
            return currHealth + 20; 
        }
    }
}