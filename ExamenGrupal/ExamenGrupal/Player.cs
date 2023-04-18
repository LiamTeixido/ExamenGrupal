using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Player : IShowData
    {
        protected string name;
        protected int level;
        protected float price;

        public Player(string name, int level, float price)
        {
            this.name = name;
            this.level = level;
            this.price = price;
        }

        public string ShowData()
        {
            return $"Player Name: {name}\nItemList: {itemList}\nExperience: {exp}\nlevel: {level}\nMoney: {money}";
        }

    }
}
