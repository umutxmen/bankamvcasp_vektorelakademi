using BankaMVC.Areas.Admin.Models;
using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using BankaMVC.Areas.Admin.Models.Dtos.MusteriDataDtos;
using BankaMVC.Areas.Admin.Extensions;
using System.Text.Json;
using BankaMVC.Areas.Admin.Models.Dtos.BankaBilgiDtos;
using Microsoft.Build.Evaluation;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using NuGet.Common;
using BankaMVC.Models.Dtos.MusteriDataDtos;

namespace AhlatciProject.MvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
  [SessionAspect]
  public class MusteriDataController : Controller
  {
        private readonly IHttpApiService _httpApiService;
        private readonly IWebHostEnvironment _webHost;

        public MusteriDataController(IHttpApiService httpApiService, IWebHostEnvironment webHost)
        {
            _httpApiService = httpApiService;
            _webHost = webHost;

        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // Oturumdan erişim belirteci (token) alma
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            // HTTP API servisi kullanarak verileri çekme
            var response = await _httpApiService.GetData<ResponseBody<List<MusteriDataItem>>>("/musteridata", token.Token);

            // Resim yolu kontrolü ve alternatif resim yolu ekleme
            foreach (var musteriData in response.Data)
            {
                musteriData.PicturePath = await GetValidPicturePath(musteriData.PicturePath);
            }

            // Görünümde modeli kullanarak sayfayı döndürme
            return View(response.Data);
        }

        // Verilen resim yolunun geçerli olup olmadığını kontrol eden fonksiyon
        public async Task<string> GetValidPicturePath(string originalPath)
        {
            // Resim yolunun fiziksel dosya yoluna çevirilmesi
            string imagePath = _webHost.WebRootFileProvider.GetFileInfo(originalPath).PhysicalPath;

            // Dosya varsa orijinal resim yolunu döndürme
            if (System.IO.File.Exists(imagePath))
            {
                return originalPath;
            }
            else
            {
                // Dosya yoksa alternatif resim yolunu döndürme
                return "/admin/noImage.png"; // Alternatif resim yolu
            }
        }
        [HttpPost]
        public async Task<IActionResult> GetMusteriData(int id)
        {
            var response =
              await _httpApiService.GetData<ResponseBody<MusteriDataItem>>($"/musteridata/{id}");

            return Json(new {
                musteriDataID = response.Data.MusteriDataID,
                musteriAD = response.Data.MusteriAD,
                musteriSoYAD = response.Data.MusteriSoYAD,
                musteriTC = response.Data.MusteriTC,
                musteriTEL = response.Data.MusteriTEL,
                musteriMeslek = response.Data.MusteriMeslek,
                musteriAdres = response.Data.MusteriAdres,
                musteriEmail = response.Data.MusteriEmail,
                musteriAnneliksoyad = response.Data.MusteriAnneliksoyad,
                PicturePath = response.Data.PicturePath,
            });
              
        }

        [HttpPost]
        public async Task<IActionResult> Save(NewMusteriDataItemDto dto, IFormFile musteriPhoto)
        {

            if (musteriPhoto != null)
            {
                // ContentType : Dosyanın MIME TYPE'ını verir.
                // Length : Dosyanın büyüklüğünü verir (byte cinsinden verir)
                // FileName : Dosyanın adını verir (uzantısıyla birlikte)

                if (!musteriPhoto.ContentType.StartsWith("image/"))
                    return Json(new { IsSuccess = false, Message = "Kategori için sadece resim dosyası seçilmelidir." });

                if (musteriPhoto.Length > 500 * 1024)
                    return Json(new { IsSuccess = false, Message = "Kategori için seçilen resim dosyası maksimum 500 KB olabilir." });

             
                var randomFileName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(musteriPhoto.FileName)}";
                var picturePath = $@"/admin/musteriImages/{randomFileName}";
                var uploadPath = $@"{_webHost.ContentRootPath}/wwwroot{picturePath}";

                using (var fs = new FileStream(uploadPath, FileMode.Create))
                {
                    musteriPhoto.CopyTo(fs);
                }

                var postObj = new
                {
                    MusteriAD = dto.MusteriAD,
                    MusteriSoYAD = dto.MusteriSoYAD,
                    MusteriTC = dto.MusteriTC,
                    MusteriTEL = dto.MusteriTEL,
                    MusteriMeslek = dto.MusteriMeslek,
                    MusteriAdres = dto.MusteriAdres,
                    MusteriEmail = dto.MusteriEmail,
                    MusteriAnneliksoyad = dto.MusteriAnneliksoyad,
                    PicturePath = picturePath,


                };

                var response = await _httpApiService.PostData<ResponseBody<MusteriDataItem>>("/musteridata", JsonSerializer.Serialize(postObj));


                if (response.StatusCode == 201)
                {
                    return Json(
                      new
                      {
                          IsSuccess = true,
                          Message = "musteridata Başarıyla Kaydedildi",
                          PicturePath = response.Data.PicturePath,
                          CategoryId = response.Data.MusteriDataID
                      });
                }
                else
                {
                    return Json(new { IsSuccess = false, Messages = response.ErrorMessages });
                }


            }
            else
            {
                return Json(new { IsSuccess = false, Message = "Musteri için dosya seçilmelidir." });
            }

        }

    
        [HttpPut]
        public async Task<IActionResult> Update(PutMusteriDataItem dto, IFormFile musteriPhoto)
        {

            if (musteriPhoto != null)
            {
                // ContentType : Dosyanın MIME TYPE'ını verir.
                // Length : Dosyanın büyüklüğünü verir (byte cinsinden verir)
                // FileName : Dosyanın adını verir (uzantısıyla birlikte)

                if (!musteriPhoto.ContentType.StartsWith("image/"))
                    return Json(new { IsSuccess = false, Message = "Kategori için sadece resim dosyası seçilmelidir." });

                if (musteriPhoto.Length > 500 * 1024)
                    return Json(new { IsSuccess = false, Message = "Kategori için seçilen resim dosyası maksimum 500 KB olabilir." });


                var randomFileName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(musteriPhoto.FileName)}";
                var picturePath = $@"/admin/musteriImages/{randomFileName}";
                var uploadPath = $@"{_webHost.ContentRootPath}/wwwroot{picturePath}";

                using (var fs = new FileStream(uploadPath, FileMode.Create))
                {
                    musteriPhoto.CopyTo(fs);
                }
                var putObj = new
            {
                MusteriDataID = dto.MusteriDataID,
                MusteriAD = dto.MusteriAD,
                MusteriSoYAD = dto.MusteriSoYAD,
                MusteriTC = dto.MusteriTC,
                MusteriTEL = dto.MusteriTEL,
                MusteriMeslek = dto.MusteriMeslek,
                MusteriAdres = dto.MusteriAdres,
                MusteriEmail = dto.MusteriEmail,
                MusteriAnneliksoyad = dto.MusteriAnneliksoyad,
                PicturePath = picturePath,

                };


                var response = await _httpApiService.PutData<ResponseBody<MusteriDataItem>>("/musteridata", JsonSerializer.Serialize(putObj));


                if (response.StatusCode == 201)
                {
                    return Json(
                      new
                      {
                          IsSuccess = true,
                          Message = "musteridata Başarıyla Kaydedildi",
                          PicturePath = response.Data.PicturePath,
                          CategoryId = response.Data.MusteriDataID
                      });
                }
                else
                {
                    return Json(new { IsSuccess = false, Messages = response.ErrorMessages });
                }


            }
            else
            {
                return Json(new { IsSuccess = false, Message = "Musteri için dosya seçilmelidir." });
            }
        }
        public async Task<IActionResult> Delete(int id)
        {
       

            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/musteridata/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}
