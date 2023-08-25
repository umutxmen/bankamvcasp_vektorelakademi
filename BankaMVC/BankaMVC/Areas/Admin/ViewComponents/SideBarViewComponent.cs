using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace AhlatciProject.MvcUI.Areas.Admin.ViewComponents
{
  public class SideBarViewComponent:ViewComponent
  {
    public ViewViewComponentResult Invoke()
    {
      var adminUser = HttpContext.Session.GetObject<AdminUserItem>("ActiveAdminUser");

      return View(adminUser);
    }
  }
}
