using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Enemy : NPC, IShowData
    {
        public float damage;
        public List<Items> itemList;
        public int level;
        public float xp;

        public Enemy(string name, float life, string type, float damage, List<Items> itemList, int level, float xp) : base(name, life, type)
        {
            this.damage=damage;
            this.level=level;
            this.xp = xp;
            this.itemList = itemList;
        }
        public override void HabilitiesNPC()
        {
            Console.WriteLine("Enemy ataca");
        }

        public string ShowData()
        {
            string enemyData = "Enemy Data:\n";
            enemyData += $"Name: {name}\n";
            enemyData += $"Life: {life}\n";
            enemyData += $"Type: {type}\n";
            enemyData += $"Damage: {damage}\n";
            enemyData += $"Level: {level}\n";
            enemyData += $"XP: {xp}\n";
            if (itemList.Count > 0)
            {
                enemyData += "Item List:\n";
                foreach (var item in itemList)
                {
                    if (item is Weapon weapon)
                    {
                        enemyData += weapon.ShowData();
                    }
                    else if (item is Potion potion)
                    {
                        enemyData += potion.ShowData();
                    }
                }
            }
            return enemyData;
        }
    }
}
