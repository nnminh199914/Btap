using System;
using System.Collections.Generic;
namespace binary
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			// phần 1
			Console.WriteLine ("Input the number of numbers: ");

			string input = Console.ReadLine();

			int number;
			Int32.TryParse(input, out number);
			Console.WriteLine (number);

		    

			Random random = new Random ();
			List<int> list = new List<int>();
			for (int i = 0; i < number ; i++) {
				int n = random.Next (1, 100);
				list.Add (n);
				string binary = Convert.ToString(n , 2);
				Console.Write ("the binary number of " + n + " is: ");
				Console.WriteLine (binary);

			}
			*/


			// phần 2

			Console.WriteLine ("Input the number of numbers: ");

			string input = Console.ReadLine();

			int number;
			int liquid = 0;
			Int32.TryParse(input, out number);

				Random random = new Random ();
				List<int> list = new List<int>();
			for (int i = 0; i < number ; i++) {
				int n = random.Next (1, 100);
				list.Add (n);
			}

			// ***is*****************

				int ucln = 167822131231 ;

			for (int i = 0; i < number; i++) {
				Console.WriteLine (list [i]);
			}

			//**********************


			for (int i = 0; i < number; i++) {
					int n = random.Next (1, 100);
					list.Add (n);
					}
			for (int sobichia = 1; sobichia <= list[0]; sobichia++) {
					for (int b = 0; b < number; b++) {
					if (list[b] % sobichia == 0){
						
						
						liquid = liquid +1 ;

						}
					}
				if(liquid==number-1){
					ucln = sobichia;
					}
			
				}
		
				Console.Write("ucln " + ucln+ "  ");

		}
	}
}

