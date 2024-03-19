using ecoUni.Models;

namespace ecoUni.Repositories.Interfaces
{
    public interface IColetaRepository
    {
        IEnumerable<Coleta> Coletas { get; }
    }
}
