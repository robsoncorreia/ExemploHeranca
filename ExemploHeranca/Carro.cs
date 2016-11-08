using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
	class Carro : Veiculo
	{
		
		private String placa;

		public Carro(string marca, 
					 string modelo, 
					 string cor, 
					 string placa) : 
						 base(marca, 
							  modelo, 
							  cor)
		{
			this.placa = placa;
		}

		

		public string Placa
		{
			get
			{
				return placa;
			}

			set
			{
				placa = value;
			}
		}

		

	}
}
