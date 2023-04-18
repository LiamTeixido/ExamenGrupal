using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Talkers : NPC
    {
        public List<string> textList;

        public Talkers(string name, int life, string type, List<string> textList) : base(name, life, type)
        {
            this.textList = textList;
        }

        public override void HabilitiesNPC()
        {

        }

        //public string ShowData()
        //{
        //    return base.ShowData() + "\nNPC Item List: " + string.Join(", ", textList);
        //}

        public string ShowData()
        {
            return $"Weapon Name: {name}\nLife: {life}\nType: {type}\nTextList: {textList}";
        }
    }
}
