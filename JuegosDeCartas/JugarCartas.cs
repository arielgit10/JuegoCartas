
using System;

namespace JuegosDeCartas
{

	
	public abstract class JugarCartas
	{
		public JugarCartas()
		{
		}
	
	
		public void jugar(){
			//ganador= new Persona();
			
			mezclar();
			repartir();
			jugarMano();			
			HayGanador();
			
			//return null;
		}
				
		public abstract void mezclar();
		public abstract void repartir();
		public abstract void jugarMano();
		public abstract bool HayGanador();
		
		
		
	}
}
