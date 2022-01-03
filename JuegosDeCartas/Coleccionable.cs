
using System;

namespace JuegosDeCartas
{

	public interface Coleccionable
	{
		int cuantos();
		Carta minimo();
		Carta maximo();
		void agregar(Carta c);
		bool contiene(Carta c);
	}
}