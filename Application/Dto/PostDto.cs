using Application.Mappings;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class PostDto : IMap
    {
        //tu celowo nie dajemy wszystkich właściwości bo nie chcemy ich zwracać do WebAPI
        //ponieważ przy dodawaniu nowego postu klient nie może podać id należy utworzyć nową 
        //klasę dto która będzie zawierać tylko właściwości Title i Content
        public  int Id { get; set; }
        public  string Title { get; set; }
        public  string Content { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Post, PostDto>();
        }
    }
}
