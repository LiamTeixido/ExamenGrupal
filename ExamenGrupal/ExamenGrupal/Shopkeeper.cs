using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Shopkeeper : NPC
    {
        public int money;
        public List<Items> itemList;

        public Shopkeeper(string name, float life, string type, int money, List<Items> itemList) : base(name, life, type)
        {
            this.money = money;
            this.itemList = itemList;
        }

        public string ShowData()
        {
            string sellerData = "Enemy Data:\n";
            sellerData += $"Name: {name}\n";
            sellerData += $"Life: {life}\n";
            sellerData += $"Type: {type}\n";
            sellerData += $"Money: {money}\n";

            if (itemList.Count > 0)
            {
                sellerData += "Item List:\n";
                foreach (var item in itemList)
                {
                    if (item is Weapon weapon)
                    {
                        sellerData += weapon.ShowData();
                    }
                    else if (item is Potion potion)
                    {
                        sellerData += potion.ShowData();
                    }
                }
            }

            return sellerData;
        }
        public override void HabilitiesNPC()
        {

        }
    }
}