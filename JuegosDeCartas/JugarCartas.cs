
using System;

namespace JuegosDeCartas
{
	
	public abstract class JugarCartas
	{
		public JugarCartas()
		{
		}
	
		public void jugar(){
			mezclar();
			repartir();
			jugarMano();			
			HayGanador();
		}
				
		public abstract void mezclar();
		public abstract void repartir();
		public abstract void jugarMano();
		public abstract bool HayGanador();
			
		
	}
}
