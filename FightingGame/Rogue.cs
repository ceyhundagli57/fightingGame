using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    public class Rogue : Hero
    {
        public int critical_hit_damage { get; set; }

        public Rogue()
        {
            this.melee_damage = 15;
            this.critical_hit_damage = 20;
        }
        public Random rand = new Random();

        override
        public void Attack(Hero target)
        {
            target.health -= melee_damage; 
            int critical_hit = rand.Next(1, 6);
            if (critical_hit == 1)
            {
                if (target is Tank)
                {
                    Console.WriteLine(string.Format("Tank special armor rebounds attack. {0} damage against.", melee_damage + critical_hit_damage));
                    this.health -= critical_hit_damage;
                }
                else {
                    Console.WriteLine("Critical HITTTTTT !!!!!");
                    target.health -= critical_hit_damage;
                }
            }
            if (target is Tank)
            {
                target.health += 5;
            }
        }
    }
}
