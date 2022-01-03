
using System;

namespace JuegosDeCartas
{
	class Program
	{
		public static void Main(string[] args)
		{

			Uno uno = new Uno();
			
			Console.WriteLine("Ingrese cantidad de jugadores: ");
			int numPlayers =int.Parse(Console.ReadLine());
			for(int i=0;i<numPlayers;i++){
				uno.agregarJugadores(FactoryPlayerAbstract.crearPorTeclado("player"));
			}
			
			uno.jugar();
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}