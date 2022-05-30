using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public class PalestrantesPersist : IPalestrantePersist
    {
        private readonly ProEventosContext _context;

        public PalestrantesPersist(ProEventosContext context)
        {
            _context = context;
        }

        public async Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.Include(e => e.RedesSociais);

            if (includeEventos)
            {
                query = query.Include(e => e.PalestrantesEventos).ThenInclude(pe => pe.Evento);
            }

            query = query.OrderBy(e => e.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante[]> GetAllPalestrantesByNomeAsync(
            string nome,
            bool includeEventos
        )
        {
            IQueryable<Palestrante> query = _context.Palestrantes.Include(e => e.RedesSociais);

            if (includeEventos)
            {
                query = query.Include(e => e.PalestrantesEventos).ThenInclude(pe => pe.Evento);
            }

            query = query.OrderBy(e => e.Id).Where(e => e.Nome.ToLower().Contains(nome.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante> GetPalestranteByIdAsync(
            int PalestranteId,
            bool includeEventos
        )
        {
            IQueryable<Palestrante> query = _context.Palestrantes.Include(e => e.RedesSociais);

            if (includeEventos)
            {
                query = query.Include(e => e.PalestrantesEventos).ThenInclude(pe => pe.Evento);
            }

            query = query.OrderBy(e => e.Id).Where(e => e.Id == PalestranteId);

            return await query.FirstOrDefaultAsync();
        }
    }
}
