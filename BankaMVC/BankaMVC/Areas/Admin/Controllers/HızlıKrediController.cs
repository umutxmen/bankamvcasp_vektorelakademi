using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models.Dtos.DovizDtos;
using BankaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BankaMVC.Areas.Admin.Models.Dtos.EFTDtos;
using BankaMVC.Areas.Admin.Models.Dtos.EuroHesapDtos;
using BankaMVC.Areas.Admin.Models.Dtos.HızlıKrediDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class HızlıKrediController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public HızlıKrediController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response = await _httpApiService.GetData<ResponseBody<List<HızlıKrediItem>>>("/hizlikredi", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetHizliKredi(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<HızlıKrediItem>>($"/hizlikredi/{id}");

            return Json(new
            {
                HizliKrediID = response.Data.HizliKrediID,
                MusteriID = response.Data.MusteriID,
                Aktarılacakİban = response.Data.Aktarılacakİban,
                KrediMiktar = response.Data.KrediMiktar,
                KrediFaiz = response.Data.KrediFaiz,
                KrediÇekimTarihi = response.Data.KrediÇekimTarihi,
                KrediTaksitSayısı = response.Data.KrediTaksitSayısı,
                KrediSonOdemeTarih = response.Data.KrediSonOdemeTarih,
                KrediSonodemeTutar = response.Data.KrediSonodemeTutar
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewHızlıKrediDto dto)
        {
            var postObj = new
            {
                MusteriID = dto.MusteriID,
                Aktarılacakİban = dto.Aktarılacakİban,
                KrediMiktar = dto.KrediMiktar,
                KrediFaiz = dto.KrediFaiz,
                KrediÇekimTarihi = dto.KrediÇekimTarihi,
                KrediTaksitSayısı = dto.KrediTaksitSayısı,
                KrediSonOdemeTarih = dto.KrediSonOdemeTarih,
                KrediSonodemeTutar = dto.KrediSonodemeTutar
            };

            var response = await _httpApiService.PostData<ResponseBody<HızlıKrediItem>>("/hizlikredi", JsonSerializer.Serialize(postObj));

            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutHızlıKrediDto dto)
        {
            var putObj = new
            {
                HizliKrediID = dto.HizliKrediID,
                MusteriID = dto.MusteriID,
                Aktarılacakİban = dto.Aktarılacakİban,
                KrediMiktar = dto.KrediMiktar,
                KrediFaiz = dto.KrediFaiz,
                KrediÇekimTarihi = dto.KrediÇekimTarihi,
                KrediTaksitSayısı = dto.KrediTaksitSayısı,
                KrediSonOdemeTarih = dto.KrediSonOdemeTarih,
                KrediSonodemeTutar = dto.KrediSonodemeTutar
            };

            var response = await _httpApiService.PutData<ResponseBody<HızlıKrediItem>>($"/hizlikredi", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/hizlikredi/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}


