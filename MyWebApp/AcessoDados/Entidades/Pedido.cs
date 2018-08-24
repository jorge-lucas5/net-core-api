using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApp.AcessoDados.Entidades
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime DataPedido { get; set; }
        public virtual ICollection<ItemPedido> itensPedidos { get; set; }

    }
}
