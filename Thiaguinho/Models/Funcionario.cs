namespace Thiaguinho.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Cargo { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
    }
}
