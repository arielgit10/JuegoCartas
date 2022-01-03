
using System;

namespace JuegosDeCartas
{

	public class PlayersFactory:FactoryPlayerAbstract
	{
		private GeneradorDeDatosAleatorios generador;
		private LectorDeDatos lector;
		
		public PlayersFactory()
		{
			generador=GeneradorDeDatosAleatorios.getInstance();
			lector = new LectorDeDatos();
		}
			
		public override Player crearAleatorio(){
			return new Player(generador.stringAleatorio(8));	
		}
		
		public override Player crearPorTeclado(){
			Console.WriteLine("Ingrese el nombre del jugador: ");
			return new Player(lector.stringPorTeclado());
		}
		
	}
}
