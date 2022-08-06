using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;

namespace LanchesMac.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        //Instancia do contexto(dados sql) no construtor
        public CategoriaRepository(AppDbContext context)
        {
            _context = context; 
        }
        //Retorna os dados da tabela categoria (Esta parte é o repository!) 
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
