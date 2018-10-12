using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Instagram_v_01.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Instagram_v_01.Models;
using Instagram_v_01.Models.PostModels;
using Instagram_v_01.Services;
using Microsoft.AspNetCore.Hosting;

namespace Instagram_v_01.Controllers
{
    public class PostController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private static ApplicationDbContext _context;
        private readonly IHostingEnvironment _environment;
        private readonly FileUploadService _fileUploadService;

        public PostController(
            UserManager<ApplicationUser> userManager,
            FileUploadService fileUploadService,
            IHostingEnvironment environment,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
            _fileUploadService = fileUploadService;
            _environment = environment;
        }

        public static ApplicationUser GetUser(string userId)
        {
            IQueryable<ApplicationUser> users = _context.Users.Where(u => u.Id == userId);
            return users.FirstOrDefault(u => u.Id == userId);
        }
        public async Task<IActionResult> Index()
        {
            var allPosts = _context.Posts.OrderBy(p => p.PostDate).ToList();
            PostViewModel model = new PostViewModel {Posts = allPosts};
            return View(model);
        }

        [HttpGet]
        public IActionResult CreatePost()
        {
            return View();
        }

        public async Task<IActionResult> CreatePost(PostViewModel model, string returnUrl = null)
        {
            var user = await _userManager.GetUserAsync(User);
            if (ModelState.IsValid)
            {
                string path = Path.Combine(
                    _environment.WebRootPath,
                    $"images\\{user.Name}\\");
                DateTime date = DateTime.Now;
                string userPhotoPath = $"/images/{user.Name}/{model.UserPhoto.FileName}";
                _fileUploadService.Upload(path, model.UserPhoto.FileName, model.UserPhoto);
                PostModel postModel = new PostModel{PostDate = date,LikeCount = 0, Description = model.Description, UserId = user.Id, ImageSource = userPhotoPath};
                _context.Add(postModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}