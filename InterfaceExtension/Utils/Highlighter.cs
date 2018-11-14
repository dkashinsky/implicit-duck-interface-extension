using System;

namespace InterfaceExtension.Utils
{
	public static class Highlighter
	{
		public static void ConsoleWriteLine(string message, ConsoleColor color)
		{
			var current = Console.ForegroundColor;
			Console.ForegroundColor = color;
			Console.WriteLine(message);
			Console.ForegroundColor = current;
		}
	}
}
