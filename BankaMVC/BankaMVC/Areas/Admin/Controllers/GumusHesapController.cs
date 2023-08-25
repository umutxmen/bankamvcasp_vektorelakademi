using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models.Dtos.DovizDtos;
using BankaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BankaMVC.Areas.Admin.Models.Dtos.EFTDtos;
using BankaMVC.Areas.Admin.Models.Dtos.EuroHesapDtos;
using BankaMVC.Areas.Admin.Models.Dtos.GümüsHesapDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class GumusHesapController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public GumusHesapController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response = await _httpApiService.GetData<ResponseBody<List<GumusHesapItem>>>("/gümüshesap", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetGumusHesap(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<GumusHesapItem>>($"/gümüshesap/{id}");

            return Json(new
            {
                GümüsHesapID = response.Data.GümüsHesapID,
                MusteriID = response.Data.MusteriID,
                GümüsVarlikGram = response.Data.GümüsVarlikGram,
                HesapTarih = response.Data.HesapTarih
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewGumusHesapDto dto)
        {
            var postObj = new
            {
                MusteriID = dto.MusteriID,
                GümüsVarlikGram = dto.GümüsVarlikGram,
                HesapTarih = dto.HesapTarih
            };

            var response = await _httpApiService.PostData<ResponseBody<GumusHesapItem>>("/gümüshesap", JsonSerializer.Serialize(postObj));

            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutGumusHesapDto dto)
        {
            var putObj = new
            {
                GümüsHesapID = dto.GümüsHesapID,
                MusteriID = dto.MusteriID,
                GümüsVarlikGram = dto.GümüsVarlikGram,
                HesapTarih = dto.HesapTarih
            };

            var response = await _httpApiService.PutData<ResponseBody<GumusHesapItem>>($"/gümüshesap", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/gümüshesap/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

