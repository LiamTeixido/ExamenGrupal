using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Talkers
    {
        private List<string> texts;

        public Talkers()
        {
            texts = new List<string>();
        }

        public List<string> GetTexts()
        {
            return texts;
        }

        public void AddTexts(string Texts)
        {
            texts.Add(Texts);
        }
    }
}
