using System.Linq;
using System.Threading.Tasks;
using Instagram_v_01.Data;
using Instagram_v_01.Models;
using Instagram_v_01.Models.PostModels;
using Microsoft.AspNetCore.Mvc;

namespace Instagram_v_01.Controllers
{
    public class LikeController : Controller
    {
        private static ApplicationDbContext _context;

        public LikeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> LikePost(LikeModel model)
        {


            var likes = _context.Likes.Where(l => l.UserId == model.UserId).ToList();
            if (likes.Any(l => l.PostId == model.PostId))
            {
                return RedirectToAction("Index", "Post");
            }
                var post = _context.Posts.Find(model.PostId);
                post.LikeCount +=  1;
                _context.Add(model);
                _context.Update(post);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Post");


        }
    }
}