using System;

namespace bai1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("input your height in cm: ");

			int a = int.Parse(Console.ReadLine());

			Console.WriteLine ("input your weight in kg: ");

			int b = int.Parse(Console.ReadLine());

			float BMI = b / ((a / 100) * (a / 100));


			Console.WriteLine ("your BIM is " + BMI);

			//********************************************
			for (int i = 0; i < 5; i++) 
			{
				
			
				for (int h = 0; h < 5; h++) 
				{
					Console.Write ("*x");
				}
			Console.WriteLine ();
			//********************************************

			}
			Console.WriteLine ("Hello ");
			Console.WriteLine ("B max ");
		}
	}
}
