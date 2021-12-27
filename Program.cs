using System;
using System.Diagnostics;

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
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
        public static void AddPort()
        {
            int[] portRange;

            int firstPort = FirstPort();
            int lastPort = LastPort();

            portRange = new int[lastPort - firstPort + 1];
            for (int i = 0; i < portRange.Length; i++)
            {
                portRange[i] = firstPort + i;
            }


            for (int i = 0; i < portRange.Length; i++)
            {
                string commandToExecute = @$"c:\\ligasistemas\\servidor\\ligasrv.exe /install -porta9{portRange[i].ToString().PadLeft(3, '0')}";
                Process.Start(@"cmd", @"/c " + commandToExecute);
                Console.WriteLine($"ligasrv /install -porta9{0}", portRange[i].ToString().PadLeft(3, '0'));
            }
            Console.Clear();
            Console.WriteLine(".............................");
            Console.WriteLine("Portas de " + firstPort + " à " + lastPort + " adicionadas");
            Console.WriteLine(".............................");
            Console.ReadKey();

        }
        public static void RemovePort()
        {
            int[] portRange;

            int firstPort = FirstPort();
            int lastPort = LastPort();

            portRange = new int[lastPort - firstPort + 1];
            for (int i = 0; i < portRange.Length; i++)
            {
                portRange[i] = firstPort + i;
            }


            for (int i = 0; i < portRange.Length; i++)
            {
                string commandToExecute = @$"sc delete ligasrv9{portRange[i].ToString().PadLeft(3, '0')}";
                Process.Start(@"cmd", @"/c " + commandToExecute);
                Console.WriteLine($"sc delete ligasrv9{0}", portRange[i].ToString().PadLeft(3, '0'));
            }
            //Console.Clear();
            Console.WriteLine(".............................");
            Console.WriteLine("Portas de " + firstPort + " à " + lastPort + " removidas");
            Console.WriteLine(".............................");
            Console.ReadKey();
        }
        public static void RestartPorts()
        {
            throw new NotImplementedException();
        }
        public static void ListPorts()
        {
            throw new NotImplementedException();
        }

        public static int FirstPort()
        {
            Console.WriteLine("Informe a primeira porta: ");
            int firstPort = int.Parse(Console.ReadLine());
            return firstPort;
        }

        public static int LastPort()
        {
            Console.WriteLine("Informe a última porta: ");
            int lastPort = int.Parse(Console.ReadLine());
            return lastPort;
        }


        public static int Menu()
        {
            Console.WriteLine("1. Adicionar portas");
            Console.WriteLine("2. Remover portas");
            Console.WriteLine("3. Reiniciar portas");
            Console.WriteLine("4. Listar portas");
            Console.WriteLine("5. Sair");
            Console.WriteLine("Escolha uma opção: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
