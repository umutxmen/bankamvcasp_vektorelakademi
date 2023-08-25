using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BankaMVC.Areas.Admin.Models.Dtos.BankaKartiDtos;
using BankaMVC.Areas.Admin.Models.Dtos.DolarHesap;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class DolarHesapController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public DolarHesapController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response =
              await _httpApiService.GetData<ResponseBody<List<DolarHesapItem>>>("/dolarhesap", token.Token);

            return View(response.Data);
        }


        [HttpPost]
        public async Task<IActionResult> Getdolarhesap(int id)
        {
            var response =
              await _httpApiService.GetData<ResponseBody<DolarHesapItem>>($"/dolarhesap/{id}");

            return Json(new
            {
               
                DolarHesapID = response.Data.DolarHesapID,
                MusteriID = response.Data.MusteriID,
                DolarVarlik = response.Data.DolarVarlik,
                HesapTarihi = response.Data.HesapTarihi,
                HesapIban = response.Data.HesapIban

            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewDolarHesapDto dto)
        {

            var postObj = new
            {
                MusteriID = dto.MusteriID,
                DolarVarlik = dto.DolarVarlik,
                HesapTarihi = dto.HesapTarihi,
                HesapIban = dto.HesapIban
            };

            var response = await _httpApiService.PostData<ResponseBody<DolarHesapItem>>("/dolarhesap", JsonSerializer.Serialize(postObj));

            return View(response.Data);



        }

        [HttpPut]
        public async Task<IActionResult> Update(PutDolarHesapDto dto)
        {
            var putObj = new
            {
                DolarHesapID = dto.DolarHesapID,
                MusteriID = dto.MusteriID,
                DolarVarlik = dto.DolarVarlik,
                HesapTarihi = dto.HesapTarihi,
                HesapIban = dto.HesapIban
            };

            var response = await _httpApiService.PutData<ResponseBody<DolarHesapItem>>($"/dolarhesap", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/dolarhesap/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

