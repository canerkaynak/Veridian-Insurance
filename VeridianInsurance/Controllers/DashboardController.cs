using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeridianInsurance.Models.ViewModels;
using VeridianInsurance.Models;
using Microsoft.AspNetCore.Authorization;

namespace VeridianInsurance.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<CustomUser> _userManager;
        public DashboardController(ApplicationDbContext context, UserManager<CustomUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {

            ViewData["Title"] = "Dashboard";

            var VM = new policyViewModel
            {
                Policies = _context.Policies.ToList()
            };

            ViewBag.Message = VM;

            return View();
        }
    }
}
