using System.Collections.Generic;
using Instagram_v_01.Models.PostModels;
using Microsoft.AspNetCore.Http;

namespace Instagram_v_01.Models
{
    public class PostViewModel
    {
        public string Description { get; set; }
        public IFormFile UserPhoto { get; set; }
        public List<PostModel> Posts { get; set; }
    }
}