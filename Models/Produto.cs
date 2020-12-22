namespace app_net_core.Models
{
    public class Produto
    {
        public Categoria categoria { get; set; }
        public int CategoriaId { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}