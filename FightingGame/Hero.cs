using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    public class Hero
    {
        public int melee_damage { get; set; }
        public int health { get; set; }
        public int special_attacks_left { get; set; }
        public Hero()
        {
            this.health = 100;
          
        }
        public virtual void Attack(Hero target)
        {
            target.health -= melee_damage;
            if (target is Tank) {
                target.health += 5;
            }
        }
        public virtual void MagicAttack(Hero target)
        {

        }

    }
}
