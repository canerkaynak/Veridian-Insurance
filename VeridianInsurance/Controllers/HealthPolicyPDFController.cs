using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeridianInsurance.Models;
using VeridianInsurance.Models.ViewModels;

namespace VeridianInsurance.Controllers
{
    [Authorize]
    public class HealthPolicyPDFController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<CustomUser> _userManager;
        public HealthPolicyPDFController(ApplicationDbContext context, UserManager<CustomUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewHealthPolicy(IFormCollection fc)
        {
            ViewData["Title"] = "Summary";

            double smokeC = fc["smokingStatus"] == "Y" ? 1.5 : 0.5;
            double operationC = fc["operationStatus"] == "Y" ? 1.5 : 0.5;
            double price = 10000 * smokeC * operationC;

            Policy newHealthPolicy = new Policy
            {
                CustomerID = Convert.ToInt16(fc["CustomerId"]),
                Status = 'T',
                BranchCode = "610",
                PriceOfThePolicy = Convert.ToInt32(price),
                ApprovedBy = _userManager.GetUserName(HttpContext.User),
                DateOfIssue = DateTime.Now,

            };

            _context.Policies.Add(newHealthPolicy);
            _context.SaveChanges();

            Health health = new Health
            {
                PolicyNo = newHealthPolicy.PolicyNo,
                IsSmoke = Convert.ToChar(fc["smokingStatus"]),
                IsHadOperation = Convert.ToChar(fc["operationStatus"])
            };

            _context.Healths.Add(health);
            _context.SaveChanges();

            Dictionary<string, string> PData = new Dictionary<string, string>
            {
                {"Customer Id", fc["CustomerId"]},
                {"Policy No", Convert.ToString(newHealthPolicy.PolicyNo)},
                {"Is Smoke", fc["smokingStatus"]},
                {"Is Had Operation", fc["operationStatus"]},
                {"Price", Convert.ToString(price)}
            };

            var PolicyVM = new policyViewModel
            {
                Policy = newHealthPolicy,
                Health = health,
                Payments = _context.Payments.ToList(),
                PolicyData = PData
            };

            ViewBag.Message = PolicyVM;

            return View();
        }
        public async Task<IActionResult> NewHealthPolicy2()
        {
            ViewData["Title"] = "Summary";

            var policyData = new Dictionary<string, string>
            {
                {"Customer Id", TempData["CustomerId"]?.ToString() ?? ""},
                {"Policy No", TempData["plcyNo"]?.ToString() ?? ""},
                {"Is Smoke", TempData["IsSmoke"]?.ToString() ?? ""},
                {"Is Had Operation", TempData["IsHadOperation"]?.ToString() ?? ""},
                {"Price", TempData["Price"]?.ToString() ?? ""}
            };

            var PolicyVM = new policyViewModel
            {
                PolicyData = policyData
            };

            ViewBag.Message = PolicyVM;

            return View();
        }
    }
}
