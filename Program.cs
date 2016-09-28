/* 
 * Decimal To Binary Converter 
 * Converts decimal to binary number.
 * V1.0 2016
 * David B.
*/


using System;
using System.Collections;

namespace binaryConverter2
{
	class MainClass
	{

		public static void calculateBin()
		{

			var stack = new Stack();
			int remainder;
			int number;


			number = Convert.ToInt32(Console.ReadLine());

			while (number >= 1)
			{
				remainder = number % 2;
				number = number / 2;
				stack.Push(remainder);
			}

			Console.WriteLine("Your number in binary representation is: ");
			while (stack.Count >= 1)
			{
				Console.Write(stack.Pop());
			}
		}

		public static void Main(string[] args)
		{
			Console.WriteLine("Enter a number not larger than 2 to the power of 31: ");
			try
			{
				calculateBin();
			}

			catch (OverflowException)
			{
				Console.WriteLine("Number too big!");
				Console.WriteLine("Enter a number not larger than 2 to the power of 31: ");
				calculateBin();
			}

		}

	}
}


