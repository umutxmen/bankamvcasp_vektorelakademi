using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models.Dtos.DovizDtos;
using BankaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BankaMVC.Areas.Admin.Models.Dtos.EFTDtos;
using BankaMVC.Areas.Admin.Models.Dtos.EuroHesapDtos;
using BankaMVC.Areas.Admin.Models.Dtos.KartlarDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class KartlarController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public KartlarController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response = await _httpApiService.GetData<ResponseBody<List<KartlarItem>>>("/kartlar", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetKartlar(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<KartlarItem>>($"/kartlar/{id}");

            return Json(new
            {
                KartlarID = response.Data.KartlarID,
                MusteriID = response.Data.MusteriID,
                KrediKartıID = response.Data.KrediKartıID,
                KrediKartı2ID = response.Data.KrediKartı2ID,
                KrediKartı3ID = response.Data.KrediKartı3ID,
                BankaKartıID = response.Data.BankaKartıID,
                BankaKartı2ID = response.Data.BankaKartı2ID,
                BankaKartı3ID = response.Data.BankaKartı3ID,
                SanalKartID = response.Data.SanalKartID,
                SanalKart2ID = response.Data.SanalKart2ID,
                SanalKart3ID = response.Data.SanalKart3ID
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewKartlarDto dto)
        {
            var postObj = new
            {
                MusteriID = dto.MusteriID,
                KrediKartıID = dto.KrediKartıID,
                KrediKartı2ID = dto.KrediKartı2ID,
                KrediKartı3ID = dto.KrediKartı3ID,
                BankaKartıID = dto.BankaKartıID,
                BankaKartı2ID = dto.BankaKartı2ID,
                BankaKartı3ID = dto.BankaKartı3ID,
                SanalKartID = dto.SanalKartID,
                SanalKart2ID = dto.SanalKart2ID,
                SanalKart3ID = dto.SanalKart3ID
            };

            var response = await _httpApiService.PostData<ResponseBody<KartlarItem>>("/kartlar", JsonSerializer.Serialize(postObj));

            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutKartlarDto dto)
        {
            var putObj = new
            {
                KartlarID = dto.KartlarID,
                MusteriID = dto.MusteriID,
                KrediKartıID = dto.KrediKartıID,
                KrediKartı2ID = dto.KrediKartı2ID,
                KrediKartı3ID = dto.KrediKartı3ID,
                BankaKartıID = dto.BankaKartıID,
                BankaKartı2ID = dto.BankaKartı2ID,
                BankaKartı3ID = dto.BankaKartı3ID,
                SanalKartID = dto.SanalKartID,
                SanalKart2ID = dto.SanalKart2ID,
                SanalKart3ID = dto.SanalKart3ID
            };

            var response = await _httpApiService.PutData<ResponseBody<KartlarItem>>($"/kartlar", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/kartlar/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

