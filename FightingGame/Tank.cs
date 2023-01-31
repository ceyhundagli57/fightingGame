using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    public class Tank : Hero
    {
        public int tank_armor { get; set; }

        public Tank()
        {
            this.melee_damage = 10;
        }
    }
}
