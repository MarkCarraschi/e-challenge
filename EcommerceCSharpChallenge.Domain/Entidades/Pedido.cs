using EcommerceCSharpChallenge.Domain.Enums;

namespace EcommerceCSharpChallenge.Domain.Models
{
    public class Pedido
    {
        IEnumerable<Produto> Produtos { get; set; }
        EPagamento EPagamento { get; set; }
    }
}
