using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API5.Models;
using ProEventos.Api5.Data;

namespace ProEventos.API5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {       
        private readonly DataContext _context;

        public EventosController(DataContext context)
        {            
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault( a => a.EventoId == id);
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
