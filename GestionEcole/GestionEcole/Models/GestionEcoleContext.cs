using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GestionEcole.Models
{
    public partial class GestionEcoleContext : DbContext
    {
        
        public GestionEcoleContext(DbContextOptions<GestionEcoleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Etudiant> Etudiants { get; set; }      
    }
}
