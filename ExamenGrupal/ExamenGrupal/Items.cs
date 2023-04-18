using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    abstract class Items
    {
        public string name;
        public int price;
        public string type;

        public Items(string name, int price, string type)
        {
            this.name = name;
            this.price = price;
            this.type = type;
        }

        public abstract void ItemMethod();
    }
}
