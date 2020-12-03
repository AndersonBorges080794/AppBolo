using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppBolo2.Models
{
    public class Pagamento
    {
        [Display(Description = "ID DO PAGAMENTO")]
        [Key]
        public int IdPagamento { get; set; }

        [Display(Description = "TIPO DO PAGAMENTO")]
        public string TipoPagamento { get; set; }

        [Display(Description = "DATA DO PAGAMENTO")]
        public int DataPagamento { get; set; }

    }
}
