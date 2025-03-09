using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionEtab.Model
{
    public class Classe
    {
        [Key]
        public int IdClasse { get; set; }

        [Required]
        [StringLength(100)]
        public string NomClasse { get; set; }

        // Relation avec les étudiants
        public virtual List<Etudiant> Etudiants { get; set; } = new List<Etudiant>();

        // Relation avec les cours
        public virtual List<Cours> Cours { get; set; } = new List<Cours>();
    }
}
