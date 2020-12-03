using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AppBolo2.Models;

namespace AppBolo2.Models
{
    public class Pedido
    {
        [Display(Description = "ID")]
        [Key]
        public int Id { get; set; }

        [Display(Description = "DATA DO PEDIDO")]
        public int DataPedido { get; set; }

        [Display(Description = "STATUS DO PEDIDO")]
        public string StatusPedido { get; set; }

        [Display(Description = "TIPO DO PEDIDO")]
        public string TipoPedido { get; set; }

        [Display(Description = "VALOR TOTAL")]
        public float ValorTotal { get; set; }

        [Display(Description = "PAGAMENTO")]
        public Pagamento Pagamento { get; set; }

        [Display(Description = "BOLOS")]
        public List<Bolo> Bolo { get; set; }

    }
}
