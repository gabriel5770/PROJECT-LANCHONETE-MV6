using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        //Obtém uma coleção de objetos Categorias
        IEnumerable<Categoria> Categorias { get; }
    }
}
