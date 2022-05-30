using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] { };
        private readonly DataContext context;

        public EventosController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return context.Eventos.FirstOrDefault(Evento => Evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string DeleteHttpDelete(int id)
        {
            return $"Exemplo de delete com id = {id}";
        }
    }
}
