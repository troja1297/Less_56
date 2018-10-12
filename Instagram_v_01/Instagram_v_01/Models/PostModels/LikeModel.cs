using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Instagram_v_01.Models.PostModels
{
    public class LikeModel
    {
        public int Id { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [ForeignKey("Postmodel")]
        public string PostId { get; set; }
        public PostModel Post { get; set; }

    }
}