namespace Academico.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; } //classe domínio, vira tabela no banco
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CEP { get; set; }
    }
}
