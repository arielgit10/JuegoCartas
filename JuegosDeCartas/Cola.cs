using System;
using System.Collections.Generic;


namespace JuegosDeCartas
{

	public class Cola:Coleccionable,Iterable
	{
		private List<Carta> coleccion;
		private int contador;
		
		public Cola()
		{
			coleccion=new List<Carta>();
		}
		
		
		//Agrega el comparable recibido por  parámetro a la colección que recibe el mensaje
		public void agregar(Carta c){
			this.coleccion.Add(c);
 			//Console.WriteLine("Se ha agregado el comparable.");	
		}
		
	
		public Carta desencolar() {
			Carta temp = this.coleccion[0];
			this.coleccion.RemoveAt(0);
			return temp;
		}
		
		public Carta tope() {
			return this.coleccion[0]; 
		}
		
		
		public bool esVacia() {
				return this.coleccion.Count == 0;
		}

				
		public List<Carta> Coleccion{
			get{return coleccion;}
		}
		
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
			
		//Devuelve el elemento de mayor valor  de la colección
		public Carta maximo(){
			Carta comp=coleccion[0];
			foreach(Carta c in coleccion){
				if(c.getValor()>comp.getValor()){
					comp=c;
				}
			}
			return comp;
		}
			

		
		//Devuelve verdadero si el  comparable recibido por parámetro está incluido en la colección y falso en caso contrario 
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
			IteradorDeCola iteraCol = new IteradorDeCola(this);
			return iteraCol;
		}
		

		
		
	}
}
