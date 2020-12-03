using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppBolo2.Models
{
    public class Tema
    {
        [Display(Description = "ID")]
        [Key]
        public int IdTema { get; set; }

        [Display(Description = "Personalizado")]
        public string Personalizado { get; set; }

        [Display(Description = "Predefinido")]
        public string Predefinido { get; set; }

    }
}
