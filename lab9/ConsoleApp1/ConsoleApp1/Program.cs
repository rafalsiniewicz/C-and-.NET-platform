using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
	class Program
	{
		public static void cw1()
		{
			string[] slowa = new string[]
			{ 
			// Indeks		od początku      od końca
			"Już północ",			// 0          ^10
			"cień",					// 1           ^9
			"ponury",				// 2           ^8
			"pół",					// 3           ^7
			"świata",				// 4           ^6
			"okrywa",				// 5           ^5
			"A jeszcze",			// 6           ^4
			"serce",				// 7           ^3
			"zmysłom",				// 8           ^2 
			"spoczynku nie daje"    // 9           ^1 
									// 10(słowa.Lenght) ^0
			};
			//1 
			Console.WriteLine($"{slowa[^1]}");
			//2 
			string[] sonet1 = slowa[2..6];
			foreach (var slowo in sonet1)
				Console.Write($"< {slowo} >");
			Console.WriteLine();

			//3
			string[] sonet2 = slowa[^3..^0];
			foreach (var slowo in sonet2)
				Console.Write($"{slowo}");
			Console.WriteLine();

			//4
			string[] sonet3 = slowa[..];
			string[] sonet4 = slowa[..5];
			string[] sonet5 = slowa[7..];

			//5 
			Index stri = ^5;
			Console.WriteLine(slowa[stri]);

			//6
			Range fraza = 2..7;
			string[] tekst = slowa[fraza];
			foreach (var slowo in tekst)
				Console.Write($" {slowo} ");
			Console.WriteLine();

		}
		public delegate void OD();  // delegate
		public delegate void OC();  // delegate
		public static event OD OnDigit = new OD(show_d);    // event
		public static event OC OnCharacter = new OC(show_c);    // event
		public static void show_d()
		{
			Console.WriteLine("\nNaciśnięto cyfrę!");
		}
		public static void show_c()
		{
			Console.WriteLine("\nNaciśnięto literę!");
		}
		public static void cw2()
		{
			char c;
			do
			{
				c = Console.ReadKey().KeyChar;
				if (Char.IsDigit(c)) { OnDigit(); }	//wywolaj event OnDigit
				else if (Char.IsLetter(c)) { OnCharacter(); }	//wywolaj event OnCharacter
				else { break; }


			} while (true);


		}
		public class DisposeObject : IDisposable
		{
			protected bool disposed = false;
			private IntPtr handle = System.Runtime.InteropServices.Marshal.AllocHGlobal(20);
			private Component components;
			~DisposeObject()
			{
				Dispose(false);

			}
			public void Dispose()
			{
				Dispose(true);
				GC.SuppressFinalize(this);

			}
			protected virtual void Dispose(bool disposing)
			{
				if (!disposed)
				{
					if (disposing)
					{
						components.Dispose();
					}
					System.Runtime.InteropServices.Marshal.FreeHGlobal(handle);
				}
				disposed = true;
			}


		}
		public static void cw3()
		{

		}
		static void Main(string[] args)
		{
			//cw1();
			//cw2();
			//cw3();
			// Console.ReadKey();
		}
	}
}
