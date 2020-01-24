using System;
using System.Collections.Generic;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{

			#region WrongWay
			WrongWay(5, 2, "+");
			WrongWay(5, 2, "-");
			WrongWay(5, 2, "/");
			WrongWay(5, 2, "*");
			#endregion

			#region CorrectWay
			CorrectWay(5, 2, "+");
			CorrectWay(5, 2, "-");
			CorrectWay(5, 2, "/");
			CorrectWay(5, 2, "*");
			#endregion

			Console.ReadLine();
		}

		private static void WrongWay(int number1, int number2, string action)
		{
			if (string.Equals(action, "+"))
			{
				Console.WriteLine("SUM: " + (number1 + number2));
			}

			if (string.Equals(action, "-"))
			{
				Console.WriteLine("SUBSTRACT: " + (number1 - number2));
			}

			if (string.Equals(action, "/"))
			{
				Console.WriteLine("DIVISION: " + (number1 / number2));
			}

			if (string.Equals(action, "*"))
			{
				Console.WriteLine("MULTIPLICATION: "+(number1 * number2));
			}
		}

		private static void CorrectWay( int number1, int number2, string action)
		{
			Dictionary<string, Action<int,int>> actions = new Dictionary<string, Action<int, int>>()
			{
				{"+", Sum},
				{"-", Subtract},
				{"/", Divide},
				{"*", Multiplicate}
			};

			actions[action].Invoke(number1, number2);
		}

		private static void Sum(int number1, int number2)
		{
			Console.WriteLine("SUM: " + (number1 + number2));
		}

		private static void Subtract(int number1, int number2)
		{
			Console.WriteLine("SUBSTRACT: " + (number1 - number2));
		}

		private static void Divide(int number1, int number2)
		{
			Console.WriteLine("DIVISION: " + (number1 / number2));
		}

		private static void Multiplicate(int number1, int number2)
		{
			Console.WriteLine("MULTIPLICATION: " + (number1 * number2));
		}
	}
}
