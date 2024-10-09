using EcommerceCSharpChallenge.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceCSharpChallenge.Infra.Contexts;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options): base (options) { }

    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

}
