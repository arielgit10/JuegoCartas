using System;
using System.Collections.Generic;

namespace JuegosDeCartas
{

	public class Pila:Coleccionable,Iterable
	{
		private List<Carta> coleccion;
		private GeneradorDeDatosAleatorios g;
		//private Iterador itera;
		
		public Pila()
		{
			this.coleccion=new List<Carta>();
			this.g= GeneradorDeDatosAleatorios.getInstance();
		}
		
		public List<Carta> getColeccion(){
			return this.coleccion;
		}
		
		public void setColeccion(List<Carta> coleccion){
			this.coleccion=coleccion;
		}
		
		public void agregar(Carta c){
 			this.coleccion.Add(c);
		}
		
		public void eliminarCarta(Carta c){
			this.coleccion.Remove(c);
		}
		
		public Carta sacar() {
			Carta temp=null;
			if(this.coleccion.Count!=0){
				temp = this.tope();
				this.coleccion.RemoveAt(coleccion.Count-1);
			}
			return temp;
		}
				
		public Carta tope() {
			return this.coleccion[coleccion.Count-1]; 
		}
			
		public bool esVacia() {
				return this.coleccion.Count == 0;
		}
				
		public void mezclar(){			
			for (int i = this.coleccion.Count - 1; i > 0; i--){
				  int n = g.numeroAleatorio(this.coleccion.Count-1);
				  
				  Carta temporal = this.coleccion[i];
				  this.coleccion[i]=this.coleccion[n];
				  this.coleccion[n]=temporal;
			}
		}
			
		public void limpiar(){
			this.coleccion.Clear();
		}
				
		public int cuantos(){
			int valor=0;
			foreach(Carta co in coleccion){
				valor+=1;
			}
			return valor;
		}
		
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
