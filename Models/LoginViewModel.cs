using System.ComponentModel.DataAnnotations;

namespace MeuProjetoAspNetCore.ViewModels{
    public class LoginViewModel{
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "E-mail ou Telefone")]
        public string EmailOrPhone {get; set;}

        [Required]
        public string Senha {get; set;}
    }
}