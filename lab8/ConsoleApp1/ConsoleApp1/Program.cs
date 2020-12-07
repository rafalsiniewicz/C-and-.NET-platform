using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public interface ICepikData
	{
		// pojazd
		string typ_pojazdu { get; }
		string marka { get; }
		double pojemnosc { get; }
		short liczba_miejsc { get; }
		string vin { get; }
		string nr_rejestracyjny { get; }
		int rok_produkcji { get; }
		string kolor { get; }
		int polisa_nr { get; }

		// wlasciciel
		string imie { get; }
		string nazwisko { get; }
		string adres { get; }
		long pesel { get; }
		string nr_prawa_jazdy { get; }

		DateTime data_uzyskania_prawa_jazdy { get; }
		int rok_zakupu { get; }
	}
	public interface IStatData
	{
		// pojazd
		string typ_pojazdu { get; }
		string marka { get; }
		double pojemnosc { get; }
		short liczba_miejsc { get; }
		string vin { get; }
		string nr_rejestracyjny { get; }
		int rok_produkcji { get; }
		string kolor { get; }
		int polisa_nr { get; }
	}
	public interface IPoliceData
	{
		// pojazd
		string typ_pojazdu { get; }
		string marka { get; }
		double pojemnosc { get; }
		short liczba_miejsc { get; }
		string vin { get; }
		string nr_rejestracyjny { get; }
		int rok_produkcji { get; }
		string kolor { get; }
		int polisa_nr { get; }

		// wlasciciel
		string imie { get; }
		string nazwisko { get; }
		string adres { get; }
		long pesel { get; }
		string nr_prawa_jazdy { get; }

		DateTime data_uzyskania_prawa_jazdy { get; }
		int rok_zakupu { get; }
		short liczba_pkt_karnych { get; } 
	}
	public class Pojazd
	{
		string typ_pojazdu;
		string marka;
		double pojemnosc;
		short liczba_miejsc;
		string vin;
		string nr_rejestracyjny;
		int rok_produkcji;
		string kolor;
		int polisa_nr;

		public string TypPojazdu
		{
			get { return typ_pojazdu; }
			set { typ_pojazdu = value; }
		}
		public string Marka
		{
			get { return marka; }
			set { marka = value; }
		}
		public double Pojemnosc
		{
			get { return pojemnosc; }
			set { pojemnosc = value; }
		}
		public short LiczbaMiejsc
		{
			get { return liczba_miejsc; }
			set { liczba_miejsc = value; }
		}
		public string VIN
		{
			get { return vin; }
			set { vin = value; }
		}
		public string NrRejestracyjny
		{
			get { return nr_rejestracyjny; }
			set { nr_rejestracyjny = value; }
		}
		public int RokProdukcji
		{
			get { return rok_produkcji; }
			set { rok_produkcji = value; }
		}
		public string Kolor
		{
			get { return kolor; }
			set { kolor = value; }
		}
		public int PolisaNr
		{
			get { return polisa_nr; }
			set { polisa_nr = value; }
		}

	}
	public class Wlasciciel
	{
		string imie;
		string nazwisko;
		string adres;
		long pesel;
		string nr_prawa_jazdy;
		DateTime data_uzyskania_prawa_jazdy;
		int rok_zakupu;
		private short liczba_pkt_karnych;

		public string Imie{get { return imie; } set { imie = value; } }
		public string Nazwisko { get { return nazwisko; } set { nazwisko = value; } }
		public string Adres { get { return adres; } set { adres = value; } }
		public long Pesel { get { return pesel; } set { pesel = value; } }
		public string NrPrawaJazdy { get { return nr_prawa_jazdy; } set { nr_prawa_jazdy = value; } }
		public DateTime DataUzyskaniaPrawaJazdy { get { return data_uzyskania_prawa_jazdy; } set { data_uzyskania_prawa_jazdy = value; } }
		public int RokZakupu { get { return rok_zakupu; } set { rok_zakupu = value; } }
		public short LiczbaPktKarnych { get { return liczba_pkt_karnych; } set { liczba_pkt_karnych = value; } }

	}
	public class Auto : ICepikData, IStatData, IPoliceData
	{
		public Pojazd pojazd { get; set; }
		public Wlasciciel wlasciciel { get; set; }


		public Auto(string typ_pojazdu, string marka, double pojemnosc, short liczba_miejsc, string vin,
			string nr_rejestracyjny, int rok_produkcji, string kolor, int polisa_nr, string imie, string nazwisko,
			string adres, long pesel, string nr_prawa_jazdy, DateTime data_uzyskania_prawa_jazdy, int rok_zakupu,
			short liczba_pkt_karnych)
		{
			this.pojazd = new Pojazd();
			this.wlasciciel = new Wlasciciel();
			this.pojazd.TypPojazdu = typ_pojazdu;
			this.pojazd.Marka = marka;
			this.pojazd.Pojemnosc = pojemnosc;
			this.pojazd.LiczbaMiejsc = liczba_miejsc;
			this.pojazd.VIN = vin;
			this.pojazd.NrRejestracyjny = nr_rejestracyjny;
			this.pojazd.RokProdukcji = rok_produkcji;
			this.pojazd.Kolor = kolor;
			this.pojazd.PolisaNr = polisa_nr;
			this.wlasciciel.Imie = imie;
			this.wlasciciel.Nazwisko = nazwisko;
			this.wlasciciel.Adres = adres;
			this.wlasciciel.Pesel = pesel;
			this.wlasciciel.NrPrawaJazdy = nr_prawa_jazdy;
			this.wlasciciel.DataUzyskaniaPrawaJazdy = data_uzyskania_prawa_jazdy;
			this.wlasciciel.RokZakupu = rok_zakupu;
			this.wlasciciel.LiczbaPktKarnych = liczba_pkt_karnych;

		}

		public string typ_pojazdu{ get { return pojazd.TypPojazdu; }}
		public string marka{get { return pojazd.Marka; }}
		public double pojemnosc{get { return pojazd.Pojemnosc; }}
		public short liczba_miejsc{get { return pojazd.LiczbaMiejsc; }}
		public string vin{get { return pojazd.VIN; }}
		public string nr_rejestracyjny{get { return pojazd.NrRejestracyjny; }}
		public int rok_produkcji{get { return pojazd.RokProdukcji; }}
		public string kolor{get { return pojazd.Kolor; }}
		public int polisa_nr{get { return pojazd.PolisaNr; }}

		public string imie { get { return wlasciciel.Imie; } }
		public string nazwisko { get { return wlasciciel.Nazwisko; } }
		public string adres { get { return wlasciciel.Adres; } }
		public long pesel { get { return wlasciciel.Pesel; } }
		public string nr_prawa_jazdy { get { return wlasciciel.NrPrawaJazdy; } }
		public DateTime data_uzyskania_prawa_jazdy { get { return wlasciciel.DataUzyskaniaPrawaJazdy; } }
		public int rok_zakupu { get { return wlasciciel.RokZakupu; } }
		public short liczba_pkt_karnych { get { return wlasciciel.LiczbaPktKarnych; } }

	}

	public class Point
	{
		public int x, y;

		public Point()
		{
			x = 0;
			y = 0;
		}
		public Point(int p1, int p2)
		{
			x = p1;
			y = p2;
		}
		public static Point operator +(Point p1, Point p2)
		{
			Point p = new Point();
			p.x = p1.x + p2.x;
			p.y = p1.y + p2.y;
			return p;
		}
		public static bool operator ==(Point p1, Point p2)
		{
			if (p1.x == p2.x && p1.y == p2.y)
				return true;
			else return false;
		}
		public static bool operator !=(Point p1, Point p2)
		{
			if (p1.x != p2.x || p1.y != p2.y)
				return true;
			else return false;
		}
		public static bool operator <(Point p1, Point p2)
		{
			if (p1.x < p2.x && p1.y < p2.y)
				return true;
			else return false;
		}
		public static bool operator <=(Point p1, Point p2)
		{
			if (p1.x <= p2.x && p1.y <= p2.y)
				return true;
			else return false;
		}
		public static bool operator >(Point p1, Point p2)
		{
			if (p1.x > p2.x && p1.y > p2.y)
				return true;
			else return false;
		}
		public static bool operator >=(Point p1, Point p2)
		{
			if (p1.x >= p2.x && p1.y >= p2.y)
				return true;
			else return false;
		}
		public static Point operator ++(Point p1)
		{
			p1.x++;
			p1.y++;
			return p1;
		}
		public static Point operator --(Point p1)
		{
			p1.x--;
			p1.y--;
			return p1;
		}
		public static implicit operator Point(int n)
		{
			Point p = new Point(n, 0);
			return p;
		}
		public static implicit operator int(Point p)
		{
			return p.x + p.y;
		}
		public static bool operator true(Point p)
		{
			if (p.x != 0 || p.y != 0) { return true;}
			else { return false; }
		}
		public static bool operator false(Point p)
		{
			if (p.x != 0 || p.y != 0) { return true; }
			else { return false; }
		}
	}

	delegate int NumberChanger(int m, int n);


	class Program
	{
		public static void cw1()
		{
			List<ICepikData> icd = new List<ICepikData>();
			List<IStatData> isd = new List<IStatData>();
			List<IPoliceData> ipd = new List<IPoliceData>();
			Auto a1 = new Auto("osobowy", "mercedes", 2.0, 5, "VF38EAHXMEL029000", "ERA 75TM", 2010, "czarny", 12345, "Pawel",
				"Cichocki", "Krakow", 1234567890123, "GAP 315", new DateTime(1998, 04, 30), 2020, 8);

			Auto a2 = new Auto("ciezarowy", "audi", 2.4, 4, "AB23EAHXMEL035000", "ABC 1234", 2013, "bialy", 1241, "Adam",
				"Kownacki", "Bydgoszcz", 54321127890123, "AGH 412", new DateTime(2001, 03, 13), 2015, 0);
			Auto a3 = new Auto("osobowy", "volkswagen", 1.8, 5, "AB2123ASFEG035000", "YRG 12 SF", 2010, "czarny", 13255, "Jacek",
				"Blama", "Warszawa", 5432112781235, "TYE 1254", new DateTime(2004, 01, 23), 2017, 3);
			Auto a4 = new Auto("ciezarowy", "ford", 3.6, 6, "AB2AEGDE1EL035000", "TE 12 WA", 2016, "czerwony", 2344, "Janina",
				"Ochocka", "Rzeszow", 54321127892153, "13412TE", new DateTime(2007, 05, 23), 2009, 15);
			icd.Add(a1);
			isd.Add(a2);
			ipd.Add(a3);
			Console.WriteLine("########################### Auto 1 ###########################");
			Console.WriteLine(icd[0].typ_pojazdu);
			Console.WriteLine(icd[0].marka);
			Console.WriteLine(icd[0].pojemnosc);
			Console.WriteLine(icd[0].liczba_miejsc);
			Console.WriteLine(icd[0].vin);
			Console.WriteLine(icd[0].nr_rejestracyjny);
			Console.WriteLine(icd[0].rok_produkcji);
			Console.WriteLine(icd[0].kolor);
			Console.WriteLine(icd[0].polisa_nr);
			Console.WriteLine(icd[0].imie);
			Console.WriteLine(icd[0].nazwisko);
			Console.WriteLine(icd[0].adres);
			Console.WriteLine(icd[0].pesel);
			Console.WriteLine(icd[0].nr_prawa_jazdy);
			Console.WriteLine(icd[0].data_uzyskania_prawa_jazdy);
			Console.WriteLine(icd[0].rok_zakupu);
			//Console.WriteLine(icd[0].liczba_pkt_karnych); blad


			Console.WriteLine("########################### Auto 2 ###########################");
			Console.WriteLine(isd[0].typ_pojazdu);
			Console.WriteLine(isd[0].marka);
			Console.WriteLine(isd[0].pojemnosc);
			Console.WriteLine(isd[0].liczba_miejsc);
			Console.WriteLine(isd[0].vin);
			Console.WriteLine(isd[0].nr_rejestracyjny);
			Console.WriteLine(isd[0].rok_produkcji);
			Console.WriteLine(isd[0].kolor);
			Console.WriteLine(isd[0].polisa_nr);
			/*Console.WriteLine(isd[0].imie);
			Console.WriteLine(isd[0].nazwisko);
			Console.WriteLine(isd[0].adres);
			Console.WriteLine(isd[0].pesel);
			Console.WriteLine(isd[0].nr_prawa_jazdy);
			Console.WriteLine(isd[0].data_uzyskania_prawa_jazdy);
			Console.WriteLine(isd[0].rok_zakupu);
			Console.WriteLine(isd[0].liczba_pkt_karnych);			blad*/


			Console.WriteLine("########################### Auto 3 ###########################");
			Console.WriteLine(ipd[0].typ_pojazdu);
			Console.WriteLine(ipd[0].marka);
			Console.WriteLine(ipd[0].pojemnosc);
			Console.WriteLine(ipd[0].liczba_miejsc);
			Console.WriteLine(ipd[0].vin);
			Console.WriteLine(ipd[0].nr_rejestracyjny);
			Console.WriteLine(ipd[0].rok_produkcji);
			Console.WriteLine(ipd[0].kolor);
			Console.WriteLine(ipd[0].polisa_nr);
			Console.WriteLine(ipd[0].imie);
			Console.WriteLine(ipd[0].nazwisko);
			Console.WriteLine(ipd[0].adres);
			Console.WriteLine(ipd[0].pesel);
			Console.WriteLine(ipd[0].nr_prawa_jazdy);
			Console.WriteLine(ipd[0].data_uzyskania_prawa_jazdy);
			Console.WriteLine(ipd[0].rok_zakupu);
			Console.WriteLine(ipd[0].liczba_pkt_karnych);

		}

		public static void cw2_1()
		{
			Point p1 = new Point(3,5);
			Point p2 = new Point(2,4);
			Point p3 = new Point();
			p3 = p1 + p2;
			Console.WriteLine($"p1.x = {p1.x}, p1.y = {p1.y}");
			Console.WriteLine($"p2.x = {p2.x}, p2.y = {p2.y}");
			Console.WriteLine($"p3.x = {p3.x}, p3.y = {p3.y}");
		}

		public static void cw2_2()
		{
			Point p1 = new Point(3, 0);
			Point p2 = new Point(0, 0);
			Point p3 = new Point(1, 2);
			if (p1)
			{
				Console.WriteLine($"p1 has at least one coordinate different from 0. p1.x = {p1.x}, p1.y = {p1.y}");
			}
			else
			{
				Console.WriteLine($"p1 has two coordinates equal to 0. p1.x = {p1.x}, p1.y = {p1.y}");
			}
			if (p2)
			{
				Console.WriteLine($"p2 has at least one coordinate different from 0. p2.x = {p2.x}, p2.y = {p2.y}");
			}
			else
			{
				Console.WriteLine($"p2 has two coordinates equal to 0. p2.x = {p2.x}, p2.y = {p2.y}");
			}
			if (p3)
			{
				Console.WriteLine($"p3 has at least one coordinate different from 0. p3.x = {p3.x}, p3.y = {p3.y}");
			}
			else
			{
				Console.WriteLine($"p3 has two coordinates equal to 0. p3.x = {p3.x}, p3.y = {p3.y}");
			}

		}

		public static void cw2_3()
		{

			// nie wystarczy zdefiniowac tylko operator ==, trzeba zdefiniowac tez operator !=
			Point p1 = new Point(3, 5);
			Point p2 = new Point(2, 4);
			Point p3 = new Point(2, 4);
			Console.WriteLine($"p1 == p2: {p1 == p2}");
			Console.WriteLine($"p1 == p3: {p1 == p3}");
			Console.WriteLine($"p2 == p3: {p2 == p3}");
		}

		public static void cw2_4()
		{

			// nie wystarczy zdefiniowac tylko operator > oraz >=, trzeba zdefiniowac tez operator < oraz <=
			Point p1 = new Point(3, 5);
			Point p2 = new Point(2, 4);
			Point p3 = new Point(2, 4);
			Console.WriteLine($"p1 > p2: {p1 > p2}");
			Console.WriteLine($"p1 > p3: {p1 > p3}");
			Console.WriteLine($"p2 > p3: {p2 > p3}");
			Console.WriteLine($"p1 < p2: {p1 < p2}");
			Console.WriteLine($"p1 < p3: {p1 < p3}");
			Console.WriteLine($"p2 < p3: {p2 < p3}");
			Console.WriteLine($"p1 >= p2: {p1 >= p2}");
			Console.WriteLine($"p1 >= p3: {p1 >= p3}");
			Console.WriteLine($"p2 >= p3: {p2 >= p3}");
			Console.WriteLine($"p1 <= p2: {p1 <= p2}");
			Console.WriteLine($"p1 <= p3: {p1 <= p3}");
			Console.WriteLine($"p2 <= p3: {p2 <= p3}");
		}

		public static void cw2_5()
		{

			// nie wystarczy zdefiniowac tylko operator ==, trzeba zdefiniowac tez operator !=
			Point p1 = new Point(3, 5);
			Point p2 = new Point(2, 4);
			Point p3 = new Point(2, 4);
			Console.WriteLine($"p1.x = {p1.x}, p1.y = {p1.y}");
			Console.WriteLine("p1++");
			p1++;
			Console.WriteLine($"p1.x = {p1.x}, p1.y = {p1.y}");
			Console.WriteLine($"p2.x = {p2.x}, p2.y = {p2.y}");
			Console.WriteLine("p2--");
			p2--;
			Console.WriteLine($"p2.x = {p2.x}, p2.y = {p2.y}");
		}

		public static void cw2_6()
		{

			// nie wystarczy zdefiniowac tylko operator ==, trzeba zdefiniowac tez operator !=
			Point p1 = 5;
			Console.WriteLine($"p1.x = {p1.x}, p1.y = {p1.y}");
		}

		public static void cw2_7()
		{

			Point p = new Point(2, 5); 
			int suma = (int)p; //suma==3
			Console.WriteLine($"Sum of coordinates for p({p.x}, {p.y}) = {suma}");
		}

		public static int AddNum(int m, int n)
		{
			Console.WriteLine($"m + n = {m + n}");
			return m + n;
		}
		public static int SubNum(int m, int n)
		{
			Console.WriteLine($"m - n = {m - n}");
			return m - n;
		}
		public static int MultNum(int m, int n)
		{
			Console.WriteLine($"m * n = {m * n}");
			return m * n;
		}
		public static int DivNum(int m, int n)
		{
			Console.WriteLine($"m / n = {m / n}");
			return m / n;
		}

		public static void cw3()
		{
			int m = 20;
			int n = 10;
			NumberChanger nc1 = new NumberChanger(AddNum);
			NumberChanger nc2 = new NumberChanger(SubNum);
			NumberChanger nc3 = new NumberChanger(MultNum);
			NumberChanger nc4 = new NumberChanger(DivNum);
			nc1(m, n);
			nc2(m, n);
			nc3(m, n);
			nc4(m, n);

		}

		static void Main(string[] args)
		{
			//cw1();
			//cw2_1();
			//cw2_2();
			//cw2_3();
			//cw2_4();
			//cw2_5();
			//cw2_6();
			//cw2_7();
			//cw3();


			// nie jest mozliwe nadpisanie operatora +=, nie mozna rowniez nadpisac ponizszych operatorow: 
			//	=, ., ?:, ->, new, is, sizeof, typeof
			Console.ReadKey();


		}
	}
}
