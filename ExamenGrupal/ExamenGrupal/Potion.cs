using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Potion: Items, IShowData
    {
        public int capacity;
        public Potion(string name, string type, int price, int capacity) : base(name, price, type)
        {
            this.capacity = capacity;
        }

        public override void ItemMethod()
        {

        }

        public string ShowData()
        {
            return $"Weapon Name: {name}\nType: {type}\nPrice: {price}\nCapacity: {capacity}";
        }
    }
}
