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

    public void ShowAll()
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

        Console.Write("Nome do cliente: ");
        var name = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.Write("Data de nascimento: ");
        var birthDate = DateOnly.Parse(Console.ReadLine()!);
        Console.Write(Environment.NewLine);

        Console.Write("Desconto: ");
        var discount = decimal.Parse(Console.ReadLine()!);
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

    public void Edit()
    {
        Console.Clear();
        Console.Write("Informe o código do cliente: ");
        var code = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(code!));

        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado! [Enter]");
            Console.ReadKey();
            return;
        }

        Show(cliente);

        Console.Write("Nome do cliente: ");
        var name = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.Write("Data de nascimento: ");
        var birthDate = DateOnly.Parse(Console.ReadLine()!);
        Console.Write(Environment.NewLine);

        Console.Write("Desconto: ");
        var discount = decimal.Parse(Console.ReadLine()!);
        Console.Write(Environment.NewLine);

        cliente.Name = name;
        cliente.Birthdate = birthDate;
        cliente.Discount = discount;
        cliente.UpdatedAt = DateTime.Now;

        Console.WriteLine("Cliente Alterado com sucesso! [Enter]");
        Show(cliente);
        Console.ReadKey();
    }

    public void Delete()
    {
        Console.Clear();
        Console.Write("Informe o código do cliente: ");
        var code = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(code!));

        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado! [Enter]");
            Console.ReadKey();
            return;
        }

        Show(cliente);
        clientes.Remove(cliente);
        Console.WriteLine("Cliente removido com sucesso! [Enter]");
        Console.ReadKey();
    }
}