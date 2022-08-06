using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;

namespace LanchesMac.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {

        
        private readonly AppDbContext _context;
        //Acessa o contexto (sql server) da classe Categoria
        public CategoriaRepository(AppDbContext context)
        {
            _context = context; 
        }


        //Aqui o context da classe vira um repository
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
