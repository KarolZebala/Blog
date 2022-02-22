using Application.Dto;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public PostService(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public PostDto AddNewPost(CreatePostDto newPost)
        {
            if (string.IsNullOrEmpty(newPost.Title))
            {
                throw new Exception("Post can not have empty title.");

            }

            var post = _mapper.Map<Post>(newPost);
            _postRepository.Add(post);
            return _mapper.Map<PostDto>(post);

        }

        public void DeletePost(int id)
        {
            var post = _postRepository.GetById(id);
            _postRepository.Delete(post);
        }

        public IEnumerable<PostDto> GetAllPosts()
        {
            var posts = _postRepository.GetAll();
            //tak można zrobić ręcznie mapowanie 
            //return posts.Select(post => new PostDto
            //{
            //  Id = post.Id,
            //Title = post.Title,
            //Content = post.Content

            //});

            //Ale my możemy się posłużyć AutoMapperem
            return _mapper.Map<IEnumerable<PostDto>>(posts);
         
        }

        public PostDto GetPostById(int id)
        {
            var post = _postRepository.GetById(id);
            //Mapowanie za pomocą AutoMappera
            return  _mapper.Map<PostDto>(post);

            //Tak można ręcznie zmapować 
            return new PostDto()
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content
            };
        }

        public void UpdatePost(UpdatePostDto updatePost)
        {
            
            
            var existingPost = _postRepository.GetById(updatePost.Id);
            //jak tak zrobimy to dostaniemy nową wartość Content i zachowamy stary tytuł
            var post = _mapper.Map(updatePost, existingPost);
            _postRepository.Update(post);
        }


    }
}
