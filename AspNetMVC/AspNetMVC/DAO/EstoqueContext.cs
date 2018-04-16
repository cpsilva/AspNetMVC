using AspNetMVC.Models;
using System.Data.Entity;

namespace AspNetMVC.DAO
{
    public class EstoqueContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<CategoriaDoProduto> Categorias { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}