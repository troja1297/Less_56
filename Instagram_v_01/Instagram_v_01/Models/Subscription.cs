using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Instagram_v_01.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        [ForeignKey("ApplicationUser")]
        public string SubscriberId { get; set; }
        public ApplicationUser Subscriber { get; set; }
    }
}