
using System;

namespace JuegosDeCartas
{

	public abstract class FactoryPlayerAbstract
	{
		public FactoryPlayerAbstract()
		{
		}
		
		public static Player crearAleatorio(string opcion){
			FactoryPlayerAbstract factory = null;
		
			switch(opcion){
				case "player":
					factory = new PlayersFactory();
					break;
			}
			return factory.crearAleatorio();
		}

		public static Player crearPorTeclado(string opcion){
			FactoryPlayerAbstract factory = null;
			
			switch(opcion){
				case "player":
					factory = new PlayersFactory();
					break;
			}
			return factory.crearPorTeclado();
		}
		
		
		
		public abstract Player crearAleatorio();
		
		public abstract Player crearPorTeclado();
	}
}
