
using System;
using System.Collections.Generic;

namespace JuegosDeCartas
{

	public class Mazo
	{
		private Pila mazzo;
		private Carta pila;
		private Pila monton;
		
		public Mazo()
		{
			this.mazzo = new Pila();
			this.monton = new Pila();
			this.llenar();
		}
		
		public Pila getMazo(){
			return this.mazzo;
		}
		
		public void limpiarMazo(){
			this.mazzo.getColeccion().Clear();
		}

		public Pila getMonton(){
			return this.monton;
		}
		
		public void setMonton(){
			this.monton.getColeccion().Clear();
		}
		
		public Carta getPila(){
			return this.pila;
		}
		
		public void setPila(Carta c){
			this.pila=c;
		}
		
		
		public void llenar(){			
			for(int i=0;i<=9;i++){
				mazzo.agregar(new Carta("rojo",i));
			}
			for(int i=0;i<=9;i++){
				mazzo.agregar(new Carta("azul",i));
			}
			for(int i=0;i<=9;i++){
				mazzo.agregar(new Carta("amarillo",i));
			}
			for(int i=0;i<=9;i++){
				mazzo.agregar(new Carta("verde",i));
			}
		}
		


		public void volverMezclar(){
			
			//mezclar lo que está en el monton (crear y luego llamar a metodo dentro de la clase Pila)
			//this.getMonton().mezclar();
			
			
			//luego de mezclar se lo añade al mazzo, que está vacío
			foreach(Carta c in this.getMonton().getColeccion()){
				this.mazzo.agregar(c);
			}	
		}
		

	
		
	}
}
