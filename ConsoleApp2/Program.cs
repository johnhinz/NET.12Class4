using System;

namespace SomeName
{

	public class Program
	{
		public static void Main()
		{

            Console.WriteLine("Please enter a sequence:");
			string userInput = Console.ReadLine();
			string[] arrayInput = userInput.Split('+');
			int sum = 0;


			foreach (string y in arrayInput)
            {
				sum = int.Parse(y) + sum;
			}

			//for (int i = 0; i < arrayInput.Length; i++)
   //         {
			//	sum = int.Parse(arrayInput[i]) + sum;
			//}

            Console.WriteLine($"The sumation of your input is: {sum}");

		}
	}

}