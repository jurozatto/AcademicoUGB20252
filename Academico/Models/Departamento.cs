namespace Academico.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int InstituicaoId { get; set; }
        public Instituicao? InstituicaoOrigem { get; set; } //interrogação indica que o objeto pode ser nulo, e que o de cima será a chave estrangeira (não o InstituicaoOrigem)

    }
}
