namespace Cadastro;

public class Cliente
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateOnly Birthdate { get; set; }
    public DateTime CreatedAt { get; set; }
    public decimal Discount { get; set; }
}