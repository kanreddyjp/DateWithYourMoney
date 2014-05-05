using System.Web.Mvc;
using IncomeTaxApp.Models;

namespace IncomeTaxApp.Controllers
{
    public class IncomeTaxController : Controller
    {
      public ActionResult SaveYourTax()
      {
        ViewBag.Message = "Provide your income tax related information";

        return View();
      }

      public ActionResult Suggestions(UserInfo userData)
      {
        if (ModelState.IsValid)
        {
          return View();
        }

        return View("SaveYourTax");
      }
    }
}
