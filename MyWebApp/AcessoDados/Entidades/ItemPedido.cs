using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApp.AcessoDados.Entidades
{
    [Table("Item_Pedido")]
    public class ItemPedido
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        [Required]
        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
        [Required]
        public int Quantidade { get; set; }
    }
}
