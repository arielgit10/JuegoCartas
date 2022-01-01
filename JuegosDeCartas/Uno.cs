
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
		//	players.Add(new Player("GGGGG"));
		}
		
		
		public override void mezclar(){
			Console.WriteLine("Se mezclan las cartas...");
		}

		
		public override void repartir(){
			Console.WriteLine("Se reparten las cartas...");
			
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
			
			Console.WriteLine("A jugar!");
		}
		
				
		public override void jugarMano(){
			Console.WriteLine("Se JUega la mano...");
		
			this.inicioMano();
			this.sumarPuntos();
					
			//comprobar si hay ganador
			if(this.HayGanador()){
				Console.WriteLine("HAY UN GANADOR");
				//mostrarRESULTADOS
				this.showResult();
				this.showWinner();		
			}	
//			else{
//				this.jugarMano();
//			}
		}
		
	
		private void inicioMano(){
			bool stop=false;
			
			foreach(Player p in players){
				if(!stop){
					this.jugarE(p);
					if(p.manoVacia()){
						stop=true;
					}
				}
			}
			if(!stop){
				this.inicioMano();
			}		
		}
			
		private void jugarE(Player p){						
				p.mostrarMano();
				Console.WriteLine("Pila Mano: "+ mazo.getPila().ToString());
				p.getMano().jugarMano(p,mazo);	
			Console.WriteLine("	ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ");
		}
		
		
		public void sumarPuntos(){
			foreach(Player p in players){
				p.sumar();
				Console.WriteLine("El jugador {0} tiene {1} puntos.",p.getName(),p.getPuntos());
			}	
		}
		
		
		public override bool HayGanador(){
			bool winner=false;
			foreach(Player p in players){
				if(p.getPuntos()>=500){
					winner=true;
					ganador=p;
				}
			}
				
			return winner;
		}
		
		
		public void showResult(){
			Console.WriteLine("RESULTADOS FINALES: ");
			foreach(Player p in players){
				Console.WriteLine(p.ToString());
				Console.WriteLine();Console.WriteLine();
			}

		}
		

		public void showWinner(){
			Console.WriteLine(ganador.ToString());
			Console.WriteLine();Console.WriteLine();
		}
		
		
	}
}
