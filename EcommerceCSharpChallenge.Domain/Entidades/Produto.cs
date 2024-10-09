namespace EcommerceCSharpChallenge.Domain.Models;

public class Produto
{
    public long Id { get; set; }
    public string Nome { get; set; } = String.Empty;
    public decimal Preco { get; set; } = Decimal.Zero;
}
