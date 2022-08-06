using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        //Coleção de objetos categorias
        IEnumerable<Categoria> Categorias { get; }
    }
}
