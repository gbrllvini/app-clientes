using Cadastro;

namespace Repository;

public class ClienteRepository
{
    public List<Cliente> clientes = new();

    public void Show(Cliente cliente)
    {
        Console.WriteLine("ID.............:" + cliente.Id);
        Console.WriteLine("Nome...........:" + cliente.Name);
        Console.WriteLine("Desconto.......:" + cliente.Discount.ToString("0.00"));
        Console.WriteLine("Data Nascimento:" + cliente.Birthdate);
        Console.WriteLine("Data Cadastro..:" + cliente.CreatedAt);
        Console.WriteLine(".................................:");
    }

    public void ShowAll(List<Cliente> clientes)
    {
        Console.Clear();

        foreach (var cliente in clientes)
        {
            Show(cliente);
        }

        Console.ReadKey();
    }

    public void Create()
    {
        Console.Clear();

        Console.WriteLine("Nome do cliente: ");
        var name = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.WriteLine("Data de nascimento: ");
        var birthDate = DateOnly.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.WriteLine("Desconto: ");
        var discount = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        var cliente = new Cliente
        {
            Id = clientes.Count + 1,
            Name = name,
            Discount = discount,
            Birthdate = birthDate,
            CreatedAt = DateTime.Now
        };

        clientes.Add(cliente);

        Console.WriteLine("Cliente Cadastrado com sucesso! [Enter]");
        Show(cliente);
        Console.ReadKey();
    }
}