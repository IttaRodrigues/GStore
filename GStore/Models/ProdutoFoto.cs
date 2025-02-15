
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GStore.Models;

[Table("produto_foto")]
public class ProdutoFoto
{
    [Key]
    public int Id { get; set; } 

    [Required(ErrorMessage = "Por favor, informe o produto")]
    public int ProdutoId { get; set; }

    [ForeignKey(nameof(ProdutoId))]          
    public Produto Produto { get; set; }

    [Required]
    [StringLength(300)]
    public string ArquivoFoto { get; set; }

    [Display(Name = "Descrição")] 
    [StringLength(30, ErrorMessage = "A descricao deve possuir no máximo 30 caracteres")]
    public string Descricao { get; set; }
}
