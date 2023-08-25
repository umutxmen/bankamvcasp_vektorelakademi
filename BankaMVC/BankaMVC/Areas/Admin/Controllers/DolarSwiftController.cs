using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BankaMVC.Areas.Admin.Models.Dtos.BankaKartiDtos;
using BankaMVC.Areas.Admin.Models.Dtos.DolarSwiftDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class DolarSwiftController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public DolarSwiftController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response =
              await _httpApiService.GetData<ResponseBody<List<DolarSwiftItem>>>("/dolarswift", token.Token);

            return View(response.Data);
        }


        [HttpPost]
        public async Task<IActionResult> Getdolarswift(int id)
        {
            var response =
              await _httpApiService.GetData<ResponseBody<DolarSwiftItem>>($"/dolarswift/{id}");

            return Json(new
            {
                DolarSwiftID = response.Data.DolarSwiftID,
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
        public async Task<IActionResult> Save(NewDolarSwiftDto dto)
        {

            var postObj = new
            {
                MusteriID = dto.MusteriID,
                GidenHesapIban = dto.GidenHesapIban,
                AlanHesapIban = dto.AlanHesapIban,
                SwiftTarihi = dto.SwiftTarihi,
                Miktar = dto.Miktar,
                SwiftKodu = dto.SwiftKodu,
                Aciklama = dto.Aciklama,
            };

            var response = await _httpApiService.PostData<ResponseBody<DolarSwiftItem>>("/dolarswift", JsonSerializer.Serialize(postObj));

            return View(response.Data);



        }

        [HttpPut]
        public async Task<IActionResult> Update(PutDolarSwiftDto dto)
        {
            var putObj = new
            {
                DolarSwiftID = dto.DolarSwiftID,
                MusteriID = dto.MusteriID,
                GidenHesapIban = dto.GidenHesapIban,
                AlanHesapIban = dto.AlanHesapIban,
                SwiftTarihi = dto.SwiftTarihi,
                Miktar = dto.Miktar,
                SwiftKodu = dto.SwiftKodu,
                Aciklama = dto.Aciklama,
            };

            var response = await _httpApiService.PutData<ResponseBody<DolarSwiftItem>>($"/dolarswift", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/dolarswift/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

