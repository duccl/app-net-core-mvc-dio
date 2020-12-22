using System.ComponentModel.DataAnnotations;
namespace app_net_core.Models
{
    public class Produto
    {
        [Display(Name = "Descrição Categoria")]
        public Categoria categoria { get; set; }
        public int CategoriaId { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório!")]
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        [Range(1.00,double.MaxValue, ErrorMessage = "Valor Inválido!")]
        public decimal Preco { get; set; }
    }
}