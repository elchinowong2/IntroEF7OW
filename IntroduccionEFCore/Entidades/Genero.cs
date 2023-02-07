using System.ComponentModel.DataAnnotations;

namespace IntroduccionEFCore.Entidades
{
    public class Genero
    {
        [Key]
        public int id { get; set; }
        [StringLength(maximumLength: 150)]
        public string Nombre { get; set; } = null!;
        public HashSet<Pelicula> Peliculas { get; set;} = new HashSet<Pelicula>();
    }
}
