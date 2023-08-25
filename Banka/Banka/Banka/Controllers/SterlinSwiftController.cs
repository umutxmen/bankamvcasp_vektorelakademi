using Banka.Business.Interfaces;
using Banka.Model.Dtos.SterlinSwift;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/sterlinswift")]
    [ApiController]
    public class SterlinSwiftController : BaseController
    {
        private readonly ISterlinSwiftBs _ISterlinSwiftBs;
        public SterlinSwiftController(ISterlinSwiftBs SterlinSwift)
        {
            _ISterlinSwiftBs = SterlinSwift;
        }


        [HttpGet]
        public async Task<IActionResult> GetSterlinSwiftAsync()
        {
            var response = await _ISterlinSwiftBs.GetSterlinSwiftAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _ISterlinSwiftBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByGidenHesapIbanAsync")]
        public async Task<IActionResult> GetByGidenHesapIbanAsync([FromQuery] string GidenHesapIban)
        {
            var response = await _ISterlinSwiftBs.GetByGidenHesapIbanAsync(GidenHesapIban);
            return SendResponse(response);
        }
        [HttpGet("GetByAlanHesapIbanAsync")]
        public async Task<IActionResult> GetByAlanHesapIbanAsync([FromQuery] string AlanHesapIban)
        {
            var response = await _ISterlinSwiftBs.GetByAlanHesapIbanAsync(AlanHesapIban);
            return SendResponse(response);
        }
        [HttpGet("GetBySwiftTarihiAsync")]
        public async Task<IActionResult> GetBySwiftTarihiAsync([FromQuery] DateTime SwiftTarihi)
        {
            var response = await _ISterlinSwiftBs.GetBySwiftTarihiAsync(SwiftTarihi);
            return SendResponse(response);
        }
        [HttpGet("GetByMiktarAsync")]
        public async Task<IActionResult> GetByMiktarAsync([FromQuery] decimal Miktar)
        {
            var response = await _ISterlinSwiftBs.GetByMiktarAsync(Miktar);
            return SendResponse(response);
        }
        [HttpGet("GetBySwiftKoduAsync")]
        public async Task<IActionResult> GetBySwiftKoduAsync([FromQuery] int SwiftKodu)
        {
            var response = await _ISterlinSwiftBs.GetBySwiftKoduAsync(SwiftKodu);
            return SendResponse(response);
        }
        [HttpGet("GetByAciklamaAsync")]
        public async Task<IActionResult> GetByAciklamaAsync([FromQuery] string Aciklama)
        {
            var response = await _ISterlinSwiftBs.GetByAciklamaAsync(Aciklama);
            return SendResponse(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _ISterlinSwiftBs.GetByIdAsync(id);
            return SendResponse(response);
        }



        [HttpPost]
        public async Task<IActionResult> SaveNewSterlinSwift([FromBody] SterlinSwiftPostDto dto)
        {
            var response = await _ISterlinSwiftBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.MusteriID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateSterlinSwift([FromBody] SterlinSwiftPutDto dto)
        {
            var response = await _ISterlinSwiftBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSterlinSwift([FromRoute] int id)
        {
            var response = await _ISterlinSwiftBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
