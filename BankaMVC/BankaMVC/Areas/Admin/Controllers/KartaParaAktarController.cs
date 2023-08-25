using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models.Dtos.DovizDtos;
using BankaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BankaMVC.Areas.Admin.Models.Dtos.EFTDtos;
using BankaMVC.Areas.Admin.Models.Dtos.EuroHesapDtos;
using BankaMVC.Areas.Admin.Models.Dtos.KartaParaAktarDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class KartaParaAktarController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public KartaParaAktarController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response = await _httpApiService.GetData<ResponseBody<List<KartaParaAktarItem>>>("/kartaparakaktar", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetKartaParaAktar(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<KartaParaAktarItem>>($"/kartaparakaktar/{id}");

            return Json(new
            {
                KartaParaİslemID = response.Data.KartaParaİslemID,
                MusteriID = response.Data.MusteriID,
                AktarılacakKartID = response.Data.AktarılacakKartID,
                VarlıkHesabı = response.Data.VarlıkHesabı,
                Miktar = response.Data.Miktar,
                İslemTarihi = response.Data.İslemTarihi
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewKartaParaAktarDto dto)
        {
            var postObj = new
            {
                MusteriID = dto.MusteriID,
                AktarılacakKartID = dto.AktarılacakKartID,
                VarlıkHesabı = dto.VarlıkHesabı,
                Miktar = dto.Miktar,
                İslemTarihi = dto.İslemTarihi
            };

            var response = await _httpApiService.PostData<ResponseBody<KartaParaAktarItem>>("/kartaparakaktar", JsonSerializer.Serialize(postObj));

            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutKartaParaAktarDto dto)
        {
            var putObj = new
            {
                KartaParaİslemID = dto.KartaParaİslemID,
                MusteriID = dto.MusteriID,
                AktarılacakKartID = dto.AktarılacakKartID,
                VarlıkHesabı = dto.VarlıkHesabı,
                Miktar = dto.Miktar,
                İslemTarihi = dto.İslemTarihi
            };

            var response = await _httpApiService.PutData<ResponseBody<KartaParaAktarItem>>($"/kartaparakaktar", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/kartaparakaktar/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

