using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o E-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        public strig Password { get; set; }
    }
}
