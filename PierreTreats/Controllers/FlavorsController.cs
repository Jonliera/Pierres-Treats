// using Microsoft.AspNetCore.Mvc;
// using PierreTreats.Models;
// using System.Collections.Generic;
// using Microsoft.AspNetCore.Identity;
// using System.Threading.Tasks;
// using System.Security.Claims;
// using System.Linq;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc.Rendering;

// namespace PierreTreats.Controllers
// {
//   [Authorize]
//   public class FlavorsController : Controller
//   {
//     private readonly PierreTreatsContext _db;
//     private readonly UserManager<ApplicationUser> _userManager;

//     public FlavorsController(UserManager<ApplicationUser> userManager, PierreTreatsContext db)
//     {
//       _userManager = userManager;
//       _db = db;
//     }
//     public async Task<ActionResult> Index()
//     {
//       string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//       ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
//       List<Flavor> userFlavors = _db.Flavors.Where(entry => entry.User.Id == currentUser.Id).ToList();
//       return View(userFlavors);
//     }
//     public ActionResult Create()
//     {
//       return View();
//     }
//     [HttpPost]
//     public async Task<ActionResult> Create(Flavor flavor)
//     {
//       if (ModelState.IsValid)
//       {
//         return View(flavor);
//       }
//       else
//       {
//         string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//         ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
//         flavor.User = currentUser;
//         _db.Flavors.Add(flavor);
//         _db.SaveChanges();
//         return RedirectToAction("Index");
//       }
//     }
//     public ActionResult Details(int id)
//     {
//       Flavor thisFlavor = _db.Flavors
//         .Include(flavor => flavor.JoinEntities)
//         .ThenInclude(join => join.Treat)
//         .FirstOrDefault(flavor => flavor.FlavorId == id);
//       return View(thisFlavor);
//     }
//     public ActionResult Edit(int id)
//     {
//       Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
//       return View(thisFlavor);
//     }
//     [HttpPost]
//     public ActionResult Edit(Flavor flavor)
//     {
//       _db.Flavors.Update(flavor);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }
//     public ActionResult Delete(int id)
//     {
//       Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
//       return View(thisFlavor);
//     }
//     [HttpPost, ActionName("Delete")]
//     public ActionResult DeleteConfirmed(int id)
//     {
//       Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
//       _db.Flavors.Remove(thisFlavor);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }
//     public async Task<ActionResult> AddTreat(int id)
//     {
//       string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//       ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
//       List<Treat> userTreats = _db.Treats.Where(entry => entry.User.Id == currentUser.Id)
//       .Include(flavor => flavor.JoinEntities)
//       .ToList();
      
//       Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
//       ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
//       return View(thisFlavor);
//     }
//     [HttpPost]
//     public ActionResult AddTreat(Flavor flavor, int TreatId)
//     {
//       #nullable enable
//       TreatFlavor? joinEntity = _db.TreatFlavor.FirstOrDefault(join => join.TreatId == treatId && join.FlavorId == flavor.FlavorId);
//       #nullable disable
//       if (joinEntity == null && TreatId != 0)
//       {
//         _db.TreatFlavor.Add(new TreatFlavor() { TreatId = treatId, FlavorId = flavor.FlavorId });
        
//         _db.SaveChanges();
//       }
//       return RedirectToAction("Details", new { id = flavor.FlavorId });
//     }
//     [HttpPost]
//     public ActionResult DeleteJoin(int joinId)
//     {
//       TreatFlavor joinEntry = _db.TreatFlavor.FirstOrDefault(entry => entry.TreatFlavorId == joinId);
//       _db.TreatFlavor.Remove(joinEntry);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }
//   }
// }


