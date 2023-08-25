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
using BankaMVC.Areas.Admin.Models.Dtos.TLHavaleDtos;
using System.Reflection.Metadata;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class TLHavaleController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public TLHavaleController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response = await _httpApiService.GetData<ResponseBody<List<TLHavaleItem>>>("/tlhavale", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetHavale(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<TLHavaleItem>>($"/tlhavale/{id}");

            return Json(new
            {
                HavaleID = response.Data.HavaleID,
                MusteriID = response.Data.MusteriID,
                GidenHesapIban = response.Data.GidenHesapIban,
                AlanHesapIban = response.Data.AlanHesapIban,
                İslemTarih = response.Data.İslemTarih,
                Miktar = response.Data.Miktar,
                Aciklama = response.Data.Aciklama
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewTLHavaleDto dto)
        {
            var postObj = new
            {
                MusteriID = dto.MusteriID,
                GidenHesapIban = dto.GidenHesapIban,
                AlanHesapIban = dto.AlanHesapIban,
                İslemTarih = dto.İslemTarih,
                Miktar = dto.Miktar,
                Aciklama = dto.Aciklama
            };

            var response = await _httpApiService.PostData<ResponseBody<TLHavaleItem>>("/tlhavale", JsonSerializer.Serialize(postObj));
            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutTLHavaleDto dto)
        {
            var putObj = new
            {
                HavaleID = dto.HavaleID,
                MusteriID = dto.MusteriID,
                GidenHesapIban = dto.GidenHesapIban,
                AlanHesapIban = dto.AlanHesapIban,
                İslemTarih = dto.İslemTarih,
                Miktar = dto.Miktar,
                Aciklama = dto.Aciklama
            };

            var response = await _httpApiService.PutData<ResponseBody<TLHavaleItem>>($"/tlhavale", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/tlhavale/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

