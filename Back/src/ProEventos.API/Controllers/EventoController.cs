using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento()
            {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Cuiabá",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
            },
            new Evento()
            {
                EventoId = 2,
                Tema = "Angular e suas novidades",
                Local = "BH",
                Lote = "2º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto2.png"
            }
        };

        public EventoController() { }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(Evento => Evento.EventoId == id);
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
