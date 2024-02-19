using Cadastro;

namespace Repository;

public class ClienteRepository
{
    public List<Cliente> clientes = new();

    public void ShowCliente(Cliente cliente)
    {
        Console.WriteLine("ID.............:" + cliente.Id);
        Console.WriteLine("Nome...........:" + cliente.Name);
        Console.WriteLine("Desconto.......:" + cliente.Desconto.ToString("0.00"));
        Console.WriteLine("Data Nascimento:" + cliente.Birthdate);
        Console.WriteLine("Data Cadastro..:" + cliente.CreatedAt);
        Console.WriteLine(".................................:");
    }

    public void ShowAllClientes(List<Cliente> clientes)
    {
        Console.Clear();

        foreach (var cliente in clientes)
        {
            ShowCliente(cliente);
        }

        Console.ReadKey();
    }
}