using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
	class Program
	{
		class ThreadExample
		{ 
			static void Main()
			{
				Thread t = new Thread(Write1); //Uruchom inny  wątek       
				t.Start();                               
				// Główny wątek.
				for (int i = 0; i < 1000; i++) 
					Console.Write ("0");

				Console.ReadKey();
			}   
			//Inny wątek  
			static void Write1()   
			{ 
				for (int i = 0; i < 1000; i++) 
					Console.Write ("1");   
			} 
		}

		class ThreadTest
		{ 
			bool done; 
			static void Main() 
			{
				ThreadTest tt = new ThreadTest(); 
				new Thread(tt.Run).Start(); 
				tt.Run();
				Console.ReadKey();
			} 
			// Zauważ, że Run jest teraz metodą instancji
			void Run()    
			{
				if (!done) 
				{ 
					done = true; 
					Console.WriteLine ("Done"); 
				}   
			} 
		}

		class ThreadExample2
		{ 
			static bool done;    // Pole statyczne
			static readonly object locker = new object();
			static void Main()   
			{ 
				new Thread (Run).Start();     
				Run();
				Console.ReadKey();
			} 
			static void Run()   
			{
				lock (locker)
				{
					done = true;
					Console.WriteLine("Done"); 
					 
				}
			} 
		}
		class Matrix
		{
			static int sum = 0;
			static void Main()
			{
				int[,] arr1 = new int[,] { { 1, 2 }, { 3, 4 } };
				int[,] arr2 = new int[,] { { 5, 6 }, { 7, 8 } };
				int[,] arr3 = new int[,] { { 9, 10 }, { 11, 12 } };
				int[,] arr4 = new int[,] { { 13, 14 }, { 15, 16 } };
				int[,] arr5 = new int[,] { { 17, 18 }, { 19, 20 } };
				Thread t1 = new Thread(() => calculate_sum(arr1));
				Thread t2 = new Thread(() => calculate_sum(arr2));
				Thread t3 = new Thread(() => calculate_sum(arr3));
				Thread t4 = new Thread(() => calculate_sum(arr4));
				Thread t5 = new Thread(() => calculate_sum(arr5));

				t1.Start();
				t1.Join();
				t2.Start();
				t2.Join();
				t3.Start();
				t3.Join();
				t4.Start();
				t4.Join();
				t5.Start();
				t5.Join();

				Console.WriteLine("All threads joined");
				Console.WriteLine(sum);
				Console.ReadKey();
			}
			static void calculate_sum(int[,] arr)
			{
				for (int i = 0; i < arr.GetLength(0); i++)
				{
					for (int j = 0; j < arr.GetLength(1); j++)
					{
						sum += arr[i, j];
						//Console.WriteLine(sum);
					}
				}
			}
		}
		

		static void Main(string[] args)
		{
			/*new Thread(Run).Start();      // Uruchom Run w innym wątku  
			Run();                         // Uruchom Run w głownym wątku
			Console.ReadKey();*/
			/*Thread t = new Thread(Run); 
			t.Start(); 
			//t.Join(); 
			Console.WriteLine("Thread t has ended!");
			Console.ReadKey();*/
		}
		/*static void Run()
		{ 
			// Deklaracja i użycie zmiennej lokalnej - 'cycles'
			for (int cycles = 0; cycles < 5; cycles++) 
				Console.Write ('x'); 
		}*/
		static void Run() 
		{ 
			for (int i = 0; i < 777; i++) 
				Console.Write(""); 
		}
	}
}
