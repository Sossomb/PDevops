using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;

namespace GestionEtab.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EtablissementContext: DbContext
    {
        public EtablissementContext() : base("name=EtablissementContext")
        {
        }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Prof> Profs { get; set; }
        public DbSet<EmploiDuTemps> EmploiDuTemps { get; set; }
    }
    
    
}
