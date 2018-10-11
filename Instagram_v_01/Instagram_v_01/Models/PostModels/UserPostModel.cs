using System.Collections.Generic;

namespace Instagram_v_01.Models.PostModels
{
    public class UserPostModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ImageSource { get; set; }
        public string Description { get; set; }
        public int LikeCount { get; set; }

        public IEnumerable<ApplicationUser> Users { get; set; }
        public IEnumerable<PostCommentModel> PostCommentModels { get; set; }
    }
}