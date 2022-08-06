using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {

        //retorna uma coleção de objetos Categoria
        IEnumerable<Categoria> Categorias { get; }
    }
}
