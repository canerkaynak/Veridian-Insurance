using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.EntityFrameworkCore;
using VeridianInsurance.Models;
using VeridianInsurance.Models.ViewModels;

namespace VeridianInsurance.Controllers
{
    [Authorize]
    public class HealthPaymentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private int plcyNo, pydAmount;
        public HealthPaymentController(ApplicationDbContext context, UserManager<CustomUser> userManager)
        {
            pydAmount = 0;
            _context = context;
        }
        public IActionResult Index(IFormCollection fc)
        {
            ViewData["Title"] = "Payment";


            TempData["plcyNo"] = fc["policyNo"].FirstOrDefault();
            TempData["pydAmount"] = fc["payedAmount"].FirstOrDefault();
            TempData["CustomerId"] = fc["CustomerId"].FirstOrDefault();
            TempData["IsSmoke"] = fc["isSmoke"].FirstOrDefault();
            TempData["IsHadOperation"] = fc["isHadOperation"].FirstOrDefault();
            TempData["Price"] = fc["payedAmount"].FirstOrDefault();

            ViewBag.payedAmount = fc["payedAmount"].FirstOrDefault();

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewPayment(IFormCollection fc)
        {
            ViewData["Title"] = "Payment";

            DateTime paymentDate = DateTime.Now;
            string cardHolder = fc["cardHolder"];

            Payment newPayment = new Payment
            {
                PolicyNo = TempData.ContainsKey("plcyNo") ? Convert.ToInt32(TempData["plcyNo"]) : 0,
                PayedAmount = TempData.ContainsKey("pydAmount") ? Convert.ToDouble(TempData["pydAmount"]) : 0,
                PaymentDate = paymentDate,
                CardHolder = fc["cardHolder"]
            };

            _context.Payments.Add(newPayment);
            _context.SaveChanges();

            var policy = await _context.Policies.FindAsync(newPayment.PolicyNo);

            if (policy != null)
            {
                policy.Status = 'P';
                _context.Policies.Update(policy);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("NewHealthPolicy2", "HealthPolicyPDF", new { PData = TempData["policyData"] });
        }
    }
}
