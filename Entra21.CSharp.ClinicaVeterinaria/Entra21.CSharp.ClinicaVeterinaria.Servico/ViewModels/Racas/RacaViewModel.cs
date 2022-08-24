using System.ComponentModel.DataAnnotations;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModels.Racas
{
    public class RacaViewModel
    {
        // TODO Amanda
        //[Display(Name = "Nome")]
        [Display(Name = nameof(Nome))]
        [Required(ErrorMessage = "Preencha o campo {0}.")]
        [MinLength(4, ErrorMessage = "{0} deve conter no mínimo {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "{0} deve conter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        // TODO Amanda
        [Display(Name = "Espécie")]
        [Required(ErrorMessage = "Selecione uma {0}.")]
        public string Especie { get; set; }
    }
}