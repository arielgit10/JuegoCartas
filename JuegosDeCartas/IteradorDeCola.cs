
using System;
using System.Collections.Generic;


namespace JuegosDeCartas
{

	public class IteradorDeCola:Iterador
	{
		private int posicionActual;
		private List<Carta> coleccion;

		public IteradorDeCola(Cola cola)
		{
			this.coleccion=cola.Coleccion;
			primero();
		}
				
		public int PosicionActual{
			get{return posicionActual;}
		}
				
		public void primero(){
			posicionActual=0;
		}
		
		public void siguiente(){
			posicionActual++;
		}
		
		public bool fin(){
			bool existe=false;
			if(posicionActual>=coleccion.Count){
				existe=true;
			}
			return existe;
		}
		
		public Carta actual(){
			return coleccion[PosicionActual];
		}
		
		
		
	}
}
