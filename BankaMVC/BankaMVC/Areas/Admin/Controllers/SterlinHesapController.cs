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
using BankaMVC.Areas.Admin.Models.Dtos.SterlinHesapDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class SterlinHesapController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public SterlinHesapController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response = await _httpApiService.GetData<ResponseBody<List<SterlinHesapItem>>>("/sterlinhesap", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetSterlinHesap(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<SterlinHesapItem>>($"/sterlinhesap/{id}");

            return Json(new
            {
                SterlinHesapId = response.Data.SterlinHesapId,
                MusteriID = response.Data.MusteriID,
                SterlinVarlik = response.Data.SterlinVarlik,
                HesapTarih = response.Data.HesapTarih,
                HesapIban = response.Data.HesapIban
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewSterlinHesapDto dto)
        {
            var postObj = new
            {
                MusteriID = dto.MusteriID,
                SterlinVarlik = dto.SterlinVarlik,
                HesapTarih = dto.HesapTarih,
                HesapIban = dto.HesapIban
            };

            var response = await _httpApiService.PostData<ResponseBody<SterlinHesapItem>>("/sterlinhesap", JsonSerializer.Serialize(postObj));

            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutSterlinHesapDto dto)
        {
            var putObj = new
            {
                SterlinHesapId = dto.SterlinHesapId,
                MusteriID = dto.MusteriID,
                SterlinVarlik = dto.SterlinVarlik,
                HesapTarih = dto.HesapTarih,
                HesapIban = dto.HesapIban
            };

            var response = await _httpApiService.PutData<ResponseBody<SterlinHesapItem>>($"/sterlinhesap", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/sterlinhesap/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

