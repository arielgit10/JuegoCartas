
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
					Carta card = mazo.getMazo().getColeccion()[randomUnicoDeInstancia.Next(0,mazo.getMazo().getColeccion().Count-1)];
					p.getMano().agregarCarta(card);				
					mazo.getMazo().eliminarCarta(card);
				}
			}
			//setear pila con tope
			Carta carta = mazo.getMazo().getColeccion()[randomUnicoDeInstancia.Next(0,mazo.getMazo().getColeccion().Count-1)];
			mazo.setPila(carta);
			mazo.getMazo().eliminarCarta(carta);
			
			Console.WriteLine("A jugar!\n");
		}
		
				
		public override void jugarMano(){
			Console.WriteLine("Se Juega la mano...\n");
			Player ganador = null;
			
			ganador = this.inicioMano(ganador);
			this.sumarPuntos(ganador);
					
			//comprobar si hay ganador
			if(this.HayGanador()){
				Console.WriteLine("HAY UN GANADOR.\n");
				this.showResult();
				this.showWinner();		
			}	
			else{
				this.resetear();
				this.jugarMano();
			}
		}
				
		private void resetear(){
			foreach(Player p in players){
				p.getMano().limpiar();
			}
			this.mazo.setPila(null);
			if(mazo.getPila() == null){
				Console.WriteLine("Pila en null");
			}
			else{
				Console.WriteLine("Pila seteada: VALOR {0}", mazo.getPila().ToString());
			}
			this.mazo.setMonton();
			Console.WriteLine("Monton seteado: Largo {0}", mazo.getMonton().getColeccion().Count);
			this.mazo.limpiarMazo();
			Console.WriteLine("Mazo limpiado: Largo {0}", mazo.getMazo().getColeccion().Count);
			this.mazo.llenar();
			Console.WriteLine("Mazo lleno: Largo {0}", mazo.getMazo().getColeccion().Count);
			this.repartir();
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
				Console.WriteLine("\t**********************************\t");
				return p;
		}
			
	
		private void sumarPuntos(Player jug){
			int sumar=0;		
			this.puntosTotales();
			Console.WriteLine("Puntos de la mano:\n");	
			foreach(Player p in players){
				p.setPuntosHand();
				Console.WriteLine("\tEl jugador {0} tiene {1} puntos.\n",p.getName(),p.getPuntosHand());				
				if(p!=jug){							
					sumar += p.getPuntosHand();
				}
				p.resetearPuntosHand();
			}
			jug.setPuntosTotal(sumar);
			Console.WriteLine("PUNTOS DEL JUGADOR GANADOR DE LA MANO:\n\tEL JUGADOR {0} TIENE {1} PUNTOS ACUMULADOS.\n",jug.getName(),jug.getPuntosTotal());
		}
		
		private void puntosTotales(){
			Console.WriteLine("Puntos Totales de los jugadores:\n");
			foreach(Player p in players){
				Console.WriteLine("El jugador {0} tiene {1} puntos totales.\n",p.getName(),p.getPuntosTotal());
			}
		}
				
		public override bool HayGanador(){
			bool winner=false;
			foreach(Player p in players){
				if(p.getPuntosTotal()>=100){
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
