using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
	class Program
	{
		static void Main(string[] args)
		{
			Carro meuCarro = new Carro("Tesla", 
								       "Model X", 
									   "prata", 
									   "BOM-0001");
			meuCarro.Velocidade = 80;
			meuCarro.Locomover();

			meuCarro.Velocidade = 0;
			meuCarro.Locomover();

			Aviao seuAviao = new Aviao();
			seuAviao.Marca = "Embraer";
			seuAviao.Modelo = "Tucano";
			seuAviao.Cor = "Verde limão";
			seuAviao.Locomover();

			Barco meuBarco = new Barco("Yacht", 
									   "Sea Ray 275", 
									   "branco", 
									   "HMS-1");
			meuBarco.Locomover();

			//Veiculo meuVeiculo = new Veiculo();
		}
	}
}
