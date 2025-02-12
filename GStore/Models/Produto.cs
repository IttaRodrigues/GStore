namespace GStore.Models;


    public class Produto
    {
        public  int Id { get; set; }
        
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        public int Nome { get; set; }

        public string Descricao { get; set; }

        public int Qtde { get; set; }

        public decimal ValorCusto { get; set; }
        
        public decimal ValorVenda { get; set; }
    }
