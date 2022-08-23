using System.ComponentModel.DataAnnotations;

namespace Cliente.Models
{
    public class Cli
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "E-mail Inválido")]
        public string Email { get; set; }

        public string Endereco { get; set; }
    }

}
