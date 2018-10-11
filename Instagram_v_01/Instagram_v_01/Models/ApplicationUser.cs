using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Instagram_v_01.Models.PostModels;
using Microsoft.AspNetCore.Identity;

namespace Instagram_v_01.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string UserAbout { get; set; }
        public string UserPhoto { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }

        public IEnumerable<Subscription> Subscriptions { get; set; }
        public IEnumerable<PostCommentModel> PostCommentModels { get; set; }
        public IEnumerable<UserPostModel> UserPostModels { get; set; }



    }
}
