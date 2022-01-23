using GestionEcole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEcole.Services
{
   public interface IEtudiantService
    {
        IEnumerable<Etudiant> GetEtudiants();

    }
}
