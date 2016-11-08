using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
	class Barco : Veiculo
	{
		
		private String identificador;

		public string Identificador
		{
			get
			{
				return identificador;
			}

			set
			{
				identificador = value;
			}
		}

		public Barco(String marca,
					 String modelo,
					 String cor,
					 String identificador) 
			: base(marca, modelo, cor)
		{
			this.identificador = identificador;
		}

		public override void Locomover()
		{
			base.Locomover();
			Console.WriteLine("É um barco, portanto, está navegando..");
		}
	}
}
