using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models.Dtos.DovizDtos;
using BankaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BankaMVC.Areas.Admin.Models.Dtos.EFTDtos;
using BankaMVC.Areas.Admin.Models.Dtos.EuroHesapDtos;
using BankaMVC.Areas.Admin.Models.Dtos.HarcamaDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class HarcamaController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public HarcamaController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response = await _httpApiService.GetData<ResponseBody<List<HarcamaItem>>>("/harcama", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetHarcama(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<HarcamaItem>>($"/harcama/{id}");

            return Json(new
            {
                HarcamaID = response.Data.HarcamaID,
                MusteriID = response.Data.MusteriID,
                HarcananKartID = response.Data.HarcananKartID,
                HarcananMiktar = response.Data.HarcananMiktar,
                TaksitMiktarı = response.Data.TaksitMiktarı,
                HarcamaTarihi = response.Data.HarcamaTarihi,
                SatıcıKodu = response.Data.SatıcıKodu
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewHarcamaDto dto)
        {
            var postObj = new
            {
                MusteriID = dto.MusteriID,
                HarcananKartID = dto.HarcananKartID,
                HarcananMiktar = dto.HarcananMiktar,
                TaksitMiktarı = dto.TaksitMiktarı,
                HarcamaTarihi = dto.HarcamaTarihi,
                SatıcıKodu = dto.SatıcıKodu
            };

            var response = await _httpApiService.PostData<ResponseBody<HarcamaItem>>("/harcama", JsonSerializer.Serialize(postObj));

            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutHarcamaDto dto)
        {
            var putObj = new
            {
                HarcamaID = dto.HarcamaID,
                MusteriID = dto.MusteriID,
                HarcananKartID = dto.HarcananKartID,
                HarcananMiktar = dto.HarcananMiktar,
                TaksitMiktarı = dto.TaksitMiktarı,
                HarcamaTarihi = dto.HarcamaTarihi,
                SatıcıKodu = dto.SatıcıKodu
            };

            var response = await _httpApiService.PutData<ResponseBody<HarcamaItem>>($"/harcama", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/harcama/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

