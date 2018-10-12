using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Instagram_v_01.Models.PostModels
{
    public class PostModel
    {
        public string Id { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public string ImageSource { get; set; }
        public string Description { get; set; }
        public int LikeCount { get; set; }
        public DateTime PostDate { get; set; }
    }
}