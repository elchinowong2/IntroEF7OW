using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntroduccionEFCore.Entidades.Configuraciones
{
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.Property(p => p.Nombre).HasMaxLength(150);
            builder.Property(p => p.FechaNacimiento).HasColumnType("Date");
            builder.Property(p => p.Fortuna).HasPrecision(18, 2);
        }
    }
}
