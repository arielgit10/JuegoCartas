
using System;

namespace JuegosDeCartas
{

	public class GeneradorDeDatosAleatorios
	{
		private static GeneradorDeDatosAleatorios genera = null;
		private Random randomUnicoDeInstancia = new Random();
		private string [] letras;
		private string estring;
		
		private GeneradorDeDatosAleatorios(Random r = null)
		{
			if(r != null){
				randomUnicoDeInstancia = r;
			}
			letras = new string[] {"q","w","e","r","t","y","u","i","o","p","a","s","d","f","g","h","j","k","l","ñ","z","x","c","v","b","n","m"};	
		}
		
		
		public static GeneradorDeDatosAleatorios getInstance(){
			if(genera==null){
				genera=new GeneradorDeDatosAleatorios();
			}
			return genera;
		}
		
	
		public int numeroAleatorio(int maximo){
			return randomUnicoDeInstancia.Next(0,maximo+1);
		}
		
		public string stringAleatorio(int cantidad){
				for(int i=0;i<cantidad;i++){
					estring+=letras[randomUnicoDeInstancia.Next(0,letras.Length-1)];
				}
				return estring;
		}
		
			
	}
}
