using System;
using System.Collections.Generic;

#nullable disable

namespace GestionEcole.Models
{
    public partial class Etudiant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public int? Age { get; set; }
    }
}
