
using System;
using System.Collections.Generic;
namespace JuegosDeCartas
{

	public class Player
	{
		private string name;
		private int points;
	//	private List<Carta> hand;
		
		private ManoJugador manoJug;
		
		
		public Player(string name)
		{
			this.name=name;
			//this.turno=0;
			//this.hand = new List<Carta>();
			
			this.manoJug= new ManoJugador();
		}
		
		
		public int getPuntos(){
			return points;
		}
		public void setPuntos(int value){
			points=+value;
		}
		
		public string getName(){
			return name;
		}
		
		public void setMano(Carta c){
			//this.hand.Add(c);
			this.manoJug.agregarCarta(c);
		}
		
//		public List<Carta> getHand(){
//			//return this.hand;
//			return 
//		}
	
		
		public void throwCart(Carta c){					
			Console.WriteLine("El jugador {0} tira la carta {1} de {2}.",name,c.getValor(), c.getColor());
			//this.manoJug.eliminarCarta(c);
			//this.hand.Remove(c);
		}
		
		public void pickCard(Carta c){
			Console.WriteLine("El jugador {0} levanta la carta {1} de {2}.",name, c.getValor(), c.getColor());
		//	this.manoJug.agregarCarta(c);
			//this.hand.Add(c);
		}
		
		public int pointsHand(){
//			foreach(Carta c in hand){
//				points+=c.getValor();
//			}
			foreach(Carta c in this.manoJug.getMano()){
				points+=c.getValor();
			}
			return points;
		}
		
		public void cortar(){
			Console.WriteLine();
		}
		
		
		public List<Carta> turnoJugar(Mazo mazo){			
			this.mostrarMano();
			Console.WriteLine("Pila Mano: "+ mazo.getPila().ToString());
			List<Carta> mano = this.manoJug.jugarMano(this,mazo);
//			turno++;
//			if(turno<2){
//					mano = this.turnoJugar(mazo);
//			}		
			return mano;		
		}
		
		
	
		public bool manoVacia(){
			//Console.WriteLine("Cantidad de cartas del jugador {0} son {1}",this.getName(),this.manoJug.getMano().Count);
			return this.manoJug.getMano().Count==0;
			//return this.hand.Count==0;
		}

		public void sumar(){
			
			foreach(Carta c in this.manoJug.getMano()){
				points+=c.getValor();
			}
			this.mostrarMano();
//			foreach(Carta c in this.hand){
//				points+=c.getValor();
//			}
		}
		
		
		public override string ToString()
		{
			return string.Format("Player Name={0}\nPoints={1}\n", name, points);
		}

		public void mostrarMano(){
			Console.WriteLine("\nCartas restantes del jugador {0}.",name);
			foreach(Carta c in this.manoJug.getMano()){
				Console.WriteLine(c.ToString());
					}
		}
		
		
	}
}
