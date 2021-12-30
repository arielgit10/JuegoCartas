
using System;
using System.Collections.Generic;

namespace JuegosDeCartas
{

	public class ManoJugador
	{
		private List<Carta> mano;
		private bool tiro;
		
		public ManoJugador()
		{
			this.mano=new List<Carta>();
			this.tiro=false;
		}
		
		public void agregarCarta(Carta a){
			this.mano.Add(a);
		}
		
		public void eliminarCarta(Carta a){
			this.mano.RemoveAt(this.mano.IndexOf(a));
		}
		
		public List<Carta> getMano(){
			return this.mano;
		}
		
		
		public List<Carta> jugarMano(Player jugador, Mazo mazo){
			List<Carta> manoAux = new List<Carta>();
			
			foreach(Carta c in this.mano){
				manoAux=__jugarMano(c,manoAux,mazo,jugador);
			}
			if(!tiro){
			
				if(mazo.getMazo().Coleccion.Count!=0){
					Carta card= mazo.getMazo().sacar();
					Console.WriteLine("El jugador {0} levanta la carta {1} de {2}.",jugador.getName(), card.getValor(), card.getColor());
					Console.WriteLine("En el mazo hay: {0} cartas restantes.",mazo.getMazo().Coleccion.Count);
				
					this.mano.Add(card);
					this.jugarMano(jugador,mazo);
				}
				else{
					//volver a repartir...
				}
//				Carta card= mazo.getMazo().sacar();
//				Console.WriteLine("El jugador {0} levanta la carta {1} de {2}.",jugador.getName(), card.getValor(), card.getColor());
//				Console.WriteLine("En el mazo hay: {0} cartas restantes.",mazo.getMazo().Coleccion.Count);
//				
//				this.mano.Add(card);
//				this.jugarMano(jugador,mazo);
			}
						
			//this.mano=manoAux;
			return manoAux;
		}
	
		private List<Carta> __jugarMano(Carta card,List<Carta> manoAux, Mazo mazo,Player jugador){
			if(card!=mazo.getPila()){
				manoAux.Add(card);
			}
			else{
				Console.WriteLine("El jugador {0} tira la carta {1} de {2}.",jugador.getName(),card.getValor(), card.getColor());
				mazo.setPila(card);
				this.tiro=true;
			}
			return manoAux;			
		}
		
			
//		public List<Carta> throwCart(Carta card,List<Carta> manoAux,Player jugador,Carta c){					
//			Console.WriteLine("El jugador {0} tira la carta {1} de {2}.",jugador.getName(),c.getValor(), c.getColor());			
//			manoAux.RemoveAt(this.mano.IndexOf(c));
//			return manoAux;
//		}
//		
//		public List<Carta> pickCard(List<Carta> manoAux ,Player jugador,Carta c){
//			Console.WriteLine("El jugador {0} levanta la carta {1} de {2}.",jugador.getName(), c.getValor(), c.getColor());
//			manoAux.Add(c);
//			return manoAux;
//		}











		
		
//		public List<Carta> throwCart(List<Carta> manoAux,Player jugador,Carta c){					
//			Console.WriteLine("El jugador {0} tira la carta {1} de {2}.",jugador.getName(),c.getValor(), c.getColor());			
//			manoAux.RemoveAt(this.mano.IndexOf(c));
//			return manoAux;
//		}
//		
//		public List<Carta> pickCard(List<Carta> manoAux ,Player jugador,Carta c){
//			Console.WriteLine("El jugador {0} levanta la carta {1} de {2}.",jugador.getName(), c.getValor(), c.getColor());
//			manoAux.Add(c);
//			return manoAux;
//		}
		
		
		
	
	
		
	}
}
