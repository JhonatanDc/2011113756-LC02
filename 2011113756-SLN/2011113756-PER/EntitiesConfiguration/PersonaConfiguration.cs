using _2011113756_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011113756_PER.EntitiesConfiguration
{
    public class PersonaConfiguration : EntityTypeConfiguration<Persona>
    {
        public PersonaConfiguration()
        {
            //Table Configurations
            ToTable("Persona");
            HasKey(c => c.PersonaId);


            //Relationship Configurations
            //....

            Property(c => c.Nombre)
               .IsRequired()
               .HasMaxLength(50);

            Property(c => c.ApellidoPaterno)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.ApellidoMaterno)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
