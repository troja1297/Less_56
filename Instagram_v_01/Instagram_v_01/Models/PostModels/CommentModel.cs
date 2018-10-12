using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Instagram_v_01.Models.PostModels
{
    public class CommentModel
    {
        public int Id { get; set; }
        [ForeignKey("Postmodel")]
        public string PostId { get; set; }
        public PostModel Post { get; set; }

        public string Comment { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}