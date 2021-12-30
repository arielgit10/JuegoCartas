using System;
using System.Collections.Generic;

namespace JuegosDeCartas
{

	public class Pila:Coleccionable,Iterable
	{
		private List<Carta> coleccion;

		private int contador;
		//private Iterador itera;
		
		public Pila()
		{
			coleccion=new List<Carta>();
		}
		
		

		//Agrega el comparable recibido por  parámetro a la colección que recibe el mensaje
		public void agregar(Carta c){
 			coleccion.Add(c);
		}
		
		//saca el elemento de la última posición
		public Carta sacar() {
			Carta temp=null;
			if(this.coleccion.Count!=0){
				temp = this.tope();
				this.coleccion.RemoveAt(coleccion.Count-1);
			}
			
			//Carta temp = this.tope();
			//this.coleccion.RemoveAt(coleccion.Count-1);
			return temp;
		}
			
		
		public Carta tope() {
			return this.coleccion[coleccion.Count-1]; 
		}
		
		
		public bool esVacia() {
				return this.coleccion.Count == 0;
		}
		
		
		public List<Carta> Coleccion{
			set{coleccion=value;}
			get{return coleccion;}
		}
		
		//Devuelve la cantidad de elementos comparables que tiene el coleccionable
		public int cuantos(){
			int valor=0;
			foreach(Carta co in coleccion){
				valor+=1;
			}
			return valor;
		}
		
		//Devuelve el elemento de menor valor  de la colección	
		public Carta minimo(){
			Carta comp=coleccion[0];
			foreach(Carta c in coleccion){
				if(c.getValor()<comp.getValor()){
					comp=c;
				}
			}
			return comp;
		}
		
		public Carta maximo(){
			Carta comp=coleccion[0];
			foreach(Carta c in coleccion){
				if(c.getValor()>comp.getValor()){
					comp=c;
				}
			}
			return comp;
		}


		public bool contiene(Carta com){
			bool existe=false;		
			foreach(Carta c in coleccion){
				if(c.getValor()==com.getValor()){
					existe=true;
				}
			}
			return existe;	
		}

		public Iterador crearIterador(){
			IteradorDePila iteraCol = new IteradorDePila(this);
			return iteraCol;
		}
	
		
		
		
		
	}
}
