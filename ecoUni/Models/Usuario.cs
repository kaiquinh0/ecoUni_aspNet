using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoUni.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o nome do usuário")]
        [Display(Name = "Nome do usuário")]
        public string NomeUsuario { get; set; }
        [Required(ErrorMessage = "Informe sua senha")]
        [Display(Name = "Senha")]
        [StringLength(80, MinimumLength = 8, ErrorMessage = "Sua senha deve ter no mínimo 8 caracteres.")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Informe seu nome completo")]
        [Display(Name = "Nome completo")]
        public string NomeCompleto { get; set; }
        [Required(ErrorMessage = "Informe seu e-mail")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe seu telefone")]
        [Display(Name = "Telefone")]
        public int Telefone { get; set; }
    }
}
