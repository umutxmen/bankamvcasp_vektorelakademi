using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using BankaMVC.Areas.Admin.Models.Dtos.BankaBilgiDtos;
using System.Text.Json;
using Humanizer;
using Microsoft.CodeAnalysis;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using System.Buffers.Text;
using System.Numerics;
using System.Reflection.Metadata;
using System;
using NuGet.Common;

namespace BankaMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [SessionAspect]
    public class BankaBilgiController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public BankaBilgiController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response =
              await _httpApiService.GetData<ResponseBody<List<BankaBilgiItem>>>("/bankabilgi", token.Token);

            return View(response.Data);
        }


        [HttpPost]
        public async Task<IActionResult> GetBankaBilgi(int id)
        {
            var response =
              await _httpApiService.GetData<ResponseBody<BankaBilgiItem>>($"/bankabilgi/{id}");

            return Json(new
            {
                BankaSubeNo = response.Data.BankaSubeNo,
                BankaSehir = response.Data.BankaSehir,
                Bankaİlce = response.Data.Bankaİlce,
                BankaAdres = response.Data.BankaAdres,
                BankaTel = response.Data.BankaTel,

            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewBankaBilgiItemDto dto)
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var postObj = new
            {
                BankaSubeNo = dto.BankaSubeNo,
                BankaSehir = dto.BankaSehir,
                Bankaİlce = dto.Bankaİlce,
                BankaAdres = dto.BankaAdres,
                BankaTel = dto.BankaTel,
            };

            var response = await _httpApiService.PostData<ResponseBody<BankaBilgiItem>>("/bankabilgi", JsonSerializer.Serialize(postObj), token.Token);

            return View(response.Data);



        }

        [HttpPut]
        public async Task<IActionResult> Update(PutBankaBilgiItemDto dto)
        {
            var putObj = new
            {
                BankaId = dto.BankaId,
                BankaSubeNo = dto.BankaSubeNo,
                BankaSehir = dto.BankaSehir,
                Bankaİlce = dto.Bankaİlce,
                BankaAdres = dto.BankaAdres,
                BankaTel = dto.BankaTel,
            };

            var response = await _httpApiService.PutData<ResponseBody<BankaBilgiItem>>($"/bankabilgi", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/bankabilgi/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}
