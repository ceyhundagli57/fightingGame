using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    public class Mage : Hero
    {

        public int magic_attack_damage { get; set; }

        public Mage()
        {
            this.melee_damage = 7;
            this.magic_attack_damage = 25;
            this.special_attacks_left = 2;
        }

        override
        public void MagicAttack(Hero target)
        {
            if (target is Tank)
            {
                Console.WriteLine(string.Format("Tank special armor rebounds attack. {0} damage against.", magic_attack_damage));
                this.health -= magic_attack_damage;
                target.health += 5;
               
            }
            else 
            { 
            target.health -= magic_attack_damage;
            }
            special_attacks_left -= 1;
        }
    }
}
