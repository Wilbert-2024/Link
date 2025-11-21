using Linck.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;


namespace Linck.Data
{
    internal class DBase:DbContext
    {
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Boveda> boveda { get; set; }
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Linkss> linkss { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Proycto;Integrated Security=True; TrustServerCertificate=true");

            }
        }



    }
}
