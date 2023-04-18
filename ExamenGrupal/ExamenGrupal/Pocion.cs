using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Pocion : Items
    {
		private float capacidad;

		public float GetCapacidad()
		{
			return capacidad;
		}

		public void SetCapacidad(float capacidad)
		{
			this.capacidad = capacidad;
		}
    }
}
