using GestionEcole.Models;
using Microsoft.EntityFrameworkCore;
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

        public Etudiant GetEtudiant(int id)
        {
            try
            {
                var etudiant = _gestionEcoleContext.Etudiants.Find(id);
                return etudiant;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void AddEtudiant(Etudiant etudiant)
        {
            try
            {
                _gestionEcoleContext.Etudiants.Add(etudiant);
                _gestionEcoleContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Etudiant DeleteEtudaint(int id)
        {
            try
            {
                var etduiant = GetEtudiant(id);
                _gestionEcoleContext.Etudiants.Remove(etduiant);
                _gestionEcoleContext.SaveChanges();
                return etduiant;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void UpdateEtudiant(Etudiant etudiant)
        {
            try
            {
                _gestionEcoleContext.Entry(etudiant).State = EntityState.Modified;
                _gestionEcoleContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
