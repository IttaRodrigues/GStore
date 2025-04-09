using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace GStore.Models;

[Table("usuario")]
    public class Usuario : IdentityUser // não precisa de identityuser caso não queira avatar no login
    {   
        [Required(ErrorMessage = " Por favor, digite seu nome")]
        [StringLength(60, ErrorMessage = " O nome deve possuir no maximo 60 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime? DataNascimento { get; set; }

        [StringLength (300)]
        public string Foto { get; set; }
    }
