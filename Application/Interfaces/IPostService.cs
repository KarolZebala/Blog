using Application.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPostService
    {
        IEnumerable<PostDto> GetAllPosts();

        PostDto GetPostById(int id);

        //Przekazujemy CreatePostDto bo nie oczekujemy od użytkownika id nowego postu
        PostDto AddNewPost(CreatePostDto newPost);

        void UpdatePost(UpdatePostDto updatePost);

        void DeletePost(int id);

    }
}
