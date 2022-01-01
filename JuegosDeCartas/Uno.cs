
using System;
using System.Collections.Generic;

namespace JuegosDeCartas
{

	public class Uno:JugarCartas
	{
		private Random randomUnicoDeInstancia = new Random();
		List<Player> players = new List<Player>();	
		Mazo mazo;
		Player ganador;
		
		public Uno(Random r = null)
		{				
			if(r != null){
				randomUnicoDeInstancia = r;
			}		
			this.mazo = new Mazo();
			this.mazo.llenar();
			
//			for(int i=0;i<4;i++){
//				
//				players.Add(new Player("););
//			}
			
			players.Add(new Player("ARIEL"));
			players.Add(new Player("FFFFF"));
			players.Add(new Player("GGGGG"));
		}
		
		
		public override void mezclar(){
			Console.WriteLine("Se mezclan las cartas...\n");
		}

		
		public override void repartir(){
			Console.WriteLine("Se reparten las cartas...\n");
			
//			if(players.Count==0){
//				Console.WriteLine("NO HAY JUGADORES2");
//			}
			
			foreach (Player p in players){
				for(int i=0;i<7;i++){
					Carta card = mazo.getMazo().Coleccion[randomUnicoDeInstancia.Next(0,mazo.getMazo().Coleccion.Count-1)];
					
					p.getMano().agregarCarta(card);
					
					mazo.getMazo().Coleccion.Remove(card);
				}
			}
			//setear pila con tope
			Carta carta = mazo.getMazo().Coleccion[randomUnicoDeInstancia.Next(0,mazo.getMazo().Coleccion.Count-1)];
  			
			mazo.setPila(carta);
			
			Console.WriteLine("A jugar!\n");
		}
		
				
		public override void jugarMano(){
			Console.WriteLine("Se Juega la mano...\n");
			Player ganador = null;
			//this.inicioMano();
			
			ganador = this.inicioMano(ganador);
			this.sumarPuntos(ganador);
					
			//comprobar si hay ganador
			if(this.HayGanador()){
				Console.WriteLine("HAY UN GANADOR.\n");
				//mostrarRESULTADOS
				this.showResult();
				this.showWinner();		
			}	
			else{
				this.jugarMano();
			}
		}
		
	
		private Player inicioMano(Player ganador){
			bool stop=false;
			

			foreach(Player p in players){
				if(!stop){
					ganador=this.jugarE(p, ganador);
					if(p.manoVacia()){
						stop=true;
					}
				}
			}
			if(!stop){
				ganador=this.inicioMano(ganador);
			}	

			return ganador;			
		}
		
		
		private Player jugarE(Player p, Player ganador){						
				p.mostrarMano();
				Console.WriteLine("Pila Mano: "+ mazo.getPila().ToString());
				ganador= p.getMano().jugarMano(p,mazo, ganador);	
				Console.WriteLine("	ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ");
				return p;
		}
			
		public void sumarPuntos(Player jug){
			int sumar=0;	
			foreach(Player p in players){
				if(p!=jug){
					p.setPuntosHand();
					sumar += p.getPuntosHand();
					Console.WriteLine("Puntos de jugadores perdedores:");
					Console.WriteLine("\tEl jugador {0} tiene {1} puntos.\n",p.getName(),p.getPuntosHand());
					p.resetearPuntosHand();
					Console.WriteLine("\tEl jugador {0} tiene {1} puntos.\n",p.getName(),p.getPuntosHand());
				}		
			}
			jug.setPuntosTotal(sumar);
			Console.WriteLine("Punto de jugador ganador de la mano:\n\tEl jugador {0} tiene {1} puntos ACUMULADOS.\n",jug.getName(),jug.getPuntosTotal());
		}
		
		
		public override bool HayGanador(){
			bool winner=false;
			foreach(Player p in players){
				if(p.getPuntosTotal()>=500){
					winner=true;
					ganador=p;
				}
			}
			return winner;
		}
		
		
		public void showResult(){
			Console.WriteLine("\nRESULTADOS FINALES: \n");
			foreach(Player p in players){
				Console.WriteLine(p.ToString());
			}
		}
		

		public void showWinner(){
			Console.WriteLine("El ganador es:");
			Console.WriteLine(ganador.ToString());
		}
		
		
	}
}
