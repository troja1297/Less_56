using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Instagram_v_01.Models.PostModels;

namespace Instagram_v_01.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }

        public int SubscriptionCount { get; set; }
        public int SubscribersCount { get; set; }
        public int PostsCount { get; set; }
        public string Name { get; set; }
        public string AvatarPath { get; set; }
        public string Sex { get; set; }
        public List<PostModel> Posts { get; set; }

    }
}
