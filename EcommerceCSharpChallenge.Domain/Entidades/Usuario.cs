using EcommerceCSharpChallenge.Domain.Enums;

namespace EcommerceCSharpChallenge.Domain.Models
{
    public  class Usuario
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public ETipoUsuario ETipoUsuario { get; set; }
    }
}
