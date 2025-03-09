using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionEtab.Model
{
    public class Cours
    {
        [Key]
        public int IdCours { get; set; }

        [Required]
        [StringLength(100)]
        public string NomCours { get; set; }

        [Required]
        [Range(1, 100)]
        public int VolumeHoraire { get; set; }

        // Relation avec Prof
        [Required]
        public int IdProf { get; set; }

        [ForeignKey("IdProf")]
        public virtual Prof Prof { get; set; }

        // Relation avec Classe
        [Required]
        public int IdClasse { get; set; }

        [ForeignKey("IdClasse")]
        public virtual Classe Classe { get; set; }
    }
}
