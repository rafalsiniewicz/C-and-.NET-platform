using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib1;

namespace ApLab2
{
	class Program
	{
		static void Main(string[] args)
		{
			Class c = new Class(); 
			Console.WriteLine("Wersja: {0}", c.Version); 
			Console.ReadKey();
		}
	}
}
