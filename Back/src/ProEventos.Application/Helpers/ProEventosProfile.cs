using ProEventos.Application.DTO;
using ProEventos.Domain;
using AutoMapper;

namespace ProEventos.API.Helpers
{
    public class ProEventosProfile : Profile
    {
        public ProEventosProfile()
        {
            CreateMap<Evento, EventoDto>().ReverseMap();
            CreateMap<Lote, LoteDto>().ReverseMap();

            CreateMap<Palestrante, PalestranteDto>().ReverseMap();

            CreateMap<RedeSocial, RedeSocialDto>().ReverseMap();
        }
    }
}
