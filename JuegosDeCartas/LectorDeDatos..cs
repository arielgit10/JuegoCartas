
using System;

namespace JuegosDeCartas
{

	public class LectorDeDatos
	{
		public LectorDeDatos()
		{
		}

		public int numeroPorTeclado(){
			Console.WriteLine("Ingrese un número: ");
			int numero=int.Parse(Console.ReadLine());
			return numero;
		}
		
		public string stringPorTeclado(){
			Console.WriteLine("Ingrese una palabra: ");
			string estring=Console.ReadLine();
			return estring;
		}
	
	
	
	}
}
