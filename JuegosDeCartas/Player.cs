
using System;
using System.Collections.Generic;
namespace JuegosDeCartas
{

	public class Player
	{
		private string name;
		private int pointsHand, pointsTotal;		
		private ManoJugador manoJug;
		
		
		public Player(string name)
		{
			this.name=name;			
			this.manoJug= new ManoJugador();
			this.pointsHand=0;
			this.pointsTotal=0;
		}
		
		
		public int getPuntosHand(){
			return this.pointsHand;
		}
		
		public void setPuntosHand(){
			foreach(Carta c in this.manoJug.getMano()){
				this.pointsHand+=c.getValor();
			}
		}
		
		public void resetearPuntosHand(){
			this.pointsHand=0;
		}
		
		public int getPuntosTotal(){
			return this.pointsTotal;
		}
			
		public void setPuntosTotal(int valor){
			this.pointsTotal+=valor;
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
						
		public bool manoVacia(){
			return this.manoJug.manoVacia();
		}

		public void mostrarMano(){
			Console.WriteLine("\nCartas restantes del jugador {0}.\n",name);
			foreach(Carta c in this.manoJug.getMano()){
				Console.WriteLine("\t"+c.ToString());
			}
		}

		public override string ToString(){
			return string.Format("Player Name={0}\nTotal points={1}\n", this.name, this.pointsTotal);
		}
		
		
	}
}
