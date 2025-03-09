using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionEtab.Model
{
    public class Etudiant
    {
        [Key]
        public int IdEtu { get; set; }

        [Required]
        [StringLength(50)]
        public string NomEtu { get; set; }

        [Required]
        [StringLength(50)]
        public string PrenomEtu { get; set; }

        [Required]
        [StringLength(20)]
        public string CIN { get; set; }

        [Phone]
        public string Tel { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime DateNaiss { get; set; }

        // Relation avec Classe
        [Required]
        public int IdClasse { get; set; }

        [ForeignKey("IdClasse")]
        public virtual Classe Classe { get; set; }
    }
}
