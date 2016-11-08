using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
	class Aviao : Veiculo
	{
		
		public override void Locomover()
		{
			Console.WriteLine("O {0} {1} está voando!",
				this.Marca,
				this.Modelo);
		}

	}
}
