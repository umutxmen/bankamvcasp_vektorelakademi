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
using BankaMVC.Areas.Admin.Models.Dtos.VergiBorcuOdeDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class VergiBorcuÖdeController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public VergiBorcuÖdeController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response = await _httpApiService.GetData<ResponseBody<List<VergiBorcuÖdeItem>>>("/vergiborcuode", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetVergiOde(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<VergiBorcuÖdeItem>>($"/vergiborcuode/{id}");

            return Json(new
            {
                VergiodeİslemID = response.Data.VergiodeİslemID,
                MusteriID = response.Data.MusteriID,
                vergino = response.Data.vergino,
                MusteriTCNo = response.Data.MusteriTCNo,
                GondericiIBAN = response.Data.GondericiIBAN,
                GondericiAD = response.Data.GondericiAD,
                GondericiSoyad = response.Data.GondericiSoyad,
                Aciklama = response.Data.Aciklama,
                OdemeTarih = response.Data.OdemeTarih
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewVergiBorcuÖdeDto dto)
        {
            var postObj = new
            {
                MusteriID = dto.MusteriID,
                vergino = dto.vergino,
                MusteriTCNo = dto.MusteriTCNo,
                GondericiIBAN = dto.GondericiIBAN,
                GondericiAD = dto.GondericiAD,
                GondericiSoyad = dto.GondericiSoyad,
                Aciklama = dto.Aciklama,
                OdemeTarih = dto.OdemeTarih
            };

            var response = await _httpApiService.PostData<ResponseBody<VergiBorcuÖdeItem>>("/vergiborcuode", JsonSerializer.Serialize(postObj));

            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutVergiBorcuÖdeDto dto)
        {
            var putObj = new
            {
                VergiodeİslemID = dto.VergiodeİslemID,
                MusteriID = dto.MusteriID,
                vergino = dto.vergino,
                MusteriTCNo = dto.MusteriTCNo,
                GondericiIBAN = dto.GondericiIBAN,
                GondericiAD = dto.GondericiAD,
                GondericiSoyad = dto.GondericiSoyad,
                Aciklama = dto.Aciklama,
                OdemeTarih = dto.OdemeTarih
            };

            var response = await _httpApiService.PutData<ResponseBody<VergiBorcuÖdeItem>>($"/vergiborcuode", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/vergiborcuode/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

