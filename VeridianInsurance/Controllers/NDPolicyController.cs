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
    public class NDPolicyController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<CustomUser> _userManager;
        public NDPolicyController(ApplicationDbContext context, UserManager<CustomUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {

            ViewData["Title"] = "ND";

            var NDPolicyVM = new policyViewModel
            {
                Customers = _context.Customers.ToList(),
                Policies = _context.Policies.ToList(),
                NDDetails = _context.NaturalDisasters.ToList(),
                Payments = _context.Payments.ToList()
            };

            ViewBag.Message = NDPolicyVM;

            return View();
        }
    }
}
