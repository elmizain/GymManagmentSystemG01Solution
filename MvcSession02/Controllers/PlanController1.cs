using GymManagmentSystemG01.Contexts;
using GymManagmentSystemG01.Repositories.Classes;
using GymManagmentSystemG01.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagmentSystemG01.Controllers
{
    public class PlanController1 : Controller
    {
        private IPlanRepository _planRepository;
        private readonly IMemberShipRepository _memberShipRepository;

        //DI
        public PlanController(IPlanRepository planRepository, IMemberShipRepository memberShipRepository)
        {
            _planRepository = planRepository;
            _membershipRepository = memberShipRepository;
        }

        public async Task<IActionResult> Index()
        {
            var Plans = await planRepository.GetAllAsync();
            //ViewData["Mahmoud"] = "Mahmoud at Route :)";
            //ViewBag.Age = 30;
            return View(Plans);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id, CancellationToken ct)
        {
            var plan = await _planRepository.GetPlanByIdAsync(id);

            if (plan is null || !plan.IsActive)
            {
                TempData["ErrorMessage"] = "This plan cant be Edited";
                return RedirectToAction(nameof(Index));
            }
            var hasCurrentMemberShipAsync = await _memberShipRepository.AnyAsync(m => m.PlanId == id && m.EndDate > DateTime.Now, ct);
            if (hasCurrentMemberShipAsync)
            {
                TempData["ErrorMessage"] = "This plan has memberShips.";
                return RedirectToAction(nameof(Index));
            }

            return view(plan);
        }
        public async Task<IActionResult> Edit([FromRoute] int id,Plan UpdatedPlan, CancellationToken ct)
        {
            if (!ModelState.IsValid) return View(UpdatedPlan);

            var plan = await _planRepository.GetPlanByIdAsync(id);

            if (plan is null || !plan.IsActive)
            {
                TempData["ErrorMessage"] = "This plan cant be Edited";
                return RedirectToAction(nameof(Index));
            }
            var hasCurrentMemberShipAsync = await _memberShipRepository.AnyAsync(m => m.PlanId == id && m.EndDate > DateTime.Now, ct);
            if (hasCurrentMemberShipAsync)
            {
                TempData["ErrorMessage"] = "This plan has memberShips.";
                return RedirectToAction(nameof(Index));
            }
            plan.DurationDays = UpdatedPlan.DurationDays;
            plan.price = UpdatedPlan.Price;
            plan.Description = UpdatedPlan.Description;

            var result = await _planRepository.UpdateAsync(ct);
            if(result == 0)
            {
                TempData["ErrorMessage"] = "Plan Failed To Update.";
                return RedirectToAction(nameof(Index));
            }
            TempData["ErrorMessage"] = "Plan updated successfully.";
            return RedirectToAction(nameof(Index));
        }


    }
} 
