using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API5.Models;

namespace ProEventos.API5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {

            new Evento(){
            EventoId = 1,
            Tema = "Angular 11 e .NET 5",
            Local = "Belo Horizinte",
            Lote = "1º Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemURL = "foto.png"
            },
            new Evento(){
            EventoId = 2,
            Tema = "Angular e suas novidades",
            Local = "São Paulo",
            Lote = "2º Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemURL = "1foto.png"
            },

        };

        public EventoController()
        {            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where( a => a.EventoId == id);
        }

       

        [HttpPost]
        public string Post()
        {
           return "exemplo de post";
        }

        [HttpPut("{id}")]
        public string Post(int id)
        {
           return $"exemplo de Put com id =  {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return $"exemplo de Delete com id =  {id}";
        }
    }
}
