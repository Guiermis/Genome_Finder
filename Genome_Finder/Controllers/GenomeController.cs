using Genome_Finder.Models;
using Microsoft.AspNetCore.Mvc;

namespace Genome_Finder.Controllers
{
    public class GenomeController : Controller
    {
        public IActionResult Compare()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Compare(Base_Nitrogen model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
