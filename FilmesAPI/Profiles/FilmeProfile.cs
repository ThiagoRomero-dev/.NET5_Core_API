using AutoMapper;
using FilmesAPI.Models;
using FilmesAPI.Data.Dtos;

namespace FilmesAPI.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            //Converter De - Para 
            CreateMap<FilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
        }
    }
}
