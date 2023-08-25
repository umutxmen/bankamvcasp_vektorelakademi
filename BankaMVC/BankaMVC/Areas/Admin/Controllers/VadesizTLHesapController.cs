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
using BankaMVC.Areas.Admin.Models.Dtos.VadesizTLHesapDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class VadesizTLHesapController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public VadesizTLHesapController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response = await _httpApiService.GetData<ResponseBody<List<VadesizTLHesapItem>>>("/vadesiztlhesap", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetVadesizTLHesap(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<VadesizTLHesapItem>>($"/vadesiztlhesap/{id}");

            return Json(new
            {
                VadesizTLHesapID = response.Data.VadesizTLHesapID,
                MusteriID = response.Data.MusteriID,
                HesapTutar = response.Data.HesapTutar,
                HesapAcilmaTarih = response.Data.HesapAcilmaTarih,
                HesapIBAN = response.Data.HesapIBAN
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewVadesizTLHesapDto dto)
        {
            var postObj = new
            {
                MusteriID = dto.MusteriID,
                HesapTutar = dto.HesapTutar,
                HesapAcilmaTarih = dto.HesapAcilmaTarih,
                HesapIBAN = dto.HesapIBAN
            };

            var response = await _httpApiService.PostData<ResponseBody<VadesizTLHesapItem>>("/vadesiztlhesap", JsonSerializer.Serialize(postObj));

            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutVadesizTLHesapDto dto)
        {
            var putObj = new
            {
                VadesizTLHesapID = dto.VadesizTLHesapID,
                MusteriID = dto.MusteriID,
                HesapTutar = dto.HesapTutar,
                HesapAcilmaTarih = dto.HesapAcilmaTarih,
                HesapIBAN = dto.HesapIBAN
            };

            var response = await _httpApiService.PutData<ResponseBody<VadesizTLHesapItem>>($"/vadesiztlhesap", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/vadesiztlhesap/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

