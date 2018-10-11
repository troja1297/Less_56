using System.Collections.Generic;

namespace Instagram_v_01.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string SubscriptorUserId { get; set; }

        public IEnumerable<ApplicationUser> Users { get; set; }
    }
}