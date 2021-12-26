using System;

namespace PortManager
{
    class Program
    {
        static void Main(string[] args)
        {

		}

		private static string Menu()
		{
			Console.WriteLine("1. Add Ports");
			Console.WriteLine("2. Remove Ports");
			Console.WriteLine("3. Restart Ports");
			Console.WriteLine("4. List Ports");
			Console.WriteLine("5. Exit");
			Console.WriteLine("Choose an option: ");
			string choice = Console.ReadLine();
			return choice;
		}
    }
}
