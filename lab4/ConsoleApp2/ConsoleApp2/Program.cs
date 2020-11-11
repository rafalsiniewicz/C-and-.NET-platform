using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		public static void cw1()
		{
			/*void Fun1(in int i) 
			{
				i += 5;
			}
			void Fun2(out int i)
			{
				i += 5;
			}*/
			void Fun3(ref int i) 
			{
				i += 5;
			}
			void Fun4(int i) 
			{
				i += 5;
			}
			/*void Fun5(in int i)
			{
				i += 5;
			}
			void Fun5(out int i)
			{
				i += 5;
			}*/
			int x = 2;
			short y = 3;
			//Fun1(x);
			Console.WriteLine($"{x}");
			//Fun2(out x);
			Console.WriteLine($"{x}");
			Fun3(ref x);
			Console.WriteLine($"{x}");
			Fun4(x);
			Console.WriteLine($"{x}");
			//Fun1(y);
			//Fun2(out y);
			//Fun3(ref y);
			Fun4(y);

		}

		public class Point
		{
			public int x, y;
			public Point(int p1, int p2)
			{
				x = p1;
				y = p2;
			}
		}
		public static void cw1_2()
		{
			void Fun5(Point p) 
			{
				Point p2 = new Point(0, 0);
				p = p2;
			}

			void Fun6(ref Point p)
			{
				Point p2 = new Point(0, 0);
				p = p2;
			}

			Point p3 = new Point(1, 2);
			Console.WriteLine($"{p3.x}, {p3.y}");
			Fun5(p3);
			Console.WriteLine($"{p3.x}, {p3.y}");
			Fun6(ref p3);
			Console.WriteLine($"{p3.x}, {p3.y}");

			//c
			p3 = null;

			//d
			//Console.WriteLine($"{p3.x}, {p3.y}");
			//Fun5(p3);
			//Console.WriteLine($"{p3.x}, {p3.y}");
			Fun6(ref p3);
			Console.WriteLine($"{p3.x}, {p3.y}");

		}

		/*class TestPointer
		{
			public unsafe static void Main()
			{
				int[] list = { 10, 100, 200 };
				fixed (int* ptr = list)
					for (int i = 0; i < 3; i++)
					{
						Console.WriteLine("Adres [{0}]={1}", i, (int)(ptr + i));
						Console.WriteLine("Wartość[{0}]={1}", i, *(ptr + i));
					}
				Console.ReadKey();
			}
		}*/
		public static unsafe void swap(int* p, int* q) 
		{ 
			int temp = *p; 
			*p = *q; 
			*q = temp; 
		}

		public static unsafe void cw2()
		{
			/*TestPointer t = new TestPointer();
			TestPointer.Main();*/
			int a = 5; 
			int b = 6;
			
			Console.WriteLine($"{a}, {b}");
			swap(&a, &b);
			Console.WriteLine($"{a}, {b}");
			
		}

		public unsafe static void cw2_3()
		{
			int* buf = stackalloc int[1024];
			for (int i = 0; i < 1024; i++)
			{
				*(buf + i) = i;
				Console.WriteLine($"{*(buf + i)}");
			}
		}

		public static void cw3()
		{
			int n = int.Parse(Console.ReadLine());
			int size = 10;
			int[] buf = new int[size];
			for (int i = 0; i < size; i++)
				buf[i] = i;
			foreach (int i in buf)
				Console.Write($"{i} ");
			Console.WriteLine("");
			size++;
			Array.Resize(ref buf, size);
			for (int i = size - 1; i > 0 ; i--)
			{
				buf[i] = buf[i-1];
			}
			buf[0] = n;
			foreach (int i in buf)
				Console.Write($"{i} ");
		}

		public static void cw4()
		{
			int size = 5;
			int[] buf = new int[size];
			for (int i = 0; i < size; i++)
			{
				int n = int.Parse(Console.ReadLine());
				buf[i] = n;
			}
			for (int i = size - 1; i >= 0; i--)
			{
				Console.Write(buf[i]);
			}

		}

		public static void cw5()
		{
			int[] buf = { 1, 2, 3, 4, 2 };
			List<int> repeated_nums = new List<int>();

			for (int i = 0; i < buf.Length; i++)
			{
				for (int j = i + 1; j < buf.Length; j++)
				{
					if (buf[j] == buf[i] && !repeated_nums.Contains(buf[j]))
					{
						repeated_nums.Add(buf[j]);
					}
				}

			}


			Console.WriteLine($"Number of repeated numbers = {repeated_nums.Count}");

		}

		public static void cw6()
		{
			const int n = 5;
			int[,] t1 = new int[n, n] {
				{0, 1, 2, 3, 8} ,   
				{4, 5, 6, 7, 1} ,   
				{8, 9, 10, 11, 2},
				{2, 3, 1, 4, 2},
				{4, 5, 6, 8, 2}
			};

			int[,] t2 = new int[n, n] {
				{8, 9, 10, 11, 2},
				{4, 5, 6, 7, 1} ,
				{2, 3, 1, 4, 2},
				{0, 1, 2, 3, 8} ,
				{4, 5, 6, 8, 2}
			};

			int[,] t3 = new int[n, n];
			for (int row = 0; row < n; row++)
			{
				for (int col = 0; col < n; col++)
				{
					t3[row, col] = t1[row, col] + t2[row, col];
				}

			}
			Console.WriteLine("t1");
			for (int row = 0; row < n; row++)
			{
				for (int col = 0; col < n; col++)
					Console.Write(String.Format("{0}\t", t1[row, col]));
				Console.WriteLine();
			}

			Console.WriteLine("t2");
			for (int row = 0; row < n; row++)
			{
				for (int col = 0; col < n; col++)
					Console.Write(String.Format("{0}\t", t2[row, col]));
				Console.WriteLine();
			}

			Console.WriteLine("t3");
			for (int row = 0; row < n; row++)
			{
				for (int col = 0; col < n; col++)
					Console.Write(String.Format("{0}\t", t3[row, col]));
				Console.WriteLine();
			}

			Console.WriteLine($"t3.Length = {t3.Length},  t3.LongLength = {t3.LongLength}, t3.Rank = {t3.Rank}");

		}

		public static void cw7()
		{
			const int n = 3;
			int[,] m = new int[n, n] {
				{1, 0, -1} ,
				{0, 0, 1} ,
				{-1, -1, 0}
			};

			int det = m[0, 0] * m[1, 1] * m[2, 2] + m[0, 1] * m[1, 2] * m[2, 0] + m[0, 2] * m[1, 0] * m[2, 1]
				- (m[0, 2] * m[1, 1] * m[2, 0] + m[0, 1] * m[1, 0] * m[2, 2] + m[0, 0] * m[1, 2] * m[2, 1]);

			Console.WriteLine("m");
			for (int row = 0; row < n; row++)
			{
				for (int col = 0; col < n; col++)
					Console.Write(String.Format("{0}\t", m[row, col]));
				Console.WriteLine();
			}

			Console.WriteLine($"det(m) = {det}");

		}

		public static void cw8()
		{
			int[][] arr = new int[5][];

			// Initialize the elements.
			arr[0] = new int[3] { 1, 2, 3 };
			arr[1] = new int[6] { 4, 5, 6, 7, 8, 9 };
			arr[2] = new int[4] { 10, 11, 12, 13 };
			arr[3] = new int[5] { 14, 15, 16, 17, 18 };
			arr[4] = new int[3] { 19, 20, 21 };

			for (int i = 0; i < arr.Length; i++)
			{
				System.Console.Write("Element({0}): ", i);

				for (int j = 0; j < arr[i].Length; j++)
				{
					System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
				}
				System.Console.WriteLine();
			}

			// 2nd option

			int[][] arr2 =
			{
				new int[] { 1, 2, 3 },
				new int[] { 4, 5, 6, 7, 8, 9 },
				new int[] { 10, 11, 12, 13 },
				new int[] { 14, 15, 16, 17, 18 },
				new int[] { 19, 20, 21 }
			};

			for (int i = 0; i < arr2.Length; i++)
			{
				System.Console.Write("Element({0}): ", i);

				for (int j = 0; j < arr2[i].Length; j++)
				{
					System.Console.Write("{0}{1}", arr2[i][j], j == (arr2[i].Length - 1) ? "" : " ");
				}
				System.Console.WriteLine();
			}

		}
			static void Main(string[] args)
		{
			//cw1();
			//cw1_2();
			//cw2();
			//cw2_3();
			//cw3();
			//cw4();
			//cw5();
			//cw6();
			//cw7();
			cw8();
			Console.ReadKey();
		}
	}
}
