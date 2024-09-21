using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeridianInsurance.Models;
using VeridianInsurance.Models.ViewModels;

namespace VeridianInsurance.Controllers
{
    [Authorize]
    public class VehiclePolicyPDFController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<CustomUser> _userManager;
        public VehiclePolicyPDFController(ApplicationDbContext context, UserManager<CustomUser> userManager)
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
        public async Task<IActionResult> NewVehiclePolicy(IFormCollection fc)
        {
            ViewData["Title"] = "Summary";

            int price;

            var vehicleInfo = await _context.VehicleInformation.FirstOrDefaultAsync(v => v.BrandCode == Convert.ToString(fc["brand"]) && v.TypeCode == Convert.ToString(fc["model"]));

            if (vehicleInfo == null)
            {
                return NotFound("Vehicle not found");
            }

            var vValueTable = await _context.VehicleInsuranceValues.FirstOrDefaultAsync(v => v.VehicleID == vehicleInfo.VehicleID && v.Year == Convert.ToString(fc["modelYear"]));
            price = Convert.ToInt32(Convert.ToInt32(vValueTable.Value) * 0.11);

            Policy newVPolicy = new Policy
            {
                CustomerID = Convert.ToInt16(fc["CustomerId"]),
                Status = 'T',
                BranchCode = "340",
                PriceOfThePolicy = Convert.ToInt32(price),
                ApprovedBy = _userManager.GetUserName(HttpContext.User),
                DateOfIssue = DateTime.Now,

            };

            _context.Policies.Add(newVPolicy);
            _context.SaveChanges();

            Vehicle vehicle = new Vehicle
            {
                PolicyNo = newVPolicy.PolicyNo,
                PlateCityCode = fc["plateCityCode"],
                PlateCode = fc["plateCode"],
                Brand = fc["brand"],
                Model = fc["model"],
                ModelYear = Convert.ToInt32(fc["modelYear"]),
                ChassisSerialNumber = fc["chassisNumber"]
            };

            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();

            Dictionary<string, string> PData = new Dictionary<string, string>
            {

                {"Customer Id", fc["CustomerId"]},
                {"Policy No", Convert.ToString(newVPolicy.PolicyNo)},
                {"Chassis Number", fc["chassisNumber"]},
                {"Plate City Code", fc["plateCityCode"]},
                {"Plate Code", fc["plateCode"]},
                {"Brand Code", fc["brand"]},
                {"Model Code", fc["model"]},
                {"Model Year", fc["modelYear"]},
                {"Price", Convert.ToString(price)}
            };

            var PolicyVM = new policyViewModel
            {
                Policy = newVPolicy,
                Vehicle = vehicle,
                Payments = _context.Payments.ToList(),
                PolicyData = PData
            };

            ViewBag.Message = PolicyVM;

            return View();
        }
        public async Task<IActionResult> NewVehiclePolicy2()
        {
            ViewData["Title"] = "Summary";

            var policyData = new Dictionary<string, string>
            {
                {"Customer Id", TempData["CustomerId"]?.ToString() ?? ""},
                {"Policy No", TempData["plcyNo"]?.ToString() ?? ""},
                {"Chassis Number", TempData["ChassisNumber"]?.ToString() ?? ""},
                {"Plate City Code", TempData["PlateCityCode"]?.ToString() ?? ""},
                {"Plate Code", TempData["PlateCode"]?.ToString() ?? ""},
                {"Brand Code", TempData["Brand"]?.ToString() ?? ""},
                {"Model Code", TempData["Model"]?.ToString() ?? ""},
                {"Model Year", TempData["ModelYear"]?.ToString() ?? ""},
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
