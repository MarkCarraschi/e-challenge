var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//1.Autenticação de usuários: Permitir que os usuários façam login e mantenham suas sessões autenticadas (clientes e administradores) com distinção de permissões.
app.MapPost("/autenticar", () =>
{
    //Implementation
})
.WithName("/autenticar")
.WithOpenApi();

//2.catálogo de produtos: Permitir ao administrador criar, atualizar, listar e excluir produtos.

app.MapPost("/criar-produto", () =>
{
    //Implementation
})

.WithName("CriarProduto")
.WithOpenApi();

app.MapPut("/atualizar-produto", () =>
{
    //Implementation
})

.WithName("AtualizarProduto")
.WithOpenApi();

app.MapGet("/listar-produtos", () =>
{
    //Implementation
})
.WithName("ObterListaProdutos")
.WithOpenApi();

app.MapDelete("/excluir-produto", () =>
{
    //Implementation
})
.WithName("ExcluirProduto")
.WithOpenApi();

app.Run();
