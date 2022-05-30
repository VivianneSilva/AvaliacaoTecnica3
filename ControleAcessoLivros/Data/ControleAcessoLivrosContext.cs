using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ControleAcessoLivros.Models;

namespace ControleAcessoLivros.Data
{
    public class ControleAcessoLivrosContext : DbContext
    {
        public ControleAcessoLivrosContext (DbContextOptions<ControleAcessoLivrosContext> options)
            : base(options)
        {
        }

        public DbSet<ControleAcessoLivros.Models.Autor> Autor { get; set; }

        public DbSet<ControleAcessoLivros.Models.Leitor> Leitor { get; set; }

        public DbSet<ControleAcessoLivros.Models.Leitura> Leitura { get; set; }

        public DbSet<ControleAcessoLivros.Models.Livro> Livro { get; set; }

        public DbSet<ControleAcessoLivros.Models.StatusLivro> StatusLivro { get; set; }
    }
}
