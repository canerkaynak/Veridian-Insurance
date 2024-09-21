using Microsoft.AspNetCore.Identity;
using VeridianInsurance.Models.ViewModels;
using VeridianInsurance.Models;
using Microsoft.EntityFrameworkCore;

public class PolicyReportService
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<CustomUser> _userManager;

    public PolicyReportService(ApplicationDbContext context, UserManager<CustomUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public async Task<List<OFViewModel>> GetTopOfferConsultantAsync()
    {
        var topOfferConsultant = await _context.Policies
            .Where(p => p.Status == 'T')
            .GroupBy(p => p.ApprovedBy)
            .Select(g => new
            {
                UserId = g.Key,
                Health = g.Count(p => Convert.ToInt32(p.BranchCode) == 610),
                Vehicle = g.Count(p => Convert.ToInt32(p.BranchCode) == 340),
                ND = g.Count(p => Convert.ToInt32(p.BranchCode) == 199),
            })
            .OrderByDescending(g => g.Health + g.Vehicle + g.ND)
            .Take(3)
            .ToListAsync();

        var userIds = topOfferConsultant.Select(x => x.UserId).Distinct().ToList();
        var users = await _userManager.Users.Where(u => userIds.Contains(u.UserName)).ToListAsync();

        var result = topOfferConsultant.Select(x => new OFViewModel
        {
            ApprovedBy = users.FirstOrDefault(u => u.UserName == x.UserId)?.UserName ?? "N/A",
            FullName = (users.FirstOrDefault(u => u.UserName == x.UserId)?.Name ?? "N/A") + " " + (users.FirstOrDefault(u => u.UserName == x.UserId)?.Surname ?? "N/A"),
            Health = x.Health,
            Vehicle = x.Vehicle,
            ND = x.ND
        }).ToList();

        return result;
    }

    public async Task<List<OFViewModel>> GetTopPolicyConsultantAsync()
    {
        var topPolicyConsultant = await _context.Policies
            .Where(p => p.Status == 'P')
            .GroupBy(p => p.ApprovedBy)
            .Select(g => new
            {
                UserId = g.Key,
                Health = g.Count(p => Convert.ToInt32(p.BranchCode) == 610),
                Vehicle = g.Count(p => Convert.ToInt32(p.BranchCode) == 340),
                ND = g.Count(p => Convert.ToInt32(p.BranchCode) == 199),
            })
            .OrderByDescending(g => g.Health + g.Vehicle + g.ND)
            .Take(3)
            .ToListAsync();

        var userIds = topPolicyConsultant.Select(x => x.UserId).Distinct().ToList();
        var users = await _userManager.Users.Where(u => userIds.Contains(u.UserName)).ToListAsync();

        var result = topPolicyConsultant.Select(x => new OFViewModel
        {
            ApprovedBy = users.FirstOrDefault(u => u.UserName == x.UserId)?.UserName ?? "N/A",
            FullName = (users.FirstOrDefault(u => u.UserName == x.UserId)?.Name ?? "N/A") + " " + (users.FirstOrDefault(u => u.UserName == x.UserId)?.Surname ?? "N/A"),
            Health = x.Health,
            Vehicle = x.Vehicle,
            ND = x.ND
        }).ToList();

        return result;
    }

    public async Task<List<ConsultantPolicyViewModel>> GetAllConsultantWithPoliciesAsync()
    {
        var users = await _userManager.Users.ToListAsync();
        var result = new List<ConsultantPolicyViewModel>();

        foreach (var user in users)
        {
            var userId = user.Id;
            var healthPolicyCount = await _context.Policies.CountAsync(p => p.ApprovedBy == user.UserName && Convert.ToInt32(p.BranchCode) == 610 && p.Status == 'P');
            var vehiclePolicyCount = await _context.Policies.CountAsync(p => p.ApprovedBy == user.UserName && Convert.ToInt32(p.BranchCode) == 340 && p.Status == 'P');
            var ndPolicyCount = await _context.Policies.CountAsync(p => p.ApprovedBy == user.UserName && Convert.ToInt32(p.BranchCode) == 199 && p.Status == 'P');
            var totalPolicyCount = await _context.Policies.CountAsync(p => p.ApprovedBy == user.UserName && p.Status == 'P');

            result.Add(new ConsultantPolicyViewModel
            {
                UserName = user.UserName,
                Name = user.Name,
                Surname = user.Surname,
                Gender = Convert.ToInt32(user.Gender),
                DateOfBirth = user.DateOfBirth,
                Email = user.Email,
                City = user.City,
                Town = user.Town,
                Type = Convert.ToString(user.Type),
                HealthPolicy = healthPolicyCount,
                VehiclePolicy = vehiclePolicyCount,
                NDPolicy = ndPolicyCount,
                TotalPolicy = totalPolicyCount
            });
        }

        List<ConsultantPolicyViewModel> sortedResult = [.. result.OrderByDescending(i => i.TotalPolicy)];

        return sortedResult;
    }
}
