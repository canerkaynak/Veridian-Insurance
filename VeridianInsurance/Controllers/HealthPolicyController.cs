using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VeridianInsurance.Models;
using VeridianInsurance.Models.ViewModels;

namespace VeridianInsurance.Controllers
{
    [Authorize]
    public class HealthPolicyController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<CustomUser> _userManager;
        public HealthPolicyController(ApplicationDbContext context, UserManager<CustomUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {

            ViewData["Title"] = "Health";

            var HealthPolicyVM = new policyViewModel
            {
                Customers = _context.Customers.ToList(),
                Policies = _context.Policies.ToList(),
                HealthDetails = _context.Healths.ToList(),
                Payments = _context.Payments.ToList()
            };

            ViewBag.Message = HealthPolicyVM;

            return View();
        }
        public IActionResult Warning()
        {
            return View();
        }
    }
}
