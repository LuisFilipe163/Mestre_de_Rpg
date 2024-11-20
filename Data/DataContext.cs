using Mestre_de_Rpg.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestre_de_Rpg.Data
{
    internal class DataContext : DbContext
    {
        public DbSet<FichaJogador> Jogadores { get; set; } = null!;

        public DbSet<Aventura> Aventuras { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=adventures.db");
        }
    }
}
