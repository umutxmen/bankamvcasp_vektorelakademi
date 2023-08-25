using Microsoft.AspNetCore.Mvc;
using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.Models;
using BankaMVC.Areas.Admin;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models.Dtos.User;
using System.Text.Json;
using BankaMVC.Areas.Admin.Extensions;

namespace MovieApp.MvcWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [SessionAspect]
    public class UserController : Controller
    {
        private readonly IHttpApiService _httpApiService;
        public UserController(IHttpApiService httpApiService)
        {
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _httpApiService.GetData<ResponseBody<List<UserItem>>>("/Users");
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewUserDto dto)
        {
            var postObj = new
            {
                Nickname = dto.Nickname,
                Firstname = dto.Firstname,
                Lastname = dto.Lastname,
                Email = dto.Email,
                Password = dto.Password
            };
            var response = await _httpApiService.PostData<ResponseBody<UserItem>>("/users",
                JsonSerializer.Serialize(postObj));

            if (response.StatusCode == 201)
            {
                return Json(new
                {
                    IsSuccess = true,
                    Message = "Kullanıcı başarıyla eklendi.",
                    Nickname = response.Data.Nickname,
                    FullName = response.Data.FullName,
                    Email = response.Data.Email
                });
            }
            else
            {
                return Json(new
                {
                    IsSuccess = false,
                    Message = response.ErrorMessages
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoContent>>($"/Users/{id}");
            if (response.StatusCode == 200)
            {
                return Json(new { IsSuccess = true, Message = "Kullanıcı başarıyla silindi." });
            }
            else
            {
                return Json(new { IsSuccess = false, Message = "Kayıt silinemedi.", ErrorMessages = response.ErrorMessages });
            }
        }
    }
}
