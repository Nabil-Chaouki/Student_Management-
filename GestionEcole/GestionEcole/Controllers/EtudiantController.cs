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
        public Etudiant Get(int id)
        {
            return _etudiantService.GetEtudiant(id);
        }

        // POST api/<EtudiantController>
        [HttpPost]
        public void Post([FromBody] Etudiant etudiant)
        {
            _etudiantService.AddEtudiant(etudiant);

        }

        // PUT api/<EtudiantController>/5
        [HttpPut]
        public void Put([FromBody] Etudiant etudiant)
        {
            _etudiantService.UpdateEtudiant(etudiant);
        }

        // DELETE api/<EtudiantController>/5
        [HttpDelete("{id}")]
        public Etudiant Delete(int id)
        {
            return _etudiantService.DeleteEtudaint(id);
        }
    }
}
