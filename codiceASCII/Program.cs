using System;

namespace codiceASCII
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Inserisci un carattere");
			char carattere = Convert.ToChar(Console.ReadLine());
		    int number = carattere;
			number = number + 4;
 
			Console.WriteLine($"Il carattere digitato corrisponde al carattere {number.ToString()}");
			string binario = Convert.ToString(number, 2).PadLeft (8, '0');
			Console.WriteLine($" Il carattere in binario è {binario}");
			Console.ReadLine();
	     }
    }
}

