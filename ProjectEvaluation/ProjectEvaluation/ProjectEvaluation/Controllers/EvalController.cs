using Microsoft.AspNetCore.Mvc;
using ProjectEvaluation.Models;

namespace ProjectEvaluation.Controllers
{
    public class EvalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Category(string cat)
        {
            return View(new CategoryViewModel(cat));
        }

        public ActionResult English()
        {
            return RedirectToAction("Category", new {cat = "English"});
        }

        public ActionResult Math()
        {
            return RedirectToAction("Category", new { cat = "Math" });
        }
        public ActionResult FYS()
        {
            return RedirectToAction("Category", new { cat = "FYS" });
        }
        public ActionResult ProfComm()
        {
            return RedirectToAction("Category", new { cat = "ProfComm" });
        }
    }
}
