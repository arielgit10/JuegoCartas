
using System;

namespace JuegosDeCartas
{

	public class LectorDeDatos
	{
		public LectorDeDatos()
		{
		}

		public int numeroPorTeclado(){
			int numero=int.Parse(Console.ReadLine());
			return numero;
		}
		
		public string stringPorTeclado(){
			string estring=Console.ReadLine();
			return estring;
		}
	
	
	
	}
}
