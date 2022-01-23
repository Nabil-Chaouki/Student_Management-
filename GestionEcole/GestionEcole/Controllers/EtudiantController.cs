using GestionEcole.Models;
using GestionEcole.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEcole.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtudiantController : ControllerBase
    {
        public IEtudiantService _etudiantService { get; set; }
        public EtudiantController(IEtudiantService etudiantService)
        {
            _etudiantService = etudiantService;  
        }
        [HttpGet]
        public IEnumerable<Etudiant> Get()
        {
            return _etudiantService.GetEtudiants();

        }

        // GET api/<EtudiantController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EtudiantController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EtudiantController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EtudiantController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
