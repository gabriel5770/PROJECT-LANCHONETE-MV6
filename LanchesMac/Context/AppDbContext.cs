using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Context
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //DbContextOptions define as opções a serem usadas
            //pelo dbContext. Ela vai carregar as informações de configuração necessária para
            //carregar o dbContext

        }

          //dbSet define quais classes quer mapear para quais tabelas

        //As variáveis abaixo iram virar tabelas
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }

    }
}
