using GestionEcole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEcole.Services
{
    public class EtudiantService : IEtudiantService
    {
        public GestionEcoleContext _gestionEcoleContext { get; set; }
        public EtudiantService(GestionEcoleContext gestionEcoleContext)
        {
            _gestionEcoleContext = gestionEcoleContext;
        }

        public IEnumerable<Etudiant> GetEtudiants()
        {
            try
            {
                return _gestionEcoleContext.Etudiants.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
