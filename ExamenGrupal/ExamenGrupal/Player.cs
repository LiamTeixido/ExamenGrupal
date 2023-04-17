using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Player : Character
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
    }
}
