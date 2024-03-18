using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecoUni.Models
{
    [Table("Coletas")]
    public class Coleta
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe a quantidade de sacos")]
        public string QuantidadeSacos { get; set; }
        [Required(ErrorMessage = "Informe o tamanho do saco")]
        public int TamanhoSaco { get; set; }
        public string Observacoes { get; set; }
        [NotMapped]
        public DateTime DataColeta { get; set; }
    }
}
