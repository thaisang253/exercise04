using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello github");
            Console.WriteLine(Square(4));
            Console.WriteLine(Pow(2, 3));
            Console.WriteLine(IsPrime(8));
            Console.WriteLine(IsEven(3));
            Console.WriteLine(Floor(5.7F));
            Console.WriteLine(Cube(-10));
            Console.WriteLine(Ceil(4.3F));
            Console.WriteLine(Abs(6));
            Console.WriteLine(Factorial(20L));
            Console.WriteLine("rand1: " + Rand1());
            Console.WriteLine("rand2: " + Rand2());

            Console.ReadKey();
        }
        public static bool IsOdd(int n)
        {
            if (n % 2 != 0)
            {
                return true;
            }
            return false;
        }
        public static int Abs(int n)
        {
            if (n < 0)
            {
                n = n * (-1);
            }
            return n;
        }
        //input: float x
        //ouput: int n that is smallest but not smaller than x
        //idea: n=(int)x then n=n+1
        //if x is negative then n is unchanged
        //if x=a then n is unchanged
        public static int Ceil(float x)
        {
            int n = (int)x;
            if (x > 0)
                if (x > n)
                    n = n + 1;
            return n;

            //int d = (int)x;
            //return d=d+1;
        }
        public static int Cube(int n)
        {
            return n * n * n;
        }
        public static int Floor(float x)
        {
            int a = (int)x;
            if (x < 0 && x != a)
                a = a - 1;
            return a;
            //int n = (int)x;
            //if ((n - x) >= 0.5)
            //    n = n ;
            //return n;
        }
        public static bool IsEven(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            for (int i = 2; i < n; i++) if (n % i == 0)
                {
                    return false;
                }
            return true;
        }
        public static int Pow(int x, int y)
        {
            int rs = 1;
            for (int i = 1; i <= y; i++)
                rs = rs * x;
            return rs;
        }
        public static int Square(int n)
        {
            return n * n;
        }
        public static long Factorial(long n)
        {
            int F = 1;
            for (int i = 2; i < n; i++)
                F = F * i;
            return F;
        }
        public static int Rand1()
        {
            Random rd = new Random();
            int n = rd.Next();
            return n;
        }
        public static float Rand2()
        {
            Random rd = new Random();
            float r = rd.Next() % (0.1F) + (float)rd.Next(0, 1);
            return r;
        }

    }
}