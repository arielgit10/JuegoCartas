
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
					p.setMano(card);
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
			jugarE();

			
			//this.jugarE();
//			foreach(Player p in players){				
//					List<Carta> mano = p.turnoJugar(mazo);	
//					if(!p.manoVacia()){
//						this.jugarMano();
//					}					
//			}	
			
			//sumar puntos LUEGO DE QUE ALGUNO SE HAYA QUEDADO SIN CARTAS... COMO HACERLO
			this.sumarPuntos();
//			
//			Console.WriteLine("RESULTADOS");
//			this.showResult();
			
			//comprobar si hay ganador
			if(this.HayGanador()){
				Console.WriteLine("HAY UN GANADOR");
				//mostrarRESULTADOS
				this.showResult();
				this.showWinner();
				//break;
			//	break;			
			}	
//			//if(!p.manoVacia()){
//				this.jugarMano();
//			//}
		}
		
		
		public void jugarE(){
			foreach(Player p in players){				
				if(p.manoVacia()){
					break;
				}	
				else{
					List<Carta> mano = p.turnoJugar(mazo);
				}
			}
			Console.WriteLine("	ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ");
			this.jugarE();
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
