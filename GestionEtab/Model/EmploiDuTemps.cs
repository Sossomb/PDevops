using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionEtab.Model
{
    public class EmploiDuTemps
    {
        [Key]
        public int IdEmploi { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Salle { get; set; }

        [Required]
        public TimeSpan HeureDebut { get; set; }

        [Required]
        public TimeSpan HeureFin { get; set; }

        // Relation avec Cours
        [Required]
        public int IdCours { get; set; }

        [ForeignKey("IdCours")]
        public virtual Cours Cours { get; set; }

        // Relation avec Classe
        [Required]
        public int IdClasse { get; set; }

        [ForeignKey("IdClasse")]
        public virtual Classe Classe { get; set; }

        public int IdProf { get; set; }

        [ForeignKey("IdProf")]
        public virtual Prof Prof { get; set; }
    }
}
