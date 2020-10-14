using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja1
{
	class Program
	{
		static void cw2_1()
		{
			Console.WriteLine("Write first number");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Write 2nd number");
			int b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Sum of " + a + " and " + b + " = " + sum(a, b));
			
		}
		static void cw2_2()
		{
			Console.WriteLine("Write first number");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Write 2nd number");
			double b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine( a + " / " + b + " = " + divide(a, b));

		}
		static void cw2_3()
		{
			Console.Write("-1 + 4 * 6 = " + (-1 + 4 * 6) + "\n (35+ 5)% 7 = " + ((35 + 5) % 7) + "\n 14 + -4 * 6/11 = " + (14 + -4 * 6 / 11) + "\n 2 + 15/6 * 1 - 7% 2 = " + (2 + 15 / 6 * 1 - 7 % 2));

		}
		static void cw3()
		{
			Console.WriteLine("Write first number");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("Write 2nd number");
			int b = int.Parse(Console.ReadLine());
			Console.Write("Drugi numer: " + a + "\t Pierwszy numer: " + b);
		}
		static void cw4()
		{
			Console.WriteLine("Write first number");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Write 2nd number");
			int b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Write 3rd number");
			int c = Convert.ToInt32(Console.ReadLine());
			Console.Write("Iloczyn : {0} x {1} x {2} = {3}", c, b, a, a * b * c);
		}
		static void cw5()
		{
			Console.WriteLine("Write number");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.Write(" {0}{0}{0}{0} \n{0}    {0}\n{0}    {0}\n{0}    {0}\n{0}    {0}\n{0}    {0}\n {0}{0}{0}{0} \n", n);
		}
		static void cw6()
		{
			int ii = 75400; 
			double id = 7.54;
			string s = string.Format("Wartość int to {0}, a wartosc double to {1}", ii, id);
			Console.WriteLine(s);
			s = "Wartość int to " + ii + ", a wartosc double to " + id;
			Console.WriteLine(s);
			Console.WriteLine("---{0,40}---", ii);
			Console.WriteLine("---{0,40}---", id);
			Console.WriteLine("---{0,-40}---", ii);
			Console.WriteLine("---{0,-40}---", id);
			int a = 57300;
			double b = 5.73;
			Console.WriteLine("---{0:c}---", a);
			Console.WriteLine("---{0:d}---", a);
			Console.WriteLine("---{0:e}---", a);
			Console.WriteLine("---{0:f}---", a);
			//Console.WriteLine("---{0:r}---", a);	wyjatek
			//Console.WriteLine("---{0:o}---", a);	wyjatek
			Console.WriteLine("---{0:x}---", a);
			Console.WriteLine("---{0:c}---", b);
			//Console.WriteLine("---{0:d}---", b);	wyjatek
			Console.WriteLine("---{0:e}---", b);
			Console.WriteLine("---{0:f}---", b);
			Console.WriteLine("---{0:r}---", b);
			//Console.WriteLine("---{0:o}---", b);	wyjatek
			//Console.WriteLine("---{0:x}---", b);	wyjatek

			float flo = 220.022f;
			Console.WriteLine("{0:0.00000}", flo);
			Console.WriteLine("{0:[#].(#)(##)}", flo);
			Console.WriteLine("{0:0.0}", flo);
			Console.WriteLine("{0:0,0}", flo);
			Console.WriteLine("{0:,.}", flo);
			Console.WriteLine("{0:0%}", flo);
			Console.WriteLine("{0:0e+0}", flo);

			double num1 = 123.4;
			double num2 = -1234;
			double num3 = 0;
			Console.WriteLine("{0:#,##0.0;(#,##)Minus;Zero}", num1);
			Console.WriteLine("{0:#,##0.0;(#,##)Minus;Zero}", num2);
			Console.WriteLine("{0:#,##0.0;(#,##)Minus;Zero}", num3);

			DateTime d = System.DateTime.Now;
			Console.WriteLine("{0:d}", d);
			Console.WriteLine("{0:D}", d);
			Console.WriteLine("{0:t}", d);
			Console.WriteLine("{0:T}", d);
			Console.WriteLine("{0:f}", d);
			Console.WriteLine("{0:F}", d);
			Console.WriteLine("{0:g}", d);
			Console.WriteLine("{0:G}", d);
			Console.WriteLine("{0:M}", d);
			Console.WriteLine("{0:r}", d);
			Console.WriteLine("{0:s}", d);
			Console.WriteLine("{0:u}", d);
			Console.WriteLine("{0:U}", d);
			Console.WriteLine("{0:Y}", d);

		}
		static void cw7()
		{
			Console.WriteLine("Enter the temperature in Celsius degrees");
			double temp = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Temperature in Kelvin degrees = {0}", temp + 273);
			Console.WriteLine("Temperature in Fahrenheit's degrees = {0}", temp * 18 / 10 + 32);

		}
		static bool cw8()
		{
			Console.WriteLine("Write number 1");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Write number 2");
			int num2 = Convert.ToInt32(Console.ReadLine());
			if (num1 * num2 < 0)
			{
				return true;
			}
			return false;
		}

		static int sum(int a, int b)
		{
			return a + b;
		}
		static double divide(double a, double b)
		{
			return a / b;
		}
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			//Console.ReadKey();

			//cw2_1();
			//cw2_2();
			//cw2_3();
			//cw3();
			//cw4();
			//cw5();
			//cw6();
			//cw7();
			//Console.WriteLine(cw8());


			Console.ReadKey();
		}
	}
}
