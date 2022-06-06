using System.Threading.Tasks;
using ProEventos.Application.DTO;
using ProEventos.Domain;

namespace ProEventos.Application.Contracts
{
    public interface IEventosService
    {
        Task<EventoDto> AddEventos(EventoDto model);
        Task<EventoDto> UpdateEvento(int eventoId, EventoDto model);
        Task<bool> DeleteEvento(int eventoId);

        Task<EventoDto[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);

        Task<EventoDto[]> GetAllEventosAsync(bool includePalestrantes = false);

        Task<EventoDto> GetEventoByIdAsync(int EventoId, bool includePalestrantes = false);
    }
}
