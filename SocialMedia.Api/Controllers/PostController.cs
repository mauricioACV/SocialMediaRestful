﻿using Microsoft.AspNetCore.Mvc;
using SocialMedia.Infrastructure.Repositories;
using SocialMedia.Core.Interfaces;
using System.Threading.Tasks;
using SocialMedia.Core.Entities;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPost()
        {
            var post = await _postRepository.GetPosts();
            return Ok(post);
        }

        [HttpGet ("{id}")]
        public async Task<IActionResult> GetPos(int id)
        {
            var post = await _postRepository.GetPost(id);
            return Ok(post);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Post post)
        {
            await _postRepository.InsertPost(post);
            return Ok(post);
        }
    }
}

