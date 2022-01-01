
using System;
using System.Collections.Generic;
namespace JuegosDeCartas
{

	public class Player
	{
		private string name;
		private int points;		
		private ManoJugador manoJug;
		
		
		public Player(string name)
		{
			this.name=name;			
			this.manoJug= new ManoJugador();
		}
		
		
		public int getPuntos(){
			return this.points;
		}
		public void setPuntos(int value){
			points=+value;
		}
		
		public string getName(){
			return this.name;
		}
		
		public ManoJugador getMano(){
			return this.manoJug;
		}
		
		public void setManoJug(ManoJugador mano){
			this.manoJug.setMano(mano);
		}
		
		
		public void throwCart(Carta c){					
			Console.WriteLine("El jugador {0} tira la carta {1} de {2}.",name,c.getValor(), c.getColor());
			this.manoJug.eliminarCarta(c);
		}
		
		public void pickCard(Carta c){
			Console.WriteLine("El jugador {0} levanta la carta {1} de {2}.",name, c.getValor(), c.getColor());
		    this.manoJug.agregarCarta(c);
		}
		
		public int pointsHand(){
			foreach(Carta c in this.manoJug.getMano()){
				points+=c.getValor();
			}
			return points;
		}
		
		public void cortar(){
			Console.WriteLine();
		}
		
			
		public bool manoVacia(){
			return this.manoJug.manoVacia();
		}

		public void sumar(){		
			foreach(Carta c in this.manoJug.getMano()){
				points+=c.getValor();
			}
		}
		
		
		public void mostrarMano(){
			Console.WriteLine("\nCartas restantes del jugador {0}.",name);
			foreach(Carta c in this.manoJug.getMano()){
				Console.WriteLine(c.ToString());
			}
		}
		
	
		public override string ToString(){
			return string.Format("Player Name={0}\nPoints={1}\n", name, points);
		}
		
		
	}
}
