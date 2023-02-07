using IntroduccionEFCore.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace IntroduccionEFCore
{
    public class aplicationDbContext : DbContext
    {
        public aplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder modelConfigurationBuilder) {
            modelConfigurationBuilder.Properties<string>().HaveMaxLength(150);
        }

        public DbSet<Genero> Generos => Set<Genero>();  
        public DbSet<Actor> Actores => Set<Actor>(); 
        public DbSet<Pelicula> Peliculas => Set<Pelicula>();     

        public DbSet<Comentario> Comentarios => Set<Comentario>();
        public DbSet<PeliculaActor> PeliculasActores => Set<PeliculaActor>();
    }
}
