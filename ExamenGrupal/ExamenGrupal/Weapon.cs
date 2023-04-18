using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
class Weapon : Items, IShowData
    {
        public int damage;
        public Weapon(string name, string type, int price, int damage) : base(name, price, type)
        {
            this.damage = damage;
        }

        public override void ItemMethod()
        {

        }

        public string ShowData()
        {
            return $"Weapon Name: {name}\nType: {type}\nPrice: {price}\nDamage: {damage}";
        }
    }
}
