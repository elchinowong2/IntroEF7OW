﻿namespace IntroduccionEFCore.Entidades
{
    public class PeliculaActor
    {
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; } = null!;
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public string Personaje { get; set; }
        public int Orden  { get; set; }
    }
}
