using System.ComponentModel.DataAnnotations;

namespace Academico.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        [Display(Name = ("E-mail"))]
        public string Email { get; set; }

        [Display(Name =("Instituição"))]
        public int InstituicaoId { get; set; }
        public Instituicao? InstituicaoOrigem { get; set; } //interrogação indica que o objeto pode ser nulo, e que o de cima será a chave estrangeira (não o InstituicaoOrigem)

        [Display(Name = ("Coordenador"))]
        public string NomeCoordenador { get; set; }

    }
}
