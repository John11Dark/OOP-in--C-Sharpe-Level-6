using System;

namespace workSheetOne
{
	public class RandomNumbers
	{
		private int number1;
		private int number2;
		private int sum;

		public RandomNumbers()
		{
			GenerateNumbers();
		}

		public void GenerateNumbers()
		{
			Random random = new Random();
			number1 = random.Next(1, 11);
			number2 = random.Next(1, 11);
			sum = number1 + number2;
		}

		public int GetNumber1()
		{
			return number1;
		}

		public int GetNumber2()
		{
			return number2;
		}

		public int FindSum()
		{
			return sum;
		}

		public bool IsEqual(int guess)
		{
			return guess == sum;
		}
	}
	}


