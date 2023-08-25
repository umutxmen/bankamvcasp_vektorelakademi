using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models.Dtos.DovizDtos;
using BankaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BankaMVC.Areas.Admin.Models.Dtos.EFTDtos;
using BankaMVC.Areas.Admin.Models.Dtos.EuroHesapDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class EFTController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public EFTController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response =
              await _httpApiService.GetData<ResponseBody<List<EFTItem>>>("/eft", token.Token);

            return View(response.Data);
        }


        [HttpPost]
        public async Task<IActionResult> Geteft(int id)
        {
            var response =
              await _httpApiService.GetData<ResponseBody<EFTItem>>($"/eft/{id}");

            return Json(new
            {

                EFTID = response.Data.EFTID,
                MusteriID = response.Data.MusteriID,
                BankaID = response.Data.BankaID,
                DigerBankaID = response.Data.DigerBankaID,
                GidenIban = response.Data.GidenIban,
                AlanIban = response.Data.AlanIban,
                Miktar = response.Data.Miktar,
                İslemTarihi = response.Data.İslemTarihi,
                Aciklama = response.Data.Aciklama
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewEFTDto dto)
        {

            var postObj = new
            {
                MusteriID = dto.MusteriID,
                BankaID = dto.BankaID,
                DigerBankaID = dto.DigerBankaID,
                GidenIban = dto.GidenIban,
                AlanIban = dto.AlanIban,
                Miktar = dto.Miktar,
                İslemTarihi = dto.İslemTarihi,
                Aciklama = dto.Aciklama
            };

            var response = await _httpApiService.PostData<ResponseBody<EFTItem>>("/eft", JsonSerializer.Serialize(postObj));

            return View(response.Data);



        }

        [HttpPut]
        public async Task<IActionResult> Update(PutEFTDto dto)
        {
            var putObj = new
            {
                EFTID = dto.EFTID,
                MusteriID = dto.MusteriID,
                BankaID = dto.BankaID,
                DigerBankaID = dto.DigerBankaID,
                GidenIban = dto.GidenIban,
                AlanIban = dto.AlanIban,
                Miktar = dto.Miktar,
                İslemTarihi = dto.İslemTarihi,
                Aciklama = dto.Aciklama
            };

            var response = await _httpApiService.PutData<ResponseBody<DovizItem>>($"/eft", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/eft/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

