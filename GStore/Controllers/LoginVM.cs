using System.ComponentModel.DataAnnotations;

namespace GStore.Controllers;

    public class LoginVM
    {
        [Display(Name = "Email ou Nome do Usuário", Prompt = "Informe seu Email ou Nome de Usuario")]
        [Required(ErrorMessage = "Por favor, informe seu email ou nome de usuario")]
        public string Email { get; set; }  

        [Display(Name = "Senha de Acesso", Prompt = "********")]
        [Required(ErrorMessage = "Por favor, informe sua senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }  

        [Display(Name = "Manter conectado")]
        public bool Lembrar { get; set; } = false;
        public string UrlRetorno { get; set; }  
    }
