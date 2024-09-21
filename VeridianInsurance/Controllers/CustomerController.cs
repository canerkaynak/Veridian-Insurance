using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeridianInsurance.Models;
using VeridianInsurance.Models.ViewModels;

namespace VeridianInsurance.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<CustomUser> _userManager;
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Customers";

            var PolicyVM = new policyViewModel
            {
                Customers = _context.Customers.Where(c => c.Type == 'A').ToList(),
                Policies = _context.Policies.ToList()
            };

            ViewBag.Message = PolicyVM;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> passivateCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer != null)
            {
                customer.Type = 'P';
                _context.Customers.Update(customer);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> NewCustomer(IFormCollection fc)
        {
            Customer newCustomer = new Customer
            {
                TCNo = fc["TCNo"],
                Name = fc["name"],
                Surname = fc["surname"],
                DateOfBirth = Convert.ToDateTime(fc["dateOfBirth"]),
                PhoneNumber = fc["phoneNumber"],
                Email = fc["email"],
                City = fc["city"],
                Type = 'A'
            };

            _context.Customers.Add(newCustomer);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
