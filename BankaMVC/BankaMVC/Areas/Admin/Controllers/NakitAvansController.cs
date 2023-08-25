using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models;
using BankaMVC.Areas.Admin.Models.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Models.Dtos.MusteriDataDtos;
using BankaMVC.Areas.Admin.Models.Dtos.MusteriVarlikDtos;
using BankaMVC.Areas.Admin.Models.Dtos.NakitAvansDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class NakitAvansController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public NakitAvansController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response = await _httpApiService.GetData<ResponseBody<List<NakitAvansItem>>>("/nakitavans", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetNakitAvans(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<NakitAvansItem>>($"/nakitavans/{id}");

            return Json(new
            {
                NakitAvansID = response.Data.NakitAvansID,
                MusteriID = response.Data.MusteriID,
                Aktarılanİban = response.Data.Aktarılanİban,
                SonOdemeTarihi = response.Data.SonOdemeTarihi,
                AvansMiktari = response.Data.AvansMiktari,
                Faizorani = response.Data.Faizorani,
                odenecekMiktar = response.Data.OdenecekMiktar
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewNakitAvansDto dto)
        {
            var postObj = new
            {
                musteriID = dto.MusteriID,
                aktarılanİban = dto.Aktarılanİban,
                sonOdemeTarihi = dto.SonOdemeTarihi,
                avansMiktari = dto.AvansMiktari,
                faizorani = dto.Faizorani,
                odenecekMiktar = dto.odenecekMiktar
            };

            var response = await _httpApiService.PostData<ResponseBody<NakitAvansItem>>("/nakitavans", JsonSerializer.Serialize(postObj));

            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutNakitAvansDto dto)
        {
            var putObj = new
            {
                NakitAvansID = dto.NakitAvansID,
                MusteriID = dto.MusteriID,
                Aktarılanİban = dto.Aktarılanİban,
                SonOdemeTarihi = dto.SonOdemeTarihi,
                AvansMiktarı = dto.AvansMiktarı,
                Faizoranı = dto.Faizoranı,
                odenecekMiktar = dto.odenecekMiktar
            };

            var response = await _httpApiService.PutData<ResponseBody<NakitAvansItem>>($"/nakitavans", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/nakitavans/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

