using BankaMVC.Areas.Admin.Filters;
using Microsoft.AspNetCore.Mvc;

namespace AhlatciProject.MvcUI.Areas.Admin.Controllers
{
  [Area("Admin")]
  [SessionAspect]
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
        public IActionResult AdminGiris()
        {
            // Admin girişiyle ilgili işlemleri burada yapabilirsiniz.
            Console.WriteLine("Admin Giriş metodu çalıştı.");
            return RedirectToAction("Index"); // Örneğin, ana sayfaya yönlendirme.
        }

        public IActionResult KullaniciGiris()
        {
            // Kullanıcı girişiyle ilgili işlemleri burada yapabilirsiniz.
            Console.WriteLine("Kullanıcı Giriş metodu çalıştı.");
            return RedirectToAction("Index"); // Örneğin, ana sayfaya yönlendirme.
        }
    }
}
