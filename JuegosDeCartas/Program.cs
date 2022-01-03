
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
			Console.WriteLine();
			uno.jugar();
			
			
			//Faltaría agregar las cartas especiales del juego.
			
			//Es recomendable no jugar con más de 3 jugadores ya que el mazo podría agotarse rápidamente. Como solución de esto,
			//se puede llenar el mazo con más cartas al inicio del juego. Es decir, llenar el mazo de acuerdo a la cantidad de jugadores presentes en el juego.
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}