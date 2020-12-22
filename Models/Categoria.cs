using System.ComponentModel.DataAnnotations;
namespace app_net_core.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public System.Collections.Generic.List<Produto> Produtos { get; set; }
    }
}