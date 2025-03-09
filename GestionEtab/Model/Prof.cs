using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionEtab.Model
{
    public class Prof
    {
        [Key]
        public int IdProf { get; set; }

        [Required]
        [MaxLength(50)]
        
        public string NomProf { get; set; }

        [Required]
        [MaxLength(50)]
        public string PrenomProf { get; set; }

        [Required]
        [EmailAddress]
        public string EmailProf { get; set; }

        [Phone]
        public string TelProf { get; set; }

        [Required]
        [MaxLength(100)]
        public string Specialite { get; set; }

        // Relation avec les cours
        public virtual List<Cours> Cours { get; set; } = new List<Cours>();
    }
}
