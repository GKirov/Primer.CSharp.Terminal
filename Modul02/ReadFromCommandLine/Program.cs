using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 0, b = 0;

			//Въвеждане на входни параметри
			Console.Write ("Моля въведете а: ");
			a = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Моля въведете b: ");
			b = Convert.ToInt32 (Console.ReadLine ());


			//Печат на резултат
			Console.Write ("\n");
			Console.WriteLine ( "Резултата а + b е " + (a + b).ToString () + "\n\n\n");
		}
	}
}
