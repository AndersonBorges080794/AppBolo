using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppBolo2.Models
{
    public class Bolo
    {
        [Display(Name ="ID DO BOLO")]
        [Key]
        public int IdBolo { get; set; }

        [Display(Name = "Recheio")]
        public string SaborRecheio { get; set; }

        [Display(Name = "Massa")]
        public string SaborMassa { get; set; }

        [Display(Name = "Tema")]
        public Tema Tema { get; set; }//Não aparece para o usuário

        [Display(Name = "Cobertura")]
        public string TipoCobertura { get; set; }

        [Display(Name = "Diamentro")]
        public float DiamentroCentimetro { get; set; }

        [Display(Name = "Quantidade de Andar")]
        public int QuantidadeAndar { get; set; }

        [Display(Name = "Quantidade de Bolo")]
        public int QuantidadeBolo { get; set; }

        [Display(Name = "Valor")]
        public float ValorUnitario { get; set; }
    }
}
