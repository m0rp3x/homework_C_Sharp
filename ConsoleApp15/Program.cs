using System;
using System.Collections.Immutable;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using Org.BouncyCastle.Math;
using System.Numerics;
using Org.BouncyCastle.Crypto.Digests;
using BigInteger = System.Numerics.BigInteger;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CircuitPower(230,10));
            Console.WriteLine(Bomb("There is a bomb."));
            Console.WriteLine(Bomb("This goes boom!!!"));
            Console.WriteLine(GiveMeSomething("is better than nothing"));
            Console.WriteLine(lessThan100(22,15));
            Console.WriteLine(smallerNum("21","44"));
            Console.WriteLine(triArea(3,2));
            Console.WriteLine(ReverseCase("Happy Birthday"));
            Console.WriteLine(MonthName(1));
            Console.WriteLine(Remainder(3, 4));
            Console.WriteLine(CalculateExponent(5,5));
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Reverse(true));
            Console.WriteLine(Addition(0));
            Console.WriteLine(GetAbsSum(new []{2, -1, 4, 8, 10}));
            Console.WriteLine(ReturnTrue());
    
        }


        public static int CircuitPower(int voltage, int current) 
        {
            return voltage * current;
        }
        public static string Bomb(string txt)
        {
            if (txt.ToLower().Contains("bomb")) return "Duck!!!";
            return "There is no bomb, relax.";
        }
        public static string GiveMeSomething(string a) {
            return "something" + " " + a;
        }
        public static bool lessThan100(int a, int b) 
        {
            return a + b < 100;
			
        }
        public static string smallerNum(string n1, string n2)
        {
            return Int32.Parse(n1) > Int32.Parse(n2) ? n2 : n1;
        }
        public static int triArea(int b, int h)
        {
            return	(b * h) / 2;
        }
        public static string ReverseCase(string str) 
        {
            char[] ch = str.ToCharArray();
            char[] Upper = str.ToUpper().ToCharArray();
            char[] Lower = str.ToLower().ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == Upper[i])
                {
                    ch[i] = Lower[i];
                }
                else
                {
                    ch[i] = Upper[i];
                }
            }

            return new string(ch);
        }
        public static string MonthName(int num) 
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(num);
        }
        public static int Remainder(int x, int y) 
        {
            return	x % y;
        }
        public static long CalculateExponent(long number, long exponent) 
        {
            return (long) Math.Pow(number, exponent);
        }
        public static int Factorial(int num)
        {
            long fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return (int) fact;
        }
        
        public static bool Reverse(bool boolean) => !boolean;
        
        public static int Addition(int num)
        {
            return num +1;
        }
        public static int GetAbsSum(int[] arr) 
        {
            return arr.Select(Math.Abs).Sum();
        }
        public static bool ReturnTrue() 
        {
            return true;
        }
    }
}
