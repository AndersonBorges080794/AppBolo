using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppBolo2.Dados;
using AppBolo2.Models;

namespace AppBolo2.Dados

{
    public class AppBoloContexto : DbContext
    {
        public AppBoloContexto(DbContextOptions<AppBoloContexto> options) : base(options)
        {

            //Database.EnsureCreated();// --> Estamos criando o banco

        }

        public DbSet<User> User { get; set; }// --> Modelo que o banco vai criar
        public DbSet<Tema> Tema { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Bolo> Bolo { get; set; }
        public object Movie { get; internal set; }
    }
}
