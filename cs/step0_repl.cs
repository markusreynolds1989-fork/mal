using System;

namespace cs 
{
	public static class REPL 
	{
		public static string Read() 
		{
			Console.Write("user> ");	
			return Console.ReadLine();
		}

		public static string Eval(string input) 
		{
			return input;
		}

		public static string Print(string input)
		{
			Console.WriteLine(input);
			return input;
		}

		public static void rep() 
		{
			while(true)
			{
				Print(Eval(Read()));	
			}	
		}
	}	
}
