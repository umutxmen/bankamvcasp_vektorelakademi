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
    public class BankaKartiController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public BankaKartiController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response =
              await _httpApiService.GetData<ResponseBody<List<BankaKartiItem>>>("/bankakartı", token.Token);

            return View(response.Data);
        }


        [HttpPost]
        public async Task<IActionResult> Getbankakarti(int id)
        {
            var response =
              await _httpApiService.GetData<ResponseBody<BankaKartiItem>>($"/bankakartı/{id}");

            return Json(new
            {

                BankaKartID = response.Data.BankaKartID,
                MusteriID = response.Data.MusteriID,
                Baglıİban = response.Data.Baglıİban,
                KartNo = response.Data.KartNo,
                KartSonKullanımAy = response.Data.KartSonKullanımAy,
                KartSonKullanımYıl = response.Data.KartSonKullanımYıl,
                KartSahipAd = response.Data.KartSahipAd,
                KartSahipSoyad = response.Data.KartSahipSoyad,
                KartTeknolojisi = response.Data.KartTeknolojisi

            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewBankaKartiDto dto)
        {

            var postObj = new
            {
                MusteriID = dto.MusteriID,
                Baglıİban = dto.Baglıİban,
                KartNo = dto.KartNo,
                KartSonKullanımAy = dto.KartSonKullanımAy,
                KartSonKullanımYıl = dto.KartSonKullanımYıl,
                KartSahipAd = dto.KartSahipAd,
                KartSahipSoyad = dto.KartSahipSoyad,
                KartTeknolojisi = dto.KartTeknolojisi
            };

            var response = await _httpApiService.PostData<ResponseBody<BankaKartiItem>>("/bankakartı", JsonSerializer.Serialize(postObj));

            return View(response.Data);



        }

        [HttpPut]
        public async Task<IActionResult> Update(PutBankaKartiDto dto)
        {
            var putObj = new
            {
                BankaKartID = dto.BankaKartID,
                MusteriID = dto.MusteriID,
                Baglıİban = dto.Baglıİban,
                KartNo = dto.KartNo,
                KartSonKullanımAy = dto.KartSonKullanımAy,
                KartSonKullanımYıl = dto.KartSonKullanımYıl,
                KartSahipAd = dto.KartSahipAd,
                KartSahipSoyad = dto.KartSahipSoyad,
                KartTeknolojisi = dto.KartTeknolojisi,
            
            };

            var response = await _httpApiService.PutData<ResponseBody<BankaKartiItem>>($"/bankakartı", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/bankakartı/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

