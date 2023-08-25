using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models.Dtos.DovizDtos;
using BankaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BankaMVC.Areas.Admin.Models.Dtos.EFTDtos;
using BankaMVC.Areas.Admin.Models.Dtos.EuroHesapDtos;
using BankaMVC.Areas.Admin.Models.Dtos.KrediKartıDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class KrediKartıController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public KrediKartıController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response = await _httpApiService.GetData<ResponseBody<List<KrediKartıItem>>>("/kredikartı", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetKrediKartı(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<KrediKartıItem>>($"/kredikartı/{id}");

            return Json(new
            {
                KrediKartıID = response.Data.KrediKartıID,
                MusteriID = response.Data.MusteriID,
                Baglıİban = response.Data.Baglıİban,
                KartNo = response.Data.KartNo,
                KartkullanımAy = response.Data.KartkullanımAy,
                KartkullanımYıl = response.Data.KartkullanımYıl,
                KartCVCNo = response.Data.KartCVCNo,
                KartSahipAd = response.Data.KartSahipAd,
                KartSahipSoyad = response.Data.KartSahipSoyad,
                KartTeknolojisi = response.Data.KartTeknolojisi
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewKrediKartıDto dto)
        {
            var postObj = new
            {
                MusteriID = dto.MusteriID,
                Baglıİban = dto.Baglıİban,
                KartNo = dto.KartNo,
                KartkullanımAy = dto.KartkullanımAy,
                KartkullanımYıl = dto.KartkullanımYıl,
                KartCVCNo = dto.KartCVCNo,
                KartSahipAd = dto.KartSahipAd,
                KartSahipSoyad = dto.KartSahipSoyad,
                KartTeknolojisi = dto.KartTeknolojisi
            };

            var response = await _httpApiService.PostData<ResponseBody<KrediKartıItem>>("/kredikartı", JsonSerializer.Serialize(postObj));

            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutKrediKartıDto dto)
        {
            var putObj = new
            {
                KrediKartıID = dto.KrediKartıID,
                MusteriID = dto.MusteriID,
                Baglıİban = dto.Baglıİban,
                KartNo = dto.KartNo,
                KartkullanımAy = dto.KartkullanımAy,
                KartkullanımYıl = dto.KartkullanımYıl,
                KartCVCNo = dto.KartCVCNo,
                KartSahipAd = dto.KartSahipAd,
                KartSahipSoyad = dto.KartSahipSoyad,
                KartTeknolojisi = dto.KartTeknolojisi
            };

            var response = await _httpApiService.PutData<ResponseBody<KrediKartıItem>>($"/kredikartı", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/kredikartı/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

