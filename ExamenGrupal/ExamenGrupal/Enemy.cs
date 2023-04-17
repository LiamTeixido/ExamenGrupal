using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Enemy:NPC
    {
        public float damage;
        public List<string> itemList;
        public int level;
        public float xp;

        public Enemy(string name, float life, string type, float damage, List<string> itemList, int level, float xp) : base(name, life, type)
        {
            this.damage=damage;
            this.level=level;
            this.xp = xp;
        }
        public override void HabilitiesNPC()
        {
            Console.WriteLine("Enemy ataca");
        }

    }
}
