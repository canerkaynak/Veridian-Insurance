using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeridianInsurance.Models;
using VeridianInsurance.Models.ViewModels;

namespace VeridianInsurance.Controllers
{
    [Authorize]
    public class NDPolicyPDFController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<CustomUser> _userManager;
        public NDPolicyPDFController(ApplicationDbContext context, UserManager<CustomUser> userManager)
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
        public async Task<IActionResult> NewNDPolicy(IFormCollection fc)
        {
            ViewData["Title"] = "Summary";

            double areaC = 1, ageC = 1, typeC = 1, floorC = 1, price = 10000;

            if (Convert.ToInt32(fc["area"]) < 500)
            {
                areaC = 1.2;
            }
            else if (Convert.ToInt32(fc["area"]) < 1500)
            {
                areaC = 1.6;
            }
            else
            {
                areaC = 2;
            }

            if (Convert.ToInt32(fc["buildingAge"]) <= 5)
            {
                ageC = 0.8;
            }
            else if (Convert.ToInt32(fc["buildingAge"]) <= 10)
            {
                ageC = 1.2;
            }
            else if (Convert.ToInt32(fc["buildingAge"]) <= 20)
            {
                ageC = 1.5;
            }
            else if (Convert.ToInt32(fc["buildingAge"]) <= 30)
            {
                ageC = 1.8;
            }
            else
            {
                ageC = 2.5;
            }

            if (String.Equals(fc["buildingType"], "residence"))
            {
                typeC = 1.2;
            }
            else if (String.Equals(fc["buildingType"], "office"))
            {
                typeC = 2;
            }
            else if (String.Equals(fc["buildingType"], "other"))
            {
                typeC = 1.6;
            }

            if (Convert.ToInt32(fc["floor"]) < 5)
            {
                floorC = 0.8;
            }
            else if (Convert.ToInt32(fc["floor"]) < 10)
            {
                floorC = 1;
            }
            else if (Convert.ToInt32(fc["floor"]) < 15)
            {
                floorC = 1.3;
            }
            else if (Convert.ToInt32(fc["floor"]) < 20)
            {
                floorC = 1.6;
            }
            else if (Convert.ToInt32(fc["floor"]) < 30)
            {
                floorC = 2;
            }
            else
            {
                floorC = 3;
            }

            price = 10000 * areaC * ageC * floorC * typeC;

            Policy newNDPolicy = new Policy
            {
                CustomerID = Convert.ToInt16(fc["CustomerId"]),
                Status = 'T',
                BranchCode = "199",
                PriceOfThePolicy = Convert.ToInt32(price),
                ApprovedBy = _userManager.GetUserName(HttpContext.User),
                DateOfIssue = DateTime.Now,

            };

            _context.Policies.Add(newNDPolicy);
            _context.SaveChanges();

            NaturalDisasters nd = new NaturalDisasters
            {
                PolicyNo = newNDPolicy.PolicyNo,
                Uavt = fc["uavt"],
                Area = Convert.ToInt32(fc["area"]),
                Type = fc["buildingType"],
                BuildingAge = Convert.ToInt32(fc["buildingAge"]),
                Floor = Convert.ToInt32(fc["floor"])
            };

            _context.NaturalDisasters.Add(nd);
            _context.SaveChanges();

            Dictionary<string, string> PData = new Dictionary<string, string>
            {
                {"Customer Id", fc["CustomerId"]},
                {"Policy No", Convert.ToString(newNDPolicy.PolicyNo)},
                {"UAVT", fc["uavt"]},
                {"Area", fc["area"]},
                {"Type", fc["buildingType"]},
                {"Building Age", fc["buildingAge"]},
                {"Floor", fc["floor"]},
                {"Price", Convert.ToString(price)}
            };

            var PolicyVM = new policyViewModel
            {
                Policy = newNDPolicy,
                ND = nd,
                Payments = _context.Payments.ToList(),
                PolicyData = PData
            };

            ViewBag.Message = PolicyVM;

            return View();
        }
        public async Task<IActionResult> NewNDPolicy2()
        {
            ViewData["Title"] = "Summary";

            var policyData = new Dictionary<string, string>
            {
                {"Customer Id", TempData["CustomerId"]?.ToString() ?? ""},
                {"Policy No", TempData["plcyNo"]?.ToString() ?? ""},
                {"UAVT", TempData["UAVT"]?.ToString() ?? ""},
                {"Area", TempData["Area"]?.ToString() ?? ""},
                {"Type", TempData["Type"]?.ToString() ?? ""},
                {"Building Age", TempData["Building Age"]?.ToString() ?? ""},
                {"Floor", TempData["Floor"]?.ToString() ?? ""},
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
