using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GStore.Models;

[Table("produto")]
    public class Produto
    {
        [Key]
         public int Id { get; set; }  

        [Required(ErrorMessage = "Por favor, informe a Categoria")]
        public int CategoriaId { get; set; }
       
        [ForeignKey(nameof(CategoriaId))]
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Nome")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Descrição", Prompt = "Descrição")]
        [StringLength(1000, ErrorMessage = "O Descrição deve possuir no máximo 1000 caracteres")]
        public string Descricao { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int QtdeEstoque { get; set; } = 0;

        [Range(0, double.MaxValue)]
        [Column(TypeName = "numeric(10,2)")]
        public decimal ValorCusto { get; set; } = 0;

        [Range(0, double.MaxValue)]
        [Column(TypeName = "numeric(10,2)")]
        public decimal ValorVenda { get; set; }

        public bool Destaque { get; set; } = false;

        public List<ProdutoFoto> Fotos { get; set; }
    }