using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using VeridianInsurance.Models;
using VeridianInsurance.Models.ViewModels;

namespace VeridianInsurance.Controllers
{
    [Authorize]
    public class VehiclePolicyController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<CustomUser> _userManager;
        public VehiclePolicyController(ApplicationDbContext context, UserManager<CustomUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {

            ViewData["Title"] = "Vehicle";

            var VehiclePolicyVM = new policyViewModel
            {
                Customers = _context.Customers.ToList(),
                Policies = _context.Policies.ToList(),
                VehicleDetails = _context.Vehicles.ToList(),
                VehicleInformation = _context.VehicleInformation.ToList(),
                VehicleValue = _context.VehicleInsuranceValues.ToList(),
                Payments = _context.Payments.ToList()
            };

            ViewBag.Message = VehiclePolicyVM;

            return View();
        }
    }
}
