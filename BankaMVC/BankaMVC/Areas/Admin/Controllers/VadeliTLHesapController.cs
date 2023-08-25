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
using BankaMVC.Areas.Admin.Models.Dtos.VadeliTLHesapDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class VadeliTLHesapController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public VadeliTLHesapController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response = await _httpApiService.GetData<ResponseBody<List<VadeliTLHesapItem>>>("/vadelitlhesap", token.Token);

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> GetVadeliTLHesap(int id)
        {
            var response = await _httpApiService.GetData<ResponseBody<VadeliTLHesapItem>>($"/vadelitlhesap/{id}");

            return Json(new
            {
                VadeliTLHesapID = response.Data.VadeliTLHesapID,
                MusteriID = response.Data.MusteriID,
                Varlık = response.Data.Varlık,
                VadeBasTarihi = response.Data.VadeBasTarihi,
                VadeBitisTarihi = response.Data.VadeBitisTarihi,
                VadeliFaizoran = response.Data.VadeliFaizoran,
                VadeSonuMiktar = response.Data.VadeSonuMiktar
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewVadeliTLHesapDto dto)
        {
            var postObj = new
            {
                MusteriID = dto.MusteriID,
                Varlık = dto.Varlık,
                VadeBasTarihi = dto.VadeBasTarihi,
                VadeBitisTarihi = dto.VadeBitisTarihi,
                VadeliFaizoran = dto.VadeliFaizoran,
                VadeSonuMiktar = dto.VadeSonuMiktar
            };

            var response = await _httpApiService.PostData<ResponseBody<VadeliTLHesapItem>>("/vadelitlhesap", JsonSerializer.Serialize(postObj));

            return View(response.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PutVadeliTLHesapDto dto)
        {
            var putObj = new
            {
                VadeliTLHesapID = dto.VadeliTLHesapID,
                MusteriID = dto.MusteriID,
                Varlık = dto.Varlık,
                VadeBasTarihi = dto.VadeBasTarihi,
                VadeBitisTarihi = dto.VadeBitisTarihi,
                VadeliFaizoran = dto.VadeliFaizoran,
                VadeSonuMiktar = dto.VadeSonuMiktar
            };

            var response = await _httpApiService.PutData<ResponseBody<VadeliTLHesapItem>>($"/vadelitlhesap", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/vadelitlhesap/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

