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
using NUnit.Framework;

namespace ConsoleApp2
{
    class Program
    {

        // Create a function that takes voltage and current and returns the calculated power.
        public static int CircuitPower(int voltage, int current)
        {
            return voltage * current;
        }
        
        // Create a function that finds the word "bomb" in the given string (not case sensitive). If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".
    
        public static string Bomb(string txt)
        {
            if (txt.ToLower().Contains("bomb")) return "Duck!!!";
            return "There is no bomb, relax.";
        }
        
        // Write a function that returns the string "something" joined with a space " " and the given argument a.
        public static string GiveMeSomething(string a)
        {
            return "something" + " " + a;
        }
        
        //Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false.
        
        public static bool lessThan100(int a, int b)
        {
            return a + b < 100;

        }
        //Create a function that returns the smaller number.
        
        public static string smallerNum(string n1, string n2)
        {
            return Int32.Parse(n1) > Int32.Parse(n2) ? n2 : n1;
        }
        
        //Write a function that takes the base and height of a triangle and return its area.
        
        public static int triArea(int b, int h)
        {
            return (b * h) / 2;
        }
        
        //Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
        
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
        
        //Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string. For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.

        public static string MonthName(int num)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(num);
        }

        //There is a single operator in C#, capable of providing the remainder of a division operation. Two numbers are passed as parameters. The first parameter divided by the second parameter will have a remainder, possibly zero. Return that value.
        
        public static int Remainder(int x, int y)
        {
            return x % y;
        }
        
        //Create a function that takes a base number and an exponent number and returns the calculation.
        
        public static long CalculateExponent(long number, long exponent)
        {
            return (long) Math.Pow(number, exponent);
        }
        
        //Create a function that takes an integer and returns the factorial of that integer. That is, the integer multiplied by all positive lower integers.
        
        public static int Factorial(int num)
        {
            long fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }

            return (int) fact;
        }
        
        //Create a function that reverses a boolean value.
        public static bool Reverse(bool boolean) => !boolean;

        //Create a function that takes a number as an argument, increments the number by +1 and returns the result.
        
        public static int Addition(int num)
        {
            return num + 1;
        }
        
        //Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.
        
        public static int GetAbsSum(int[] arr)
        {
            return arr.Select(Math.Abs).Sum();
        }
        
        //This is an introduction to how challenges on Edabit work. In the Code tab above you'll see a starter function that looks like this:All you have to do is type return true; between the curly braces { } and then click the Check button. If you did this correctly, the button will turn red and say SUBMIT FINAL. Click it and see what happens.
        public static bool ReturnTrue()
        {
            return true;
        }

        [TestFixture]
        public class Tests
        {
            [Test]
            [TestCase(110, 3, ExpectedResult = 330)]
            [TestCase(230, 10, ExpectedResult = 2300)]
            [TestCase(480, 20, ExpectedResult = 9600)]

            public static int CircuitPower(int voltage, int current)
            {
                Console.WriteLine($"Input: {voltage} {current}");
                return Program.CircuitPower(voltage, current);
            }
            
            [TestCase("There is a bomb.", ExpectedResult =  "Duck!!!")]
            [TestCase("Hey, did you find it?", ExpectedResult =  "There is no bomb, relax.")]
            [TestCase("Hey, did you think there is a bomb?", ExpectedResult =  "Duck!!!")]
            [TestCase("This goes boom!!!", ExpectedResult =  "There is no bomb, relax.")]
            [TestCase("Hey, did you find the BoMb?", ExpectedResult =  "Duck!!!")]
            [TestCase("Commotion in the third, a bomb is found!", ExpectedResult =  "Duck!!!")]
            public static string FixedTest(string a)
            {
                Console.WriteLine(Bomb(a));
                return Program.Bomb(a);
            }
            
            [TestCase("a", ExpectedResult="something a")]
            [TestCase("is cooking", ExpectedResult="something is cooking")]
            [TestCase(" is cooking", ExpectedResult="something  is cooking")]
            public static string FixedTest2(string a) {
                Console.WriteLine($"Input: {a}");
                return Program.GiveMeSomething(a);
            }
            
            [Test]
            [TestCase(5,57, ExpectedResult=true)]
            [TestCase(77,30, ExpectedResult=false)]
            [TestCase(0,59, ExpectedResult=true)]
            [TestCase(78,35, ExpectedResult=false)]
            [TestCase(63,11, ExpectedResult=true)]
            [TestCase(37,99, ExpectedResult=false)]
            [TestCase(52,11, ExpectedResult=true)]
            [TestCase(82,95, ExpectedResult=false)]
            [TestCase(17,44, ExpectedResult=true)]
            [TestCase(74,53, ExpectedResult=false)]
            [TestCase(3,77, ExpectedResult=true)]
            [TestCase(25,80, ExpectedResult=false)]
            [TestCase(59,28, ExpectedResult=true)]
            [TestCase(69,87, ExpectedResult=false)]
            [TestCase(10,45, ExpectedResult=true)]
            [TestCase(43,58, ExpectedResult=false)]
            [TestCase(50,44, ExpectedResult=true)]
            [TestCase(74,89, ExpectedResult=false)]
            [TestCase(3,27, ExpectedResult=true)]
            [TestCase(21,79, ExpectedResult=false)]
	
            public static bool FixedTest3(int a, int b) 
            {
                Console.WriteLine(lessThan100(a,b));
                return Program.lessThan100(a,b);
            }
            
            [Test]
            [TestCase("21", "44", ExpectedResult="21")]
            [TestCase("153", "367", ExpectedResult="153")]
            [TestCase("1500", "16", ExpectedResult="16")]
            [TestCase("100", "23", ExpectedResult="23")]
            [TestCase("1500", "1", ExpectedResult="1")]
            [TestCase("5", "5", ExpectedResult="5")]
            public static string smallerNum(string n1, string n2)
            {
                Console.WriteLine(smallerNum(n1,n2));
                return Program.smallerNum(n1, n2);
            }
            
            [TestCase(3, 2, ExpectedResult=3)]
            [TestCase(5, 4, ExpectedResult=10)]
            [TestCase(10, 10, ExpectedResult=50)]
            [TestCase(0, 60, ExpectedResult=0)]
            [TestCase(12, 11, ExpectedResult=66)]
            public static int triArea(int b, int h)
            {
                Console.WriteLine($"Input: {b}, {h}");
                return Program.triArea(b, h);
            }
            
            [Test]
            [TestCase("Happy Birthday", ExpectedResult="hAPPY bIRTHDAY")]
            [TestCase("MANY THANKS", ExpectedResult="many thanks")]
            [TestCase("sPoNtAnEoUs", ExpectedResult="SpOnTaNeOuS")]
            [TestCase("eXCELLENT, yOuR mAJESTY", ExpectedResult="Excellent, YoUr Majesty")]
            public static string ReverseCase(string str) 
            {
                Console.WriteLine($"Input: {str}");
                return Program.ReverseCase(str);
            }
            
            [Test]
            [TestCase(1, ExpectedResult="January")]
            [TestCase(2, ExpectedResult="February")]
            [TestCase(3, ExpectedResult="March")]
            [TestCase(4, ExpectedResult="April")]
            [TestCase(5, ExpectedResult="May")]
            [TestCase(6, ExpectedResult="June")]
            [TestCase(7, ExpectedResult="July")]
            [TestCase(8, ExpectedResult="August")]
            [TestCase(9, ExpectedResult="September")]
            [TestCase(10, ExpectedResult="October")]
            [TestCase(11, ExpectedResult="November")]
            [TestCase(12, ExpectedResult="December")]
            public static string MonthName(int num) 
            {
                Console.WriteLine($"Input: {num}");
                return Program.MonthName(num);
            }
            
            [Test]
            [TestCase(7, 2, ExpectedResult=1)]
            [TestCase(3, 4, ExpectedResult=3)]
            [TestCase(-9, 45, ExpectedResult=-9)]
            [TestCase(5, 5, ExpectedResult=0)]
            public static int Remainder(int x, int y) 
            {
                Console.WriteLine($"Input: {x}, {y}");
                return Program.Remainder(x, y);
            }
            
            [Test]
            [TestCase(5,5, ExpectedResult=3125)]
            [TestCase(3,3, ExpectedResult=27)]
            [TestCase(10,10, ExpectedResult=10000000000)]
            public static long CalculateExponent(long number, long exponent) 
            {
                Console.WriteLine($"Input: {number}, {exponent}");
                return Program.CalculateExponent(number, exponent);
            }
            
            [Test]
            [TestCase(2, ExpectedResult = 2)]
            [TestCase(6, ExpectedResult = 720)]
            [TestCase(3, ExpectedResult = 6)]
            [TestCase(12, ExpectedResult = 479001600)]
            [TestCase(5, ExpectedResult = 120)]
            public static int FixedTest4(int num)
            {
                Console.WriteLine(Factorial(num));
                return Program.Factorial(num);
            }
            
            [Test]
            [TestCase(false, ExpectedResult=true)]
            [TestCase(true, ExpectedResult=false)]
            public static bool FixedTest(bool boolean)
            {
                Console.WriteLine($"Input: {boolean}");
                return Program.Reverse(boolean);
            }
            
            [Test]
            [TestCase(2, ExpectedResult=3)]
            [TestCase(-9 , ExpectedResult=-8)]
            [TestCase(0, ExpectedResult=1)]
            [TestCase(100, ExpectedResult=101)]
            [TestCase(999, ExpectedResult=1000)]
            [TestCase(73, ExpectedResult=74)]
            public static int FixedTest(int num)
            {
                Console.WriteLine($"Input: {num}");
                return Program.Addition(num);
            }
            
            [Test]
            [TestCase(new int[] { 2, -1, -3, 4, 8 }, ExpectedResult=18)]
            [TestCase(new int[] { -1 }, ExpectedResult=1)]
            [TestCase(new int[] { -1, -3, -5, -4, -10, 0 }, ExpectedResult=23)]
            [TestCase(new int[] { 8, 9, 10, 32, 101, -10 }, ExpectedResult=170)]
            [TestCase(new int[] { 500 }, ExpectedResult=500)]
            public static int FixedTest(int[] arr)
            {
                Console.WriteLine(GetAbsSum(arr));
                return Program.GetAbsSum(arr);
            }
            
            [Test]
            [TestCase(ExpectedResult=true)]
            public static bool FixedTest()
            {
                Console.WriteLine(ReturnTrue());
                return Program.ReturnTrue();
            }

        }
    }
}
