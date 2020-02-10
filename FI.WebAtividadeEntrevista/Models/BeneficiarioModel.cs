using System.ComponentModel.DataAnnotations;

namespace WebAtividadeEntrevista.Models
{
    public class BeneficiarioModel
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o CPF", AllowEmptyStrings = false)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        public long IDCliente { get; set; }
    }
}