namespace IntroduccionEFCore.Entidades
{
    public class Comentario
    {
        public int ID { get; set; }
        public string? Contenido { get; set; }
        public bool Recomendar { get; set; }
        public int PeliculaID { get; set; }
        public Pelicula Pelicula { get; set; } = null!;
    }
    
}
