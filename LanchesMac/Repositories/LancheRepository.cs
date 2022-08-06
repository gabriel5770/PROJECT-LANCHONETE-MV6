using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        //Acessa o contexto (sql server) da classe Lanche
        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        //Obtém os lanches com um filtro linq

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);


        //Obtém os lanches preferidos com um filtro linq
        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.
                                   Where(l => l.IsLanchePreferido)
                                  .Include(c => c.Categoria);

        //Obtém os LancheId com um filtro linq
        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}
