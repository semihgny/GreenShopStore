using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var product = _db.products.Where(i=>i.Ozel).ToList();
            return View(product);
        }

        public IActionResult Product()
        {
            var product = _db.products.Where(i => i.Ozel).ToList();
            return View(product);
        }


        public IActionResult About()
        {
            return View();
        }

		// GET: admin/contacts/Create
		public IActionResult contact()
		{
			return View();
		}

        public IActionResult Galeri()
        {
            var galeri = _db.galleri.ToList();
            return View(galeri);
        }

        // POST: admin/contacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> contact([Bind("id,name,eMail,mesaj,telefon,Tarih")] contact contacts)
		{
			if (ModelState.IsValid)
			{
			    _db.Add(contacts);
				await _db.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(contacts);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
