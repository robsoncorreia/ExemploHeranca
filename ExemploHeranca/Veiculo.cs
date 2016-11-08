using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
	abstract class Veiculo
	{
		private String marca;
		private String modelo;
		private String cor;
		private int velocidade;

		public Veiculo(string marca, 
					   string modelo, 
					   string cor)
		{
			this.marca = marca;
			this.modelo = modelo;
			this.cor = cor;
			this.velocidade = 0;
		}

		public Veiculo()
		{
			this.velocidade = 0;
		}
		public string Marca
		{
			get
			{
				return marca;
			}

			set
			{
				marca = value;
			}
		}

		public string Modelo
		{
			get
			{
				return modelo;
			}

			set
			{
				modelo = value;
			}
		}

		public string Cor
		{
			get
			{
				return cor;
			}

			set
			{
				cor = value;
			}
		}

		public int Velocidade
		{
			get
			{
				return velocidade;
			}

			set
			{
				velocidade = value;
			}
		}

		//método Locomover()
		public virtual void Locomover()
		{
			if(this.velocidade == 0)
			{
				Console.WriteLine("O {0} {1} está parado.",
				this.marca,
				this.modelo);
			}
			else
			{
				Console.WriteLine("O {0} {1} está em movimento à {2} km/h.",
				this.marca,
				this.modelo,
				this.velocidade);
			}
			
		}
	}
}
