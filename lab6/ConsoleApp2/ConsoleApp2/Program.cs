using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	// 1
	public class Tree
	{
		private string name;
		private int age;
	}

	public class Fir : Tree
	{
		protected class Bauble
		{
			private string color;
			private string type;

			public Bauble(string color, string type)
			{
				this.color = color;
				this.type = type;
			}

			public string GetColor()
			{
				return this.color;
			}
			public string GetType()
			{
				return this.type;
			}
		}
		protected List<Bauble> bubbles = new List<Bauble>();
		

		protected void Add(string color, string type)
		{
			bubbles.Add(new Bauble(color, type));
		}

		protected void Remove(int index)
		{
			this.bubbles.RemoveAt(index);

		}
		protected string this[int i]
		{
			get { return bubbles[i].GetColor(); }
			set
			{
				string c = bubbles[Convert.ToInt32(i)].GetColor();
				c = value;
			}
		}
		protected int this[string color]
		{
			get 
			{
				int n = 0;
				foreach (Bauble b in bubbles)
				{
					if (b.GetColor().Equals(color))
					{
						n++;
					}
				}
				return n; 
			}
		}

	}

	public class ChristmasTree: Fir
	{


	}
	//2
	public class ChristmasTreeA : ChristmasTree
	{
		protected string this[int i]
		{
			get { return bubbles[i].GetType(); }
		}

		string BaubleColor(int index)
		{
			return this[index];
		}
	}
	// 3
	public class ChristmasTreeB : ChristmasTreeA
	{
		protected string this[int i]
		{
			get { return bubbles[i].GetColor() + "_" + bubbles[i].GetType(); }
		}
	}
	// 4
	// slowo kluczowe sealed powoduje, ze nie mozna dziedziczyc po klasie
	sealed class ChristmasTreeC : ChristmasTreeB
	{
	}
	// 5
	// musi byc klasa abstrakcyjna, zeby miec metode abstrakcyjna
	// metoda abstrakcyjna nie jest zdefiniowana, wiec wymusza na klasach dziedziczacych zdefiniowanie tej funkcji
	abstract class Home
	{
		private int price;
		public abstract int getPrice();

	}
	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
