// using Microsoft.AspNetCore.Mvc;
// using PierreTreats.Models;
// using System.Collections.Generic;
// using Microsoft.AspNetCore.Identity;
// using System.Threading.Tasks;
// using System.Security.Claims;
// using System Linq;

// namespace PierreTreats.Controllers
// {
//   public class HomeController : Controller
//   {
//     private readonly PierreTreatsContext _db;
//     private readonly UserManager<ApplicationUser> _userManager;

//     public HomeController(UserManager<ApplicationUser> userManager, PierreTreatsContext db)
//     {
//       _userManager = userManager;
//       _db = db;
//     }

//     [HttpGet("/")]
//     public ActionResult Index()
//     {
//       return View();
//     }
   
//    public ActionResult About()
//     {
//       return View();
//     }
//   }
// }