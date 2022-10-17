using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice2.Models;
using System.Diagnostics;

namespace Practice2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDBContext _dbContext;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> TableOfInformations()
        {
            return View(await _dbContext.SpongeBobFriends.ToListAsync());
        }

        public async Task<IActionResult> Details(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var friend = await _dbContext.SpongeBobFriends.FirstOrDefaultAsync(m => m.Id == id);

            if (friend == null)
            {
                return NotFound();
            }

            return View(friend);
        }

        public async Task<IActionResult> Search(string name)
        {
            var query = from m in _dbContext.SpongeBobFriends
                        where m.FirstName == name
                        select m;

            return View(query);            
        }
    }
}