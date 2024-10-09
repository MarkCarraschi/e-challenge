using EcommerceCSharpChallenge.Domain.Interfaces;
using EcommerceCSharpChallenge.Domain.Models;

namespace EcommerceCSharpChallenge.Application;

public class ProdutoService : IProdutoService
{
    public Task Atualizar(Produto produto)
    {
        throw new NotImplementedException();
    }

    public Task DeletarProduto(Produto produto)
    {
        throw new NotImplementedException();
    }

    public Task InserirProduto(Produto produto)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Produto>> ObterListaProdutos(Produto produto)
    {
        throw new NotImplementedException();
    }
}
