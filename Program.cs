using System;

namespace EnterOnlyNumbersUsingDoWhileLoop;

public class Program
{
	static void Main(string[]args)
	{
		double val = 0;
		string num = "";
		Console.Write("Enter Number: ");
		ConsoleKeyInfo chr;
		do
		{
			chr = Console.ReadKey(true);
			if (chr.Key != ConsoleKey.Backspace)
			{
				bool control = double.TryParse(chr.KeyChar.ToString(), out val);
				if (control)
				{
					num += chr.KeyChar;
					Console.Write(chr.KeyChar);
					Console.Write("\b \b");
				}
			}
		}
		while (chr.Key != ConsoleKey.Enter);
        Console.ReadKey();
    }
}