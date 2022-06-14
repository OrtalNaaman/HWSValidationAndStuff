using System;
using System.Text.Json;

namespace HWSValidationAndStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PowerRanger:");
            PowerRanger(2, 49, 65);
            PowerRanger(3, 1, 27);
            PowerRanger(10, 1, 5);
            PowerRanger(5, 31, 33);
            PowerRanger(4, 250, 1300);

            Console.WriteLine("ConsecutiveNumbers{ 5, 1, 4, 3, 2 }:");
            List<int> list1 = new List<int> { 5, 1, 4, 3, 2 };
            Console.WriteLine(ConsecutiveNumbers(list1));

            Console.WriteLine("ConsecutiveNumbers{ 5, 1, 4, 3, 2, 8 }:");
            List<int> list2 = new List<int> { 5, 1, 4, 3, 2, 8 };
            Console.WriteLine(ConsecutiveNumbers(list2));

            Console.WriteLine("ConsecutiveNumbers{ 5, 6, 7, 8, 9, 9 }:");
            List<int> list3 = new List<int> { 5, 6, 7, 8, 9, 9 };
            Console.WriteLine(ConsecutiveNumbers(list3));

            Console.WriteLine("\nReverseAndNot:");
            Console.WriteLine(ReverseAndNot(123));

            Console.WriteLine("\nReverseCase:");
            Console.WriteLine(ReverseCase("Hello World!"));
            Console.WriteLine(ReverseCase("sPoNtAnEoUs!"));
        }

        public static int PowerRanger(int n, int a, int b)
        {
            List<string> resultsList = new List<string>();
            double num = 0;
            double result = 0;
            int counter = 0;
            while (result <= b)
            {
                result = Math.Pow(num, n);
                if (result >= a && result <= b)
                {
                    resultsList.Add($"{result.ToString()} ({num}^{n})");
                    counter++;
                }
                num++;
            }
            Console.WriteLine($"\n\n{counter} value raised to the {n}th power lie between {a} to {b}:");
            resultsList.ForEach(s => Console.Write(s + ", "));
            Console.WriteLine("\n");
            return counter;
        }

        public static bool ConsecutiveNumbers(List<int> numbersList)
        {
            numbersList.Sort();
            for (int i = 0; i < numbersList.Count - 1; i++)
            {
                if (numbersList[i] + 1 != numbersList[i + 1])
                    return false;
            }
            return true;
        }

        public static string ReverseAndNot(int i)
        {
            var temp = i.ToString().Reverse().ToList();
            string result = "";
            temp.ForEach(t => result += t);
            return result + i.ToString();
        }
        public static string ReverseCase(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
                if (Char.IsLower(str[i]))
                    result += str[i].ToString().ToUpper();
                else result += str[i].ToString().ToLower();
            return result;
        }

    }
}

