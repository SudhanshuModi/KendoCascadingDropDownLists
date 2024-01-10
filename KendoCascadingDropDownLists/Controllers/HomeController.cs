using KendoCascadingDropDownLists.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KendoCascadingDropDownLists.Controllers
{
    public class HomeController : Controller
    {
        private readonly CompanyDBContext CompanyDB;

        public HomeController(CompanyDBContext CompanyDB)
        {
            this.CompanyDB = CompanyDB;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CompanyDetails()
        {
            var companyData = CompanyDB.Companies.ToList();
            return Json(companyData);
        }

        public IActionResult BranchDetails()
        {
            var branchData = CompanyDB.Branches.ToList();
            return Json(branchData);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}