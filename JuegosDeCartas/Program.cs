
using System;

namespace JuegosDeCartas
{
	class Program
	{
		public static void Main(string[] args)
		{
					
			Uno uno = new Uno();
			uno.jugar();
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}