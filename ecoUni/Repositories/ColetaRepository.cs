using ecoUni.Context;
using ecoUni.Models;
using ecoUni.Repositories.Interfaces;

namespace ecoUni.Repositories
{
    public class ColetaRepository : IColetaRepository
    {
        private readonly AppDbContext _context;

        public ColetaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Coleta> Coletas => _context.Coletas;
    }
}
