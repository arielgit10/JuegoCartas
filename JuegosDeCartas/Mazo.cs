
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
		
//		public void setMazo(Pila mazzo){
//			this.mazzo==mazzo;
//		}
		
		public void mezclarMazo(){
			this.mazzo.mezclar();
		}		
		
		public void limpiarMazo(){
			this.mazzo.getColeccion().Clear();
		}

		public Pila getMonton(){
			return this.monton;
		}
		
		public void limpiarMonton(){
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
			this.monton.mezclar();		
			//luego de mezclar se lo añade al mazzo, que está vacío
			foreach(Carta c in this.monton.getColeccion()){
				this.mazzo.agregar(c);
			}	
		}
		
		
		public void verMazo(){
			Console.WriteLine("VER MAZO:\n");
			foreach(Carta c in this.getMazo().getColeccion()){
				Console.WriteLine(c.ToString());
			}
		}	
		
		
		
	}
}
