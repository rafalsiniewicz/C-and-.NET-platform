using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
	class Program
	{
		static void cw1_1()
		{
			Console.WriteLine("Write some number");
			int n = int.Parse(Console.ReadLine());
			int i;
			int j;

			for (i = 1; i <= n; i++)
			{
				for (j = 1; j <= i; j++)
				{
					Console.Write($"{j}");
				}
				Console.WriteLine("");
			}
			i = 1;
			j = 1;

			while (i <= n)
			{
				j = 1;
				while (j <= i)
				{
					Console.Write($"{j}");
					j++;
				}
				Console.WriteLine("");
				i++;
			}

			i = 1;
			j = 1;

			do
			{
				j = 1;
				do
				{
					Console.Write($"{j}");
					j++;

				} while (j <= i);

				Console.WriteLine("");
				i++;
			} while (i <= n); ;

			/* dla n = 5
			 * 1
			 * 12
			 * 123
			 * 1234
			 * 12345
			 * */

		}

		static void cw1_2()
		{
			Console.WriteLine("Write some number");
			int n = int.Parse(Console.ReadLine());
			int i;
			int j;

			for (i = 1; i <= n; i++)
			{
				for (j = 1; j <= i; j++)
				{
					Console.Write($"{i}");
				}
				Console.WriteLine("");
			}
			i = 1;
			j = 1;

			while (i <= n)
			{
				j = 1;
				while (j <= i)
				{
					Console.Write($"{i}");
					j++;
				}
				Console.WriteLine("");
				i++;
			}

			i = 1;
			j = 1;

			do
			{
				j = 1;
				do
				{
					Console.Write($"{i}");
					j++;

				} while (j <= i);

				Console.WriteLine("");
				i++;
			} while (i <= n); ;

			/* Output dla n = 5:
			 * 1
			 * 22
			 * 333
			 * 4444
			 * 55555
			 * */

		}

		static void cw2()
		{
			Int32 i = 23;
			object o = i;
			i = 123;
			Console.WriteLine(i + ", " + (Int32)o);

			/* Output:
			 * 123, 23
			 * */
			// wypisywane sa wartosci 123, a potem 23, gdyz najpierw wypisujemy i, ktoremu zostalo przypisane 123, a potem
			// wypisujemy 23, ktore zostalo przypisane o, sa to dwa niezalezne obiekty, wiec zmiana i nie wplywa na o

			long j = (long)o;
			Console.WriteLine(i + ", " + (Int32)o + ", " + j);
			// nieobslugiwany wyjatek: System.InvalidCastException: „Określone rzutowanie jest nieprawidłowe.”
			// nie mozna rzutowac typu object na long
		}

		static void cw3()
		{
			Nullable<int> a = null;
			//Console.WriteLine($"{a}");
			// nie mozna wypisac wartosci a: "Uzyto nieprzypisanej zmiennej lokalnej a".
			if (a.HasValue)
			{
				Console.WriteLine($"{a.GetValueOrDefault()}");
			}
			// wartosc 0
			a = 10;
			Console.WriteLine($"{a}");
			// wartosc 10


		}

		static void cw4()
		{
			int? i = null;
			int j = 10;

			Console.WriteLine($"{i < j}");
			Console.WriteLine($"{i > j}");
			Console.WriteLine($"{i == j}");
			/*
			 * False
			 * False
			 * False
			 */

		}

		static void cw5()
		{
			[DllImport("msvcrt.dll")]
			static extern int puts(string c);
			[DllImport("msvcrt.dll")]
			static extern int _flushall();
			puts("Test");
			_flushall();
		}

		public class Stack
		{
			private List<int> items = new List<int>();
			public Stack(List<int> items)
			{
				this.items = new List<int>(items);
			}
			public Stack()
			{

			}
			public void AddItem(int item)
			{
				this.items.Add(item);
			}
			public int DeleteItem()
			{
				int pop_item = items[0];
				items.RemoveAt(0);
				return pop_item;
			}
			public void ShowTheNumberOfItems()
			{
				Console.WriteLine($"Number of items = {items.Count}");
			}
			public void ShowMinItem()
			{
				Console.WriteLine($"Min item = {items.Min()}");
			}
			public void ShowMaxItem()
			{
				Console.WriteLine($"Max item = {items.Max()}");
			}
			public int FindAnItem(int n)
			{
				if (n < items.Count)
				{
					return items[n];
				}
				else
				{
					return -1;
				}
			}
			public void PrintAllItems()
			{
				foreach (int i in items)
				{
					Console.WriteLine($"{i}");
				}
			}
			public void ClearAll()
			{
				items.Clear();
			}
			public List<int> GetStack()
			{
				return items;
			}

		}

		static void cw6()
		{
			List<int> nums1 = new List<int>();
			List<int> nums2 = new List<int>();
			int n = 100;
			Random rand = new Random();
			while (nums1.Count < n)
			{
				int num;
				num = rand.Next(0, 100);
				nums1.Add(num);
				nums2.Add(num);
			}
			Stack stack1 = new Stack(nums1);
			Stack stack2 = new Stack(nums2);
			Stack stack3 = new Stack();

			for (int i = 0; i < n; i++)
			{
				if (stack1.FindAnItem(i) % 2 == 0 && !stack3.GetStack().Contains(stack1.FindAnItem(i)))
				{
					stack3.AddItem(stack1.FindAnItem(i));
				}
				if (stack2.FindAnItem(i) % 2 == 0 && !stack3.GetStack().Contains(stack2.FindAnItem(i)))
				{
					stack3.AddItem(stack2.FindAnItem(i));
				}
			}

			Console.WriteLine("Stack 1");
			for (int i = 0; i < n; i++)
			{
				Console.Write($"{stack1.FindAnItem(i)}, ");
			}
			Console.WriteLine("\nStack 2");
			for (int i = 0; i < n; i++)
			{
				Console.Write($"{stack2.FindAnItem(i)}, ");
			}
			Console.WriteLine("\nStack 3");
			for (int i = 0; i < stack3.GetStack().Count; i++)
			{
				Console.Write($"{stack3.FindAnItem(i)}, ");
			}

			/*Sample output:
			 * Stack 1
				22, 73, 68, 19, 17, 69, 14, 64, 6, 42, 94, 89, 61, 1, 32, 48, 53, 55, 36, 68, 56, 69, 88, 96, 13, 
				39, 98, 9, 88, 11, 94, 5, 26, 60, 16, 98, 54, 3, 29, 76, 59, 78, 21, 47, 78, 93, 50, 94, 47, 59, 
				26, 37, 4, 16, 14, 52, 85, 71, 6, 77, 71, 4, 76, 95, 48, 89, 63, 0, 84, 33, 94, 50, 25, 59, 8, 77, 
				48, 40, 17, 19, 89, 3, 61, 29, 84, 57, 0, 9, 46, 63, 13, 82, 96, 51, 5, 54, 2, 26, 99, 89,
				Stack 2
				22, 73, 68, 19, 17, 69, 14, 64, 6, 42, 94, 89, 61, 1, 32, 48, 53, 55, 36, 68, 56, 69, 88, 96, 13, 
				39, 98, 9, 88, 11, 94, 5, 26, 60, 16, 98, 54, 3, 29, 76, 59, 78, 21, 47, 78, 93, 50, 94, 47, 59, 
				26, 37, 4, 16, 14, 52, 85, 71, 6, 77, 71, 4, 76, 95, 48, 89, 63, 0, 84, 33, 94, 50, 25, 59, 8, 77, 
				48, 40, 17, 19, 89, 3, 61, 29, 84, 57, 0, 9, 46, 63, 13, 82, 96, 51, 5, 54, 2, 26, 99, 89,
				Stack 3
				22, 68, 14, 64, 6, 42, 94, 32, 48, 36, 56, 88, 96, 98, 26, 60, 16, 54, 76, 78, 50, 4, 52, 0, 84, 8, 
				40, 46, 82, 2,
			*/

		}

		public class Matrix
		{
			int[] matrix;
			int cols;
			int rows;

			public Matrix(int cols, int rows, int[] tab)
			{
				matrix = new int[cols * rows];
				this.cols = cols;
				this.rows = rows;
				for (int i = 0; i < tab.Length; i++)
				{
					matrix[i] = tab[i];
				}
				if (cols * rows > tab.Length)
				{
					int n = tab.Length;
					int k = matrix.Length - 1;
					while (n++ < cols * rows)
					{
						matrix[k] = 0;
					}
				}
			}

			public void AddElem(int row, int col, int val)
			{
				if (row * col < matrix.Length)
				{
					this.matrix[row * col] = val;
				}
				else
				{
					Console.WriteLine("Out of range");
				}
			}

			public int GetNumberOfRows()
			{
				return this.rows;
			}
			public int GetNumberOfCols()
			{
				return this.cols;
			}

			public int[] GetMatrix()
			{
				return this.matrix;
			}

			public static int[] AddMatrix(Matrix m1, Matrix m2)
			{
				int max_dim = Math.Max(Math.Max(m2.cols, m2.rows), Math.Max(m1.cols, m1.rows));
				int[] m = new int[max_dim];
				for (int i = 0; i < max_dim; i++)
				{
					m[i] = m1.GetMatrix()[i] + m2.GetMatrix()[i];
				}
				return m;

			}
		}

		static void cw7()
		{
			int[] tab1 = new int[4] { 1, 2, 3, 4 };
			int[] tab2 = new int[4] { 5, 6, 7, 8 };
			Matrix m1 = new Matrix(2, 2, tab1);
			Matrix m2 = new Matrix(2, 2, tab2);
			int[] m3 = new int[4];
			Console.WriteLine("Matrix 1");
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					Console.Write($"{m1.GetMatrix()[2*i + j]}, ");
				}
				Console.WriteLine();

			}
			Console.WriteLine("Matrix 2");
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					Console.Write($"{m2.GetMatrix()[2*i + j]}, ");
				}
				Console.WriteLine();

			}
			Console.WriteLine($"Matrix 3 {m3.Length}");
			m3 = Matrix.AddMatrix(m1, m2);
			Console.WriteLine($"Matrix 3 {m3.Length}");
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					Console.Write($"{m3[i + j]}, ");
				}
				Console.WriteLine();

			}

		}

		public class Matrix2
		{
			public int[,] matrix { get; set; }
			public int cols { get; set; }
			public int rows { get; set; }

			public Matrix2(int cols, int rows, int[] tab)
			{
				matrix = new int[rows, cols];
				this.cols = cols;
				this.rows = rows;
				for (int i = 0; i < rows; i++)
				{
					for (int j = 0; j < cols; j++)
					{
						if (i * cols + j < tab.Length)
						{
							matrix[i, j] = tab[i * cols + j];
						}
						else
						{
							matrix[i, j] = 0;
						}
					}
				}

			}

		}


		static void cw8()
		{
			int[] tab1 = new int[4] { 1, 2, 3, 4 };
			int[] tab2 = new int[4] { 5, 6, 7, 8 };
			Matrix2 m1 = new Matrix2(2,2,tab1);
			Matrix2 m2 = new Matrix2(2, 2, tab2);
			int[] tab3 = new int[4] { -1,-1,-1,-1};
			Matrix2 m3 = new Matrix2(2, 2, tab3);
			Matrix2 m4 = new Matrix2(2, 2, tab3);
			Console.WriteLine("Matrix 1");
			for (int i = 0; i < m1.rows; i++)
			{
				for (int j = 0; j < m1.cols; j++)
				{
					Console.Write($"{m1.matrix[i,j]}, ");
				}
				Console.WriteLine();
			}
			Console.WriteLine("Matrix 2");
			for (int i = 0; i < m2.rows; i++)
			{
				for (int j = 0; j < m2.cols; j++)
				{
					Console.Write($"{m2.matrix[i, j]}, ");
				}
				Console.WriteLine();
			}
			for (int i = 0; i < m1.rows; i++)
			{
				for (int j = 0; j < m1.cols; j++)
				{
					m3.matrix[i, j] = m1.matrix[i, j] + m2.matrix[i, j];
				}
				Console.WriteLine();
			}
			Console.WriteLine("Matrix 3");
			for (int i = 0; i < m3.rows; i++)
			{
				for (int j = 0; j < m3.cols; j++)
				{
					Console.Write($"{m3.matrix[i, j]}, ");
				}
				Console.WriteLine();
			}
			for (int i = 0; i < m1.rows; i++)
			{
				for (int j = 0; j < m1.cols; j++)
				{
					m4.matrix[i, j] = m1.matrix[i, j] - m2.matrix[i, j];
				}
				Console.WriteLine();
			}
			Console.WriteLine("Matrix 4");
			for (int i = 0; i < m4.rows; i++)
			{
				for (int j = 0; j < m4.cols; j++)
				{
					Console.Write($"{m4.matrix[i, j]}, ");
				}
				Console.WriteLine();
			}

		}

		public class Book 
		{ 
			string title; 
			string author; 
			double price; 
			string isbn; 
			DateTime date;

			public Book()
			{

			}
			public Book(string title, string author, double price, string isbn, DateTime date)
			{
				this.title = title;
				this.author = author;
				this.price = price;
				this.isbn = isbn;
				this.date = date;
			}
			public string GetIsbn()
			{
				return this.isbn;
			}
			public string GetTitle()
			{
				return this.title;
			}
			public string GetAuthor()
			{
				return this.author;
			}
			public double GetPrice()
			{
				return this.price;
			}
			public DateTime GetDate()
			{
				return this.date;
			}
		}

		public sealed class BookLibrary
		{
			private static BookLibrary m_oInstance = null;
			private int m_nCounter = 0;
			private List<Book> bl = new List<Book>();

			public static BookLibrary Instance
			{
				get
				{
					if (m_oInstance == null)
					{
						m_oInstance = new BookLibrary();
					}
					return m_oInstance;
				}
			}
			private BookLibrary()
			{
				m_nCounter = 1;
			}
			public void Add(Book b)
			{
				foreach (Book var in this.bl)
				{
					if (var.GetIsbn().Equals(b.GetIsbn()))
					{
						Console.WriteLine("Book with this isbn already exists!");
						
					}
				}
				Console.WriteLine("Adding {0} to library", b.GetTitle());
				this.bl.Add(b);

			}
			public void Remove(Book b)
			{
				this.bl.Remove(b);
			}
			public void ShowAll()
			{
				Console.WriteLine("############### Books in library ###############");
				foreach (Book var in this.bl)
				{
					Console.WriteLine("Book: ");
					Console.WriteLine("title: {0}", var.GetTitle());
					Console.WriteLine("author: {0}", var.GetAuthor());
					Console.WriteLine("price: {0}", var.GetPrice());
					Console.WriteLine("isbn: {0}", var.GetIsbn());
					Console.WriteLine("date: {0}", var.GetDate());
				}
				Console.WriteLine("################################################");
			}

			public bool CheckIfExist(Book b)
			{
				foreach (Book var in this.bl)
				{
					if (var == b)
					{
						return true;
					}
				}
				return false;
			}
			public Book SearchByIsbn(string isbn)
			{
				foreach (Book var in this.bl)
				{
					if (var.GetIsbn().Equals(isbn))
					{
						return var;
					}
				}
				return null;
			}
			public Book SearchByAuthor(string author)
			{
				foreach (Book var in this.bl)
				{
					if (var.GetAuthor().Equals(author))
					{
						return var;
					}
				}
				return null;
			}
			public Book SearchByTitle(string title)
			{
				Book n = null;
				foreach (Book var in this.bl)
				{
					if (var.GetTitle().Equals(title))
					{
						return var;
					}
				}
				return null;
			}
			public Book SearchByPrice(double price)
			{
				Book n = null;
				foreach (Book var in this.bl)
				{
					if (var.GetPrice() == price)
					{
						return var;
					}
				}
				return null;
			}
		}

		static void cw9()
		{
			Book b1 = new Book("The Grass is Always Greener", "Jeffrey Archer", 30.5, "1-86092-049-7", new DateTime(2008, 5, 1, 8, 30, 52));
			Book b2 = new Book("Murder!", "Arnold Bennett", 20, "1-86092-012-8", new DateTime(2008, 5, 1, 8, 30, 52));
			Book b3 = new Book("An Occurrence at Owl Creek Bridge One of the Missing", "Ambrose Bierce", 100, "1-86092-006-3", new DateTime(2008, 5, 1, 8, 30, 52));
			Book b4 = new Book("A Boy at Seven", "John Bidwell", 21, "1-86092-022-5", new DateTime(2008, 5, 1, 8, 30, 52));
			Book b5 = new Book("The Higgler", "A. E. Coppard", 50.1, "1-86092-010-1", new DateTime(2008, 5, 1, 8, 30, 52));
			Book b6 = new Book("The Open Boat", "Stephen Crane", 45.8, "1-86092-025-x", new DateTime(2008, 5, 1, 8, 30, 52));
			Book b7 = new Book("The Open Boat", "Stephen Crane", 45.8, "1-86092-025-x", new DateTime(2008, 5, 1, 8, 30, 52)); //the same isbn
			
			BookLibrary.Instance.Add(b1);
			BookLibrary.Instance.Add(b2);
			BookLibrary.Instance.Add(b3);
			BookLibrary.Instance.Add(b4);
			BookLibrary.Instance.Add(b5);
			BookLibrary.Instance.Add(b6);
			BookLibrary.Instance.Add(b7);

			BookLibrary.Instance.ShowAll();
			BookLibrary.Instance.Remove(b2);
			BookLibrary.Instance.ShowAll();

			Console.WriteLine($"Title = {BookLibrary.Instance.SearchByPrice(50.1).GetTitle()}");

			/*
			 * Adding The Grass is Always Greener to library
				Adding Murder! to library
				Adding An Occurrence at Owl Creek Bridge One of the Missing to library
				Adding A Boy at Seven to library
				Adding The Higgler to library
				Adding The Open Boat to library
				Book with this isbn already exists!
				Adding The Open Boat to library
				############### Books in library ###############
				Book:
				title: The Grass is Always Greener
				author: Jeffrey Archer
				price: 30,5
				isbn: 1-86092-049-7
				date: 01.05.2008 08:30:52
				Book:
				title: Murder!
				author: Arnold Bennett
				price: 20
				isbn: 1-86092-012-8
				date: 01.05.2008 08:30:52
				Book:
				title: An Occurrence at Owl Creek Bridge One of the Missing
				author: Ambrose Bierce
				price: 100
				isbn: 1-86092-006-3
				date: 01.05.2008 08:30:52
				Book:
				title: A Boy at Seven
				author: John Bidwell
				price: 21
				isbn: 1-86092-022-5
				date: 01.05.2008 08:30:52
				Book:
				title: The Higgler
				author: A. E. Coppard
				price: 50,1
				isbn: 1-86092-010-1
				date: 01.05.2008 08:30:52
				Book:
				title: The Open Boat
				author: Stephen Crane
				price: 45,8
				isbn: 1-86092-025-x
				date: 01.05.2008 08:30:52
				Book:
				title: The Open Boat
				author: Stephen Crane
				price: 45,8
				isbn: 1-86092-025-x
				date: 01.05.2008 08:30:52
				################################################
				############### Books in library ###############
				Book:
				title: The Grass is Always Greener
				author: Jeffrey Archer
				price: 30,5
				isbn: 1-86092-049-7
				date: 01.05.2008 08:30:52
				Book:
				title: An Occurrence at Owl Creek Bridge One of the Missing
				author: Ambrose Bierce
				price: 100
				isbn: 1-86092-006-3
				date: 01.05.2008 08:30:52
				Book:
				title: A Boy at Seven
				author: John Bidwell
				price: 21
				isbn: 1-86092-022-5
				date: 01.05.2008 08:30:52
				Book:
				title: The Higgler
				author: A. E. Coppard
				price: 50,1
				isbn: 1-86092-010-1
				date: 01.05.2008 08:30:52
				Book:
				title: The Open Boat
				author: Stephen Crane
				price: 45,8
				isbn: 1-86092-025-x
				date: 01.05.2008 08:30:52
				Book:
				title: The Open Boat
				author: Stephen Crane
				price: 45,8
				isbn: 1-86092-025-x
				date: 01.05.2008 08:30:52
				################################################
				Title = The Higgler
				 */

		}

		static void Main(string[] args)
		{
			//cw1_1();
			//cw1_2();
			//cw2();
			//cw3();
			//cw4();
			//cw5();
			//cw6();
			//cw7();
			//cw8();
			//cw9();
			Console.ReadKey();
		}
	}
}
