
using System;

namespace JuegosDeCartas
{

	public interface Coleccionable
	{
		int cuantos();	//Devuelve la cantidad de elementos comparables que tiene el coleccionable
		Carta minimo();	//Devuelve el elemento de menor valor  de la colección 
		Carta maximo();	//Devuelve el elemento de mayor valor  de la colección
		void agregar(Carta c);		//Agrega el comparable recibido por  parámetro a la colección que recibe el mensaje
		bool contiene(Carta c);    //Devuelve verdadero si el  comparable recibido por parámetro está incluido en la colección y falso en caso contrario 
	}
}