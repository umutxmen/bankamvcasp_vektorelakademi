using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models;
using BankaMVC.Areas.Admin.Models.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Models.Dtos.MusteriDataDtos;
using BankaMVC.Areas.Admin.Models.Dtos.MusteriVarlikDtos;
using BankaMVC.Areas.Admin.Models.Dtos.EFTDtos;
using BankaMVC.Areas.Admin.Models.Dtos.SterlinSwiftDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class SterlinSwiftController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public SterlinSwiftController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response = await _httpApiService.GetData<ResponseBody<List<SterlinSwiftItem>>>("/sterlinswift", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetSterlinSwift(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<SterlinSwiftItem>>($"/sterlinswift/{id}");

            return Json(new
            {
                SterlinSwiftID = response.Data.SterlinSwiftID,
                MusteriID = response.Data.MusteriID,
                GidenHesapIban = response.Data.GidenHesapIban,
                AlanHesapIban = response.Data.AlanHesapIban,
                SwiftTarihi = response.Data.SwiftTarihi,
                Miktar = response.Data.Miktar,
                SwiftKodu = response.Data.SwiftKodu,
                Aciklama = response.Data.Aciklama
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewSterlinSwiftDto dto)
        {
            var postObj = new
            {
                MusteriID = dto.MusteriID,
                GidenHesapIban = dto.GidenHesapIban,
                AlanHesapIban = dto.AlanHesapIban,
                SwiftTarihi = dto.SwiftTarihi,
                Miktar = dto.Miktar,
                SwiftKodu = dto.SwiftKodu,
                Aciklama = dto.Aciklama
            };

            var response = await _httpApiService.PostData<ResponseBody<SterlinSwiftItem>>("/sterlinswift", JsonSerializer.Serialize(postObj));

            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutSterlinSwiftDto dto)
        {
            var putObj = new
            {
                SterlinSwiftID = dto.SterlinSwiftID,
                MusteriID = dto.MusteriID,
                GidenHesapIban = dto.GidenHesapIban,
                AlanHesapIban = dto.AlanHesapIban,
                SwiftTarihi = dto.SwiftTarihi,
                Miktar = dto.Miktar,
                SwiftKodu = dto.SwiftKodu,
                Aciklama = dto.Aciklama
            };

            var response = await _httpApiService.PutData<ResponseBody<SterlinSwiftItem>>($"/sterlinswift", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/sterlinswift/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

