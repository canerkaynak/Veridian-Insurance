using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VeridianInsurance.Models.ViewModels;
using VeridianInsurance.Models;
using Microsoft.AspNetCore.Authorization;

namespace VeridianInsurance.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<CustomUser> _userManager;
        private readonly PolicyReportService _reportService;
        public AdminController(ApplicationDbContext context, UserManager<CustomUser> userManager, PolicyReportService reportService)
        {
            _context = context;
            _userManager = userManager;
            _reportService = reportService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Admin";

            var topOfferConsultant = await _reportService.GetTopOfferConsultantAsync();
            var topPolicyConsultant = await _reportService.GetTopPolicyConsultantAsync();
            var allConsultants = await _reportService.GetAllConsultantWithPoliciesAsync();

            var model = new ReportViewModel
            {
                TopOfferConsultant = topOfferConsultant,
                TopPolicyConsultant = topPolicyConsultant,
                AllConsultants = allConsultants
            };

            ViewBag.Message = model;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> passivateConsultant(string Username)
        {
            var user = await _userManager.FindByNameAsync(Username);

            if (user != null)
            {
                user.Type = 'P';

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Error");
                }
            }
            else
            {
                ModelState.AddModelError("", "User did not find!");
            }

            return RedirectToAction("Index", "Admin");
        }
    }
}
