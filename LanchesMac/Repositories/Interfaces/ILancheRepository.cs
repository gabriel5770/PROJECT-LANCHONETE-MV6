using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        //Obtém uma coleção de objetos Lanches
        IEnumerable<Lanche> Lanches { get; }
        //Obtém uma coleção de objetos LanchesPreferidos
        IEnumerable<Lanche> LanchesPreferidos { get; }
        //Obtém o lanche pelo seu ID
        Lanche GetLancheById(int lancheId);

    }
}
