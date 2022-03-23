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
        Etudiant GetEtudiant(int id);
        void AddEtudiant(Etudiant etudiant);
        Etudiant DeleteEtudaint(int id);
        void UpdateEtudiant(Etudiant etudiant);
    }
}
