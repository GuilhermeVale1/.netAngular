using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly ILogger<EventoController> _logger;

        public EventoController(ILogger<EventoController> logger)
        {
            _logger = logger;
        }

        public IEnumerable<Evento> _evento = new Evento[]
        {
             new Evento()
                {
                    EventoId = 2,
                    Tema = "Angular",
                    Local = "bh",
                    Lote = "1",
                    QtdPessoas = 10,
                    DataEvento = DateTime.Now.AddDays(0).ToString(),
                    ImagemURL = "Segredo.png"
                },
              new Evento()
                {
                    EventoId = 2,
                    Tema = "Angular",
                    Local = "bh",
                    Lote = "1",
                    QtdPessoas = 20,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "Segredo.png"
                }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
           
          
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);


        }


        [HttpPost]

        public string Post(){
            return "Postman aqui rapa";
        }

        [HttpPut("{id}")]

         public string Put(int id){
            return $"Put aqui rapa com id: {id}";
        }

        [HttpDelete("{id}")]

         public string Delete(int id){
            return $"Delete aqui rapa com id: {id}";
        }
    }
}
