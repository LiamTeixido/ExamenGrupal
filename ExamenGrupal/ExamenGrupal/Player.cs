using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Player : IShowData
    {
        public string name;
        public List<Items> itemList;
        public int exp;
        public int level;
        public float money;

        public Player(string name, List<Items> itemList, int experience, int level, float money)
        {
            this.name = name;
            this.itemList = itemList;
            this.exp = experience;
            this.level = level;
            this.money = money;
        }

        public string ShowData()
        {
            string playerData = "Player Data:\n";
            playerData += $"Name: {name}\n";
            playerData += $"Experience: {exp}\n";
            playerData += $"Level: {level}\n";
            playerData += $"Money: {money}\n";

            if (itemList.Count > 0)
            {
                playerData += "Item List:\n";
                foreach (var item in itemList)
                {
                    if (item is Weapon weapon)
                    {
                        playerData += weapon.ShowData();
                    }
                    else if (item is Potion potion)
                    {
                        playerData += potion.ShowData();
                    }
                }
            }

            return playerData;
        }
    }
}
