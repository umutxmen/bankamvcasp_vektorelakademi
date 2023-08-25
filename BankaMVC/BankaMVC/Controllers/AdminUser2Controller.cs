using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Models;
using BankaMVC.Models.Dtos;
using BankaMVC.Models;
using BankaMVC.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using BankaMVC.Areas.Admin.Models.Dtos;

namespace BankaMVC.Controllers
{
    public class AdminUser2Controller : Controller
    {
        private readonly IHttpApiService _httpApiService;
        public AdminUser2Controller(IHttpApiService httpApiService)
        {
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LogInDto2 dto)
        {
            var response =
              await _httpApiService.GetData<ResponseBody2<AdminUserItem2>>($"/Authentication/logIn?userName={dto.UserName}&password={dto.Password}");

            if (response.ErrorMessages == null || response.ErrorMessages.Count == 0)
            {
                HttpContext.Session.SetObject("ActiveAdminUser", response.Data);

                await GetTokenAndSetInSession();

                return Json(new { IsSuccess = true, Messages = "Kullanıcı Bulundu" });
            }
            else
            {
                return Json(new { IsSuccess = false, Messages = response.ErrorMessages });
            }

        }
        [HttpPost]
        public async Task<IActionResult> GetMusteriBilgi(int id)
        {
            var response =
              await _httpApiService.GetData<ResponseBody2<AdminUserItem2>>($"/Authentication/{id}");

            return Json(new
            {
                Id = response.Data.Id,
                FullName = response.Data.FullName,
                Email = response.Data.Email
             

            });
        }
        public async Task GetTokenAndSetInSession()
        {
            var response = await _httpApiService.GetData<ResponseBody2<AccessTokenItem2>>(@"/authentication/gettoken");

            HttpContext.Session.SetObject("AccessToken", response.Data);
        }
    }
}
