using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{	
			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;
			string program_name = "Modul02 - Примери";
			string program_version = "1.0";

			//Събиране на числя
			a = 10;
			b = 5;

			sum = a + b;

			//За програмата
			Console.WriteLine ( program_name );
			Console.WriteLine ("Версия: " + program_version + "\n\n");


			//Писане в конзола
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write ( b );
			Console.Write (" = ");
			Console.WriteLine (sum );

			//Допълнителни оператори
			Console.WriteLine ("\nИзползване на +=");
			a += b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на -=");
			a -= b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на *=");
			a *= b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на ++");
			a ++;
			Console.WriteLine ( a );

			Console.WriteLine ("Стандартно делене: " + (7 / 3).ToString ()); // резултата ще е 2 (7 / 3 = 2,3333), заради целочисленото делене
			Console.WriteLine ("Остатък от делене: " + (7 % 3).ToString ());// това е остатъка от това което не може да раздели


		}
	}
}
