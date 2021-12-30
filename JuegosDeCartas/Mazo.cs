
using System;
using System.Collections.Generic;

namespace JuegosDeCartas
{

	public class Mazo
	{
		Pila mazzo;
		Carta pila;
		
		public Mazo()
		{
			this.mazzo = new Pila();
			this.llenar();
		}
		
		public Pila getMazo(){
			return mazzo;
		}

		
		public Carta getPila(){
			return pila;
		}
		
		public void setPila(Carta c){
			pila=c;
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
		
	
		
	}
}
