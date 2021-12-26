using System;

namespace PortManager
{
	class Program
	{
		static void Main(string[] args)
		{
			int choice = Menu();

			while (choice != 5)
			{
				switch (choice)
				{
					case 1:
						AddPort();
						break;
					case 2:
						RemovePort();
						break;
					case 3:
						RestartPorts();
						break;
					case 4:
						ListPorts();
						break;
					default:
						Console.WriteLine("Invalid choice");
						break;
				}
			}

		}

		private static void ListPorts()
		{
			throw new NotImplementedException();
		}

		private static void RestartPorts()
		{
			throw new NotImplementedException();
		}

		private static void RemovePort()
		{
			throw new NotImplementedException();
		}

		private static void AddPort()
		{
			throw new NotImplementedException();
		}


		private static int Menu()
		{
			Console.WriteLine("1. Add Ports");
			Console.WriteLine("2. Remove Ports");
			Console.WriteLine("3. Restart Ports");
			Console.WriteLine("4. List Ports");
			Console.WriteLine("5. Exit");
			Console.WriteLine("Choose an option: ");
			int choice = int.Parse(Console.ReadLine());
			return choice;
		}
	}
}
