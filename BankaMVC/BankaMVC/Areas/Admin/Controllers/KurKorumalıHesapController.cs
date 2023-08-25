using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models.Dtos.DovizDtos;
using BankaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BankaMVC.Areas.Admin.Models.Dtos.EFTDtos;
using BankaMVC.Areas.Admin.Models.Dtos.EuroHesapDtos;
using BankaMVC.Areas.Admin.Models.Dtos.KurKorumalıHesapDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class KurKorumalıHesapController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public KurKorumalıHesapController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response = await _httpApiService.GetData<ResponseBody<List<KurKorumalıHesapItem>>>("/KurKorumalıHesap", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetKurKorumaliHesap(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<KurKorumalıHesapItem>>($"/KurKorumalıHesap/{id}");

            return Json(new
            {
                KurKorumaliHesapId = response.Data.KurKorumaliHesapId,
                MusteriID = response.Data.MusteriID,
                VarlikTL = response.Data.VarlikTL,
                DovizID = response.Data.DovizID,
                HesapAcimTarihi = response.Data.HesapAcimTarihi,
                HesapAcimKuru = response.Data.HesapAcimKuru,
                HesapKapanmaTarihi = response.Data.HesapKapanmaTarihi,
                HesapKapanmaKuru = response.Data.HesapKapanmaKuru,
                HesapFaizoran = response.Data.HesapFaizoran
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewKurKorumalıHesapDto dto)
        {
            var postObj = new
            {
                MusteriID = dto.MusteriID,
                VarlikTL = dto.VarlikTL,
                DovizID = dto.DovizID,
                HesapAcimTarihi = dto.HesapAcimTarihi,
                HesapAcimKuru = dto.HesapAcimKuru,
                HesapKapanmaTarihi = dto.HesapKapanmaTarihi,
                HesapKapanmaKuru = dto.HesapKapanmaKuru,
                HesapFaizOran = dto.HesapFaizoran
            };

            var response = await _httpApiService.PostData<ResponseBody<KurKorumalıHesapItem>>("/KurKorumalıHesap", JsonSerializer.Serialize(postObj));
            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutKurKorumalıHesapDto dto)
        {
            var putObj = new
            {
                KurKorumaliHesapId = dto.KurKorumaliHesapId,
                MusteriID = dto.MusteriID,
                VarlikTL = dto.VarlikTL,
                DovizID = dto.DovizID,
                HesapAcimTarihi = dto.HesapAcimTarihi,
                HesapAcimKuru = dto.HesapAcimKuru,
                HesapKapanmaTarihi = dto.HesapKapanmaTarihi,
                HesapKapanmaKuru = dto.HesapKapanmaKuru,
                HesapFaizOran = dto.HesapFaizoran
            };

            var response = await _httpApiService.PutData<ResponseBody<KurKorumalıHesapItem>>($"/KurKorumalıHesap", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/KurKorumalıHesap/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

