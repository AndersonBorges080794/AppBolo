using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AppBolo2.Models;

namespace AppBolo2.Models
{
    [Table("USER")]// -->Nome da Tabela
    public class User
    {
        [Display(Name = "CÓDIGO")]// O display não está aparecendo para o usuário.
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Display(Name = "Telefone")]
        public float Telefone { get; set; }
               
        [Display(Name = "CPF")]
        public float CPF { get; set; }

        [Display(Name = "Cartão de Credito")]
        public float CartaoCredito { get; set; }

        [Display(Name = "Pedidos")]
        public List<Pedido> Pedidos { get; set; }//Não aprece essa opção para o usuário
    }
}
