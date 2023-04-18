using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Weapon: Items
    {
        public float damage;
        


         public Weapon ( float damage ,string name , float price , string type) : base( name , price , type)
        {

        }
    }
}
