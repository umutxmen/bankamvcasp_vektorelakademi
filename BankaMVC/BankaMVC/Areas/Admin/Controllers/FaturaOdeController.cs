using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models.Dtos.DovizDtos;
using BankaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BankaMVC.Areas.Admin.Models.Dtos.EFTDtos;
using BankaMVC.Areas.Admin.Models.Dtos.EuroHesapDtos;
using BankaMVC.Areas.Admin.Models.Dtos.FaturaÖdeDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class FaturaOdeController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public FaturaOdeController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response = await _httpApiService.GetData<ResponseBody<List<FaturaOdeItem>>>("/faturaode", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetFaturaOde(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<FaturaOdeItem>>($"/faturaode/{id}");

            return Json(new
            {
                FaturaYatırİslemID = response.Data.FaturaYatırİslemID,
                MusteriID = response.Data.MusteriID,
                faturano = response.Data.faturano,
                Gonderenİban = response.Data.Gonderenİban,
                odenecekMiktar = response.Data.odenecekMiktar,
                OdemeTarih = response.Data.OdemeTarih,
                Aciklama = response.Data.Aciklama
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewFaturaOdeDto dto)
        {
            var postObj = new
            {
                MusteriID = dto.MusteriID,
                faturano = dto.faturano,
                Gonderenİban = dto.Gonderenİban,
                odenecekMiktar = dto.odenecekMiktar,
                OdemeTarih = dto.OdemeTarih,
                Aciklama = dto.Aciklama
            };

            var response = await _httpApiService.PostData<ResponseBody<FaturaOdeItem>>("/faturaode", JsonSerializer.Serialize(postObj));

            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutFaturaOdeDto dto)
        {
            var putObj = new
            {
                FaturaYatırİslemID = dto.FaturaYatırİslemID,
                MusteriID = dto.MusteriID,
                faturano = dto.faturano,
                Gonderenİban = dto.Gonderenİban,
                odenecekMiktar = dto.odenecekMiktar,
                OdemeTarih = dto.OdemeTarih,
                Aciklama = dto.Aciklama
            };

            var response = await _httpApiService.PutData<ResponseBody<FaturaOdeItem>>($"/faturaode", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/faturaode/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

