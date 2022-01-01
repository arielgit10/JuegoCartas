
using System;

namespace JuegosDeCartas
{
	class Program
	{
		public static void Main(string[] args)
		{
				
//			GeneradorDeDatosAleatorios genera = GeneradorDeDatosAleatorios.getInstance();
//			//no me genera 40 numero diferentes, por que
//			for(int i=0;i<40;i++){
//				Console.WriteLine(genera.numeroAleatorio(39));
//			}
//			

			
			Uno uno = new Uno();
			uno.jugar();
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}