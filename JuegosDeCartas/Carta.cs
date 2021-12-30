
using System;

namespace JuegosDeCartas
{

	public class Carta
	{
		
		private string color;
		private int valor;
		
		public Carta(string color,int valor)
		{
			this.color=color;
			this.valor=valor;
		}
		
		public int getValor(){
			return valor;
		}
		public string getColor(){
			return color;
		}
		
		public override string ToString()
		{
			return string.Format("Carta Color={0}, Valor={1}", color, valor);
		}

		
	}
}
