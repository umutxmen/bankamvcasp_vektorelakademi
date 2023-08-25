using BankaMVC.Areas.Admin.Filters;
using BankaMVC.Areas.Admin.HttpApiServices;
using BankaMVC.Areas.Admin.Models;
using BankaMVC.Areas.Admin.Models.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BankaMVC.Areas.Admin.Extensions;
using BankaMVC.Areas.Admin.Models.Dtos.MusteriDataDtos;
using BankaMVC.Areas.Admin.Models.Dtos.MusteriVarlikDtos;

namespace AhlatciProject.MvcUI.Areas.Admin.Controllers
{
  [Area("Admin")]
  [SessionAspect]
  public class MusteriVarlikController : Controller
  {
        private readonly IHttpApiService _httpApiService;
        private readonly IWebHostEnvironment _webHost;
        public MusteriVarlikController(IHttpApiService httpApiService, IWebHostEnvironment webHost)
        {
            _httpApiService = httpApiService;
            _webHost = webHost;

        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetObject<AccessTokenItem>("AccessToken");

            var response =
              await _httpApiService.GetData<ResponseBody<List<MusteriVarlikItem>>>("/musterivarlik", token.Token);

            return View(response.Data);
        }
        [HttpPost]
        public async Task<IActionResult> GetMusteriVarlik(int id)
        {
            var response =
              await _httpApiService.GetData<ResponseBody<MusteriVarlikItem>>($"/musterivarlik/{id}");

            return Json(new

            {   musteriVarlikID=response.Data.MusteriVarlikID,
                musteriAD = response.Data.MusteriAD,
                musteriDataID = response.Data.MusteriDataID,
                bankaId = response.Data.BankaId,
                hesapTLVadesiz = response.Data.HesapTLVadesiz,
                hesapTLVadeli = response.Data.HesapTLVadeli,
                hesapDolarVadesiz = response.Data.HesapDolarVadesiz,
                hesapEuroVadesiz = response.Data.HesapEuroVadesiz,
                hesapSterlinVadesiz = response.Data.HesapSterlinVadesiz,
                hesapAltinVadesiz = response.Data.HesapAltinVadesiz,
                hesapGumusVadesiz = response.Data.HesapGumusVadesiz,
                vadesizTLHesapID = response.Data.VadesizTLHesapID,
                vadeliTLHesapID = response.Data.VadeliTLHesapID,
                dolarHesapID = response.Data.DolarHesapID,
                euroHesapID = response.Data.EuroHesapID,
                sterlinHesapID = response.Data.SterlinHesapID,
                kurKorumalıTLHesapID = response.Data.KurKorumalıTLHesapID,
                altinHesapID = response.Data.AltinHesapID,
                gumusHesapID = response.Data.GumusHesapID,
                bankaKartlarID = response.Data.BankaKartlarID,
                krediKartlarID = response.Data.KrediKartlarID,
                ibanlarID = response.Data.IbanlarID
            });

        }

        [HttpPost]
        public async Task<IActionResult> Save(NewMusteriVarlikDto dto)
        {

            var postObj = new
            {
                MusteriAD = dto.MusteriAD,
                MusteriDataID = dto.MusteriDataID,

                // Add other properties here...
                BankaId = dto.BankaId,
                HesapTLVadesiz = dto.HesapTLVadesiz,
                HesapTLVadeli = dto.HesapTLVadeli,
                HesapDolarVadesiz = dto.HesapDolarVadesiz,
                HesapEuroVadesiz = dto.HesapEuroVadesiz,
                HesapSterlinVadesiz = dto.HesapSterlinVadesiz,
                HesapAltinVadesiz = dto.HesapAltinVadesiz,
                HesapGumusVadesiz = dto.HesapGumusVadesiz,
                VadesizTLHesapID = dto.VadesizTLHesapID,
                VadeliTLHesapID = dto.VadeliTLHesapID,
                DolarHesapID = dto.DolarHesapID,
                EuroHesapID = dto.EuroHesapID,
                SterlinHesapID = dto.SterlinHesapID,
                KurKorumalıTLHesapID = dto.KurKorumalıTLHesapID,
                AltinHesapID = dto.AltinHesapID,
                GumusHesapID = dto.GumusHesapID,
                BankaKartlarID = dto.BankaKartlarID,
                KrediKartlarID = dto.KrediKartlarID,
                IbanlarID = dto.IbanlarID
            };

            var response = await _httpApiService.PostData<ResponseBody<MusteriVarlikItem>>("/musterivarlik", JsonSerializer.Serialize(postObj));

            return View(response.Data);

        }


        [HttpPut]
        public async Task<IActionResult> Update(PutMusteriVarlikDtocs dto)
        {
            var putObj = new
            {
                MusteriVarlikID = dto.MusteriVarlikID,
                MusteriAD = dto.MusteriAD,
                MusteriDataID = dto.MusteriDataID,
                BankaId = dto.BankaId,
                HesapTLVadesiz = dto.HesapTLVadesiz,
                HesapTLVadeli = dto.HesapTLVadeli,
                HesapDolarVadesiz = dto.HesapDolarVadesiz,
                HesapEuroVadesiz = dto.HesapEuroVadesiz,
                HesapSterlinVadesiz = dto.HesapSterlinVadesiz,
                HesapAltinVadesiz = dto.HesapAltinVadesiz,
                HesapGumusVadesiz = dto.HesapGumusVadesiz,
                VadesizTLHesapID = dto.VadesizTLHesapID,
                VadeliTLHesapID = dto.VadeliTLHesapID,
                DolarHesapID = dto.DolarHesapID,
                EuroHesapID = dto.EuroHesapID,
                SterlinHesapID = dto.SterlinHesapID,
                KurKorumalıTLHesapID = dto.KurKorumalıTLHesapID,
                AltinHesapID = dto.AltinHesapID,
                GumusHesapID = dto.GumusHesapID,
                BankaKartlarID = dto.BankaKartlarID,
                KrediKartlarID = dto.KrediKartlarID,
                IbanlarID = dto.IbanlarID
            };

            var response = await _httpApiService.PutData<ResponseBody<MusteriVarlikItem>>($"/musterivarlik", JsonSerializer.Serialize(putObj));

            return View(response.Data);
        }



        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/musterivarlik/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }
    }
}
