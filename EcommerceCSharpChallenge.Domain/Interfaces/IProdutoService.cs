using EcommerceCSharpChallenge.Domain.Models;

namespace EcommerceCSharpChallenge.Domain.Interfaces
{
    public interface IProdutoService
    {
        public Task InserirProduto(Produto produto);
        public Task Atualizar(Produto produto);
        public Task<IEnumerable<Produto>> ObterListaProdutos(Produto produto);
        public Task DeletarProduto(Produto produto);
    }
}
