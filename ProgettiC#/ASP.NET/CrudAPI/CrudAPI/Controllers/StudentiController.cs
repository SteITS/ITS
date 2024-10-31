using CrudAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentiController : ControllerBase
    {
        public CrudContext _context;

        public StudentiController(CrudContext context)
        {
            _context = context;
        }

        [HttpGet("classe={classe}")]
        public List<Studenti> StudentiList(string classe)
        {
            var studenti = _context.Studentis.Where(x=>x.Classe == classe).ToList();
            return studenti;
        }

        [HttpGet("Nstudenti")]
        public int Nstudenti()
        {
            var studenti = _context.Studentis.Count();
            return studenti;
        }

        [HttpGet("cognome={cognome}")]
        public List<Studenti> Cognome(string cognome)
        {
            var studenti = _context.Studentis.Where(x => x.Cognome == cognome).ToList();
            return studenti;
        }

    }
}
