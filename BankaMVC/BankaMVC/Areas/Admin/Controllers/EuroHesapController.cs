using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models.Dtos.DovizDtos;
using BankaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BankaMVC.Areas.Admin.Models.Dtos.EFTDtos;
using BankaMVC.Areas.Admin.Models.Dtos.EuroHesapDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class EuroHesapController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public EuroHesapController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response =
              await _httpApiService.GetData<ResponseBody<List<EuroHesapItem>>>("/eurohesap", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetEuroHesap(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<EuroHesapItem>>($"/eurohesap/{id}");

            return Json(new
            {
                EuroHesapID = response.Data.EuroHesapID,
                MusteriID = response.Data.MusteriID,
                EuroVarlik = response.Data.EuroVarlik,
                HesapTarih = response.Data.HesapTarih,
                HesapIban = response.Data.HesapIban
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewEuroHesapDto dto)
        {
            var postObj = new
            {
                MusteriID = dto.MusteriID,
                EuroVarlik = dto.EuroVarlik,
                HesapTarih = dto.HesapTarih,
                HesapIban = dto.HesapIban
            };

            var response = await _httpApiService.PostData<ResponseBody<EuroHesapItem>>("/eurohesap", JsonSerializer.Serialize(postObj));

            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutEuroHesapDto dto)
        {
            var putObj = new
            {
                EuroHesapID = dto.EuroHesapID,
                MusteriID = dto.MusteriID,
                EuroVarlik = dto.EuroVarlik,
                HesapTarih = dto.HesapTarih,
                HesapIban = dto.HesapIban
            };

            var response = await _httpApiService.PutData<ResponseBody<EuroHesapItem>>($"/eurohesap", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/eurohesap/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

