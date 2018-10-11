using System.Collections.Generic;

namespace Instagram_v_01.Models.PostModels
{
    public class PostCommentModel
    {
        public int Id { get; set; }
        public string PostId { get; set; }
        public string Comment { get; set; }
        public string CommentatorUserId { get; set; }

        public IEnumerable<ApplicationUser> Users { get; set; }


    }
}