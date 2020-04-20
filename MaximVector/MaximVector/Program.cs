﻿using System;

namespace MaximVector
{
	public static class FactorialHelper
	{


		public static void PrintMinim(int[] array)
		{
			int minim = array[0];
			PrintMinim(array, 0, minim);


		}

		private static void PrintMinim(int[] array, int index, int minim)
		{



			if (index < (array?.Length ?? 0))
			{
				if (minim < array[index])
				{
					minim = array[index];

				}

				// print current element
				Console.Write($"{array[index]}, ");
				// print next element
				PrintMinim(array, index + 1, minim);


			}
			if (index == array.Length - 1)
			{
				Console.WriteLine();
				Console.WriteLine($"Maximul in vector este :{ minim}");
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine();
			FactorialHelper.PrintMinim(new int[] { 6, 20, 3, -6, -8 });
			Console.WriteLine();

		}
	}
}
