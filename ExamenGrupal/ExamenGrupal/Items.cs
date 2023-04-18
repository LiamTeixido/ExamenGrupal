using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    abstract class Items
    {
        protected string name;
        protected float price;
        protected string type;

        public Items(string name, float price, string type)
        {
            this.name = name;
            this.price = price;
            this.type = type;
        }
    }
}
