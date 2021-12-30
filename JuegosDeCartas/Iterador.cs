
using System;

namespace JuegosDeCartas
{

	public interface Iterador
	{
		void primero();
		void siguiente();
		bool fin();
		Carta actual();
	
		
	}
}
