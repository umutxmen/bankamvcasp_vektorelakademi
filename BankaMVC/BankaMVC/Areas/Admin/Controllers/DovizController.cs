using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BankaMVC.Areas.Admin.Models.Dtos.BankaKartiDtos;
using BankaMVC.Areas.Admin.Models.Dtos.DovizDtos;

namespace BankaMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [SessionAspect]
    public class DovizController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IHttpApiService _httpApiService;

        public DovizController(IWebHostEnvironment webHost, IHttpApiService httpApiService)
        {
            _webHost = webHost;
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response =
              await _httpApiService.GetData<ResponseBody<List<DovizItem>>>("/doviz", token.Token);

            return View(response.Data);
        }


        [HttpPost]
        public async Task<IActionResult> Getdoviz(int id)
        {
            var response =
              await _httpApiService.GetData<ResponseBody<DovizItem>>($"/doviz/{id}");

            return Json(new
            {
              
                DovizID = response.Data.DovizID,
                DovizAdı = response.Data.DovizAdı,
                GüncelKurAlım = response.Data.GüncelKurAlım,
                GüncelKurSatım = response.Data.GüncelKurSatım
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewDovizDto dto)
        {

            var postObj = new
            {
                
                DovizAdı = dto.DovizAdı,
                GüncelKurAlım = dto.GüncelKurAlım,
                GüncelKurSatım = dto.GüncelKurSatım,
            };

            var response = await _httpApiService.PostData<ResponseBody<DovizItem>>("/doviz", JsonSerializer.Serialize(postObj));

            return View(response.Data);



        }

        [HttpPut]
        public async Task<IActionResult> Update(PutDovizDto dto)
        {
            var putObj = new
            {
                DovizID = dto.DovizID,
                DovizAdı = dto.DovizAdı,
                GüncelKurAlım = dto.GüncelKurAlım,
                GüncelKurSatım = dto.GüncelKurSatım,
            };

            var response = await _httpApiService.PutData<ResponseBody<DovizItem>>($"/doviz", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/doviz/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}

