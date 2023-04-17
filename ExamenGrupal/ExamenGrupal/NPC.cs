using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    abstract class NPC 
    {
        public string name;
        public float life;
        public string type;

        public NPC(string name, float life, string type )
        {
            this.name = name;
            this.life = life;
            this.type = type;
        }

        public abstract void HabilitiesNPC();
        
           
        
    }

}
