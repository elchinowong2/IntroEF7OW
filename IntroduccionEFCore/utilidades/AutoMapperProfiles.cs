using AutoMapper;
using IntroduccionEFCore.DTOs;
using IntroduccionEFCore.Entidades;

namespace IntroduccionEFCore.utilidades
{
    public class AutoMapperProfiles : Profile
    {
        protected AutoMapperProfiles()
        {
            CreateMap<GeneroCreacionDTO, Genero>();
        }
    }
}
