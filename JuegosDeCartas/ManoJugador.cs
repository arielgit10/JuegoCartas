
using System;
using System.Collections.Generic;

namespace JuegosDeCartas
{

	public class ManoJugador
	{
		private List<Carta> mano;
		
		public ManoJugador()
		{
			this.mano=new List<Carta>();
		}
		
		public void agregarCarta(Carta a){
			this.mano.Add(a);
		}
		
		public void eliminarCarta(Carta a){
			this.mano.Remove(a);
			//this.mano.RemoveAt(this.mano.IndexOf(a)-1);
		}
		
		public List<Carta> getMano(){
			return this.mano;
		}
		
		public void setMano(ManoJugador mano){
			this.mano=mano.getMano();
		}
		
		public void limpiar(){
			this.mano.Clear();
		}

		
		public bool manoVacia(){
			return this.mano.Count==0;
		}
		
		

		
		public void jugarMano(Player jugador, Mazo mazo){

			ManoJugador manoAux = new ManoJugador();
			
			foreach(Carta c in this.getMano()){
				manoAux.agregarCarta(c);
			}
			
			this.__jugarMano(jugador,mazo,manoAux);
		}
	
		
		private ManoJugador __jugarMano(Player jugador, Mazo mazo, ManoJugador manoAux){		
			int veces = 0;
			bool tiro=false;
			
			foreach(Carta c in this.getMano()){
					if(c.mismoColor(mazo.getPila())|c.mismoValor(mazo.getPila())){
						tiro=true;
						manoAux= this.__coincidencia(jugador, c, mazo, manoAux);
						if(manoAux.manoVacia()){
							Console.WriteLine("EL JUGADOR NO TIENE MAS CARTAS.");
							break;
						}
					}
			}
			
			if(!tiro){
				veces++;
				if(veces<2){	
					manoAux=this.__NoCoincidencia(jugador, mazo, manoAux);
					
					this.limpiar();
					foreach(Carta carta in manoAux.getMano()){
						this.agregarCarta(carta);
					}
					
					manoAux=this.__jugarMano(jugador,mazo, manoAux);
				}	
			}
			
			
			this.limpiar();
			foreach(Carta carta in manoAux.getMano()){
				this.agregarCarta(carta);
			}
			
			
			return manoAux;
		}
		
			
		private ManoJugador __coincidencia(Player jugador,Carta c, Mazo mazo, ManoJugador manoAux){
				mazo.getMonton().agregar(mazo.getPila());
				Console.WriteLine("El jugador {0} tira la carta {1} de {2}.",jugador.getName(),c.getValor(), c.getColor());
				manoAux.eliminarCarta(c);		
				mazo.setPila(c);
				Console.WriteLine("cartas restantes del mazo {0}.",mazo.getMazo().Coleccion.Count);			
				return manoAux;				
		}
		
	
			
		private ManoJugador __NoCoincidencia(Player jugador, Mazo mazo, ManoJugador manoAux){
			if(mazo.getMazo().Coleccion.Count!=0){
					Carta card= mazo.getMazo().sacar();
					Console.WriteLine("El jugador {0} levanta la carta {1} de {2}.",jugador.getName(), card.getValor(), card.getColor());
					Console.WriteLine("En el mazo hay: {0} cartas restantes.",mazo.getMazo().Coleccion.Count);		
					manoAux.agregarCarta(card);
					
					//si el mazo no tiene cartas, volver a repartir con el monton de la pila... INTERESANTE DE HACER
					if(mazo.getMazo().esVacia()){
						mazo.volverMezclar();
					}
					
			}
			return manoAux;
		}


		

		
	}
}
