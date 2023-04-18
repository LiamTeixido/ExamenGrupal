using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Conversador : NPC,IShowData
    {
		public override void HabilitiesNPC()
		{
			Console.WriteLine("Conversador conversa");
		}
		string IShowData.ShowData()
		{
			string data = "";

			foreach (string texto in textos)
			{
				data += texto + "\n";
			}

			return data;
		}
	}
}
