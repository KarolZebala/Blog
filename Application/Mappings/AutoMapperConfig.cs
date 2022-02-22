using Application.Dto;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * ta klasa jest zastąpiona pozostałymi 
namespace Application.Mappings
/*
{
    // W tej klasie odbywa się konfiguracja mapowania 
    // Klasa post mapuje się na PostDto
/*
public static class AutoMapperConfig
{
    public static IMapper Initialize()
        => new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Post, PostDto>();
            //dodanie mapowania, którego używamy przy dodawaniu postu
            cfg.CreateMap<CreatePostDto, Post>();
            cfg.CreateMap<UpdatePostDto, Post>();
        })
        .CreateMapper();

}
}
*/