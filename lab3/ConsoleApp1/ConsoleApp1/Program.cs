using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Point2D
    {
        public int x;
        public int y;

        public Point2D(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public void Reset()
        {
            this.x = 0;
            this.y = 0;
        }

        public void IncrX(int dx)
        {
            this.x += dx;
        }

        public void IncrY(int dy)
        {
            this.y += dy;
        }

        public void Print2DPoint()
        {
            Console.WriteLine("x = {}, y = {}", this.x, this.y);
        }

        public double Dist(Point2D p)
        {
            int d_x = this.x - p.x;
            int d_y = this.y - p.y;

            return Math.Sqrt(Math.Pow(d_x, 2) + Math.Pow(d_y, 2));

        }
    }

    struct Point2D_private
    {
        private int x;
        private int y;

        /*public Point2D_private()
        {
            this.x = 0;
            this.y = 0;
        }*/                 // nie mozna zadeklarowac konstruktora bezparametrowego
    }

    public struct Coords
    { 
        public int x, y; 
        public Coords(int p1, int p2) 
        { 
            x = p1; 
            y = p2; 
        }
    }

    public struct Point
    {
        public int x, y;
        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
    class Program
	{
        static public void cw1()
        {
            const int n = 6;
            const int rad = 10;
            Console.WriteLine("rad = {0}", rad);
            Console.WriteLine("Write {0} coordinates in 2D", n);
            int[] coords = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Write element {0}: ", i);
                coords[i] = Convert.ToInt32(Console.ReadLine());
            }

            Point2D p1 = new Point2D(coords[0], coords[1]);
            Point2D p2 = new Point2D(coords[2], coords[3]);
            Point2D p3 = new Point2D(coords[4], coords[5]);

            double p1_p3_dist = p1.Dist(p3);
            double p2_p3_dist = p2.Dist(p3);

            if (p1_p3_dist < rad || p2_p3_dist < rad)
            {
                Console.WriteLine("Point p3 is inside one of the circles");
            }
            else
            {
                Console.WriteLine("Distance from the nearest point is {0}", Math.Min(p1_p3_dist, p2_p3_dist));
                double p1_p4_dist;
                double p2_p4_dist;
                Point2D p4;
                do
                {
                    Console.WriteLine("Write another 2D point");
                    int[] p4_coord = new int[2];
                    for (int i = 0; i < 2; i++)
                    {
                        Console.Write("Write element {0}: ", i);
                        p4_coord[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    p4 = new Point2D(p4_coord[0], p4_coord[1]);
                    p1_p4_dist = p1.Dist(p4);
                    p2_p4_dist = p1.Dist(p4);

                } while ((p1_p4_dist > rad && p2_p4_dist > rad) || p4.x < 0 || p4.y < 0);

                Console.WriteLine("p1 = ({0}, {1}), p2 = ({2},{3}), p3 = ({4},{5}), p4 = ({6},{7})", 
                    p1.x, p1.y, p2.x, p2.y, p3.x, p3.y, p4.x, p4.y);

            }

        }

        static public void cw2()
        {
            // a)
            Point2D_private p;
            // p.ToString();        tutaj blad

            // b)
            Point2D_private p2 = new Point2D_private();

            // c)

            // d)
            // p2.x = 0;        nie mozna bo jest prywatny
            // p2.y = 0;        nie mozna bo jest prywatny


        }

        static public void cw3()
        {
            Console.WriteLine("Write some data:");
            string data;
            int string_cnt = 0;
            int float_cnt = 0;
            int int_cnt = 0;
            do
            {
                data = Console.ReadLine();
                if (int.TryParse(data, out _))
                {
                    int_cnt++;
                }
                if (float.TryParse(data, out _))
                {
                    float_cnt++;
                }
                string_cnt++;

            } while (data != "-1");
            Console.WriteLine($"Int data = {int_cnt}, float data = {float_cnt}, string data = {string_cnt}");

        }
        public enum day_in_week
        {
            Monday=1,    
            Tuesday,   
            Wednesday,     
            Thursday,      
            Friday,        
            Saturday,       
            Sunday        
        }

        public enum level
        {
            mala = 10,
            srednia = 100,
            duza = 101
        }
        static public void cw4()
        {
            //1
            Console.WriteLine("Write day of the week (value from range 1-7):");
            int day_of_week;
            do
            {
                day_of_week = int.Parse(Console.ReadLine());
            } while (day_of_week < 1 || day_of_week > 7);
            string day = Enum.GetName(typeof(day_in_week), day_of_week);
            Console.WriteLine($"number {day_of_week} is {day}");

            //2
            Console.WriteLine("Write value:");
            int value = int.Parse(Console.ReadLine());
            if (value < (int)level.mala)
            {
                string val = Enum.GetName(typeof(level), 10);
                Console.WriteLine($"Value {value} is {val}");
            }
            else if (value < (int)level.srednia)
            {
                string val = Enum.GetName(typeof(level), 100);
                Console.WriteLine($"Value {value} is {val}");
            }
            else
            {
                string val = Enum.GetName(typeof(level), 101);
                Console.WriteLine($"Value {value} is {val}");
            }
        }


        static public void cw5()
        {
            Console.WriteLine("Write some char:");
            char c;
            c = Console.ReadKey().KeyChar;
            if ("aeiouAEIOU".IndexOf(c) >= 0)
            {
                Console.WriteLine("Char is vowel");
            }
            else if (Char.IsDigit(c))
            {
                Console.WriteLine("Char is digit");
            }
            else
            {
                Console.WriteLine("Different char");
            }
        }

        static public void cw6()
        {
            Console.WriteLine("Write some string");
            string str = Console.ReadLine();
            foreach (char c in str)
            {
                Console.Write($"{c} ");
            }


        }

        static public void cw7()
        {
            /*int k = 100000;
            while (true)
            {
                k *= k;
                Console.Write($"{k}\n");
            }*/             //overflow
            checked
            {
                int i = 100000;
                while (true)
                    i *= i;
            }
        }

        static public void cw8()
        {
            void Fun1(Point p) 
            {
                p.x += 5;
                p.y += 5;
            }
            void Fun2(Coords c) 
            {
                c.x += 5;
                c.y += 5;
            }

            // 1
            Point p1 = new Point(0, 0);
            Coords c1 = new Coords(0, 0);

            Console.WriteLine("Before");
            Console.WriteLine($"p1.x = {p1.x}, p1.y = {p1.y}");
            Console.WriteLine($"c1.x = {c1.x}, c1.y = {c1.y}");

            Fun1(p1);
            Fun2(c1);

            Console.WriteLine("After");
            Console.WriteLine($"p1.x = {p1.x}, p1.y = {p1.y}");
            Console.WriteLine($"c1.x = {c1.x}, c1.y = {c1.y}");


            // 2
            Point p2 = new Point(0, 0);
            Point p3 = new Point(0, 0);
            Coords c2 = new Coords(1, 1);
            Coords c3 = new Coords(1, 1);

            //a
            Console.WriteLine($"Object.Equals(p2, p3) = {Object.Equals(p2, p3)}");
            Console.WriteLine($"Object.Equals(c2, c3) = {Object.Equals(c2, c3)}");

            //b
            Console.WriteLine($"p2.Equals(p3) = {p2.Equals(p3)}");

            //c
            Console.WriteLine($"c2.Equals(c3) = {c2.Equals(c3)}");

            //d
            Console.WriteLine($"Object.ReferenceEquals(p2, p3) = {Object.ReferenceEquals(p2, p3)}");
            Console.WriteLine($"Object.ReferenceEquals(c2, c3) = {Object.ReferenceEquals(c2, c3)}");

        }

        static public void cw9()
        {
            string str = Console.ReadLine();
            foreach (char c in str)
            {
                if ((c < '0' || c > '9') && (c != '+' && c != '-'))
                {
                    Console.Error.WriteLine("string must contain only digits and +-");
                    return;
                }
            }
            //Console.WriteLine($"{str}");
            string[] splitted_str = str.Split(new Char[] {'+', '-'});
            List<char> signs = new List<char>();
            foreach (char c in str)
            {
                if (Char.Equals(c, '+') || Char.Equals(c, '-'))
                {
                    signs.Add(c);
                }

            }

            foreach (string s in splitted_str)
            {
                if (int.Parse(s) < 0 || int.Parse(s) > 99)
                {
                    Console.Error.WriteLine("values must be in range [0,99]");
                    return;
                }

            }

            int result = int.Parse(splitted_str[0]);
            for (int i = 0; i < signs.Count; i++)
            {
                if (signs[i] == '+')
                {
                    result += int.Parse(splitted_str[i + 1]);
                }
                else
                {
                    result -= int.Parse(splitted_str[i + 1]);
                }
                

                
            }
            Console.WriteLine($"{result}");

        }

        public static void cw10()
        {
            /* niejawne:
             * - int -> long
             * - short -> int
             * - byte -> short
             * - char -> int
             */
            /* jawne:
             * - int -> short
             * - long -> int
             * - double -> int
             * - decimal -> byte
             */

        }
        static void Main(string[] args)
		{
            //cw1();
            //cw2();
            //cw3();
            //cw4();
            //cw5();
            //cw6();
            //cw7();
            //cw8();
            cw9();

            Console.ReadKey();
        }
	}
}
