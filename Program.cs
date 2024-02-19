using System.Globalization;
using Repository;

namespace AppClientes;

class Program
{

    static ClienteRepository _clienteRepository = new();

    static void Main(string[] args)
    {
        var culture = new CultureInfo("pt-BR");
        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;

        while (true)
        {
            Menu();

            Console.ReadKey();
        }
    }


    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Cadastro de Clientes");
        Console.WriteLine("--------------------");
        Console.WriteLine("1 - Cadastrar Cliente");
        Console.WriteLine("2 - Exibir Clientes");
        Console.WriteLine("3 - Editar Cliente");
        Console.WriteLine("4 - Excluir Cliente");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("--------------------");

        Option();
    }

    static void Option()
    {
        Console.Write("Escolha uma opção: ");
        var option = Console.ReadLine();

        switch (int.Parse(option!))
        {
            case 1:
                {
                    _clienteRepository.Create();
                    Menu();
                    break;
                }
            case 2:
                {
                    _clienteRepository.ShowAll();
                    Menu();
                    break;
                }
            case 3:
                {
                    _clienteRepository.Edit();
                    Menu();
                    break;
                }
            case 4:
                {
                    _clienteRepository.Delete();
                    Menu();
                    break;
                }
            case 5:
                {
                    Environment.Exit(0);
                    break;
                }
            default:
                {
                    Console.Clear();
                    Console.WriteLine("Opção Inválida!");
                    break;
                }
        }

    }

}
