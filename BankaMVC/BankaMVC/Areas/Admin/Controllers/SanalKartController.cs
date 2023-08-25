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
using BankaMVC.Areas.Admin.Models.Dtos.SanalKartDtos;
using BankaMVC.Areas.Admin.Models.Dtos.SanalKartPutDto;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class SanalKartController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public SanalKartController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response = await _httpApiService.GetData<ResponseBody<List<SanalKartItem>>>("/sanalkart", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetSanalKart(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<SanalKartItem>>($"/sanalkart/{id}");

            return Json(new
            {
                SanalKartID = response.Data.SanalKartID,
                MusteriID = response.Data.MusteriID,
                BagliKrediKartID = response.Data.BagliKrediKartID,
                KartNo = response.Data.KartNo,
                KartKullanımAy = response.Data.KartKullanımAy,
                KartKullanumYıl = response.Data.KartKullanumYıl,
                KartCVCNo = response.Data.KartCVCNo,
                KartSahipAd = response.Data.KartSahipAd,
                KartSahipSoyad = response.Data.KartSahipSoyad,
                KartTeknolojisi = response.Data.KartTeknolojisi
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewSanalKartDto dto)
        {
            var postObj = new
            {
                MusteriID = dto.MusteriID,
                BagliKrediKartID = dto.BagliKrediKartID,
                KartNo = dto.KartNo,
                KartKullanımAy = dto.KartKullanımAy,
                KartKullanumYıl = dto.KartKullanumYıl,
                KartCVCNo = dto.KartCVCNo,
                KartSahipAd = dto.KartSahipAd,
                KartSahipSoyad = dto.KartSahipSoyad,
                KartTeknolojisi = dto.KartTeknolojisi
            };

            var response = await _httpApiService.PostData<ResponseBody<SanalKartItem>>("/sanalkart", JsonSerializer.Serialize(postObj));

            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutSanalKartDto dto)
        {
            var putObj = new
            {
                SanalKartID = dto.SanalKartID,
                MusteriID = dto.MusteriID,
                BagliKrediKartID = dto.BagliKrediKartID,
                KartNo = dto.KartNo,
                KartKullanımAy = dto.KartKullanımAy,
                KartKullanumYıl = dto.KartKullanumYıl,
                KartCVCNo = dto.KartCVCNo,
                KartSahipAd = dto.KartSahipAd,
                KartSahipSoyad = dto.KartSahipSoyad,
                KartTeknolojisi = dto.KartTeknolojisi
            };

            var response = await _httpApiService.PutData<ResponseBody<SanalKartItem>>($"/sanalkart", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/sanalkart/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

