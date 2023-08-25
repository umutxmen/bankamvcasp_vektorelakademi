using Banka.Business.Interfaces;
using Banka.Model.Dtos.EuroHesap;
using Banka.Model.Dtos.EuroSwift;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/euroswift")]
    [ApiController]
    public class EuroSwiftController : BaseController
    {
        private readonly IEuroSwiftBs _IEuroSwiftBs;
        public EuroSwiftController(IEuroSwiftBs EuroSwift)
        {
            _IEuroSwiftBs = EuroSwift;
        }


        [HttpGet]
        public async Task<IActionResult> GetEuroSwiftAsync()
        {
            var response = await _IEuroSwiftBs.GetEuroSwiftAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _IEuroSwiftBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByGidenHesapIbanAsync")]
        public async Task<IActionResult> GetByGidenHesapIbanAsync([FromQuery] string GidenHesapIban)
        {
            var response = await _IEuroSwiftBs.GetByGidenHesapIbanAsync(GidenHesapIban);
            return SendResponse(response);
        }
        [HttpGet("GetByAlanHesapIbanAsync")]
        public async Task<IActionResult> GetByAlanHesapIbanAsync([FromQuery] string AlanHesapIban)
        {
            var response = await _IEuroSwiftBs.GetByAlanHesapIbanAsync(AlanHesapIban);
            return SendResponse(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IEuroSwiftBs.GetByIdAsync(id);
            return SendResponse(response);
        }

        [HttpGet("GetBySwiftTarihiAsync")]
        public async Task<IActionResult> GetBySwiftTarihiAsync([FromQuery] DateTime SwiftTarihi)
        {
            var response = await _IEuroSwiftBs.GetBySwiftTarihiAsync(SwiftTarihi);
            return SendResponse(response);
        }

        [HttpGet("GetByMiktarAsync")]
        public async Task<IActionResult> GetByMiktarAsync([FromQuery] int Miktar)
        {
            var response = await _IEuroSwiftBs.GetByMiktarAsync(Miktar);
            return SendResponse(response);
        }

        [HttpGet("GetBySwiftKoduAsync")]
        public async Task<IActionResult> GetBySwiftKoduAsync([FromQuery] int SwiftKodu)
        {
            var response = await _IEuroSwiftBs.GetBySwiftKoduAsync(SwiftKodu);
            return SendResponse(response);
        }

        [HttpGet("GetByAciklamaAsync")]
        public async Task<IActionResult> GetByAciklamaAsync([FromQuery] string Aciklama)
        {
            var response = await _IEuroSwiftBs.GetByAciklamaAsync(Aciklama);
            return SendResponse(response);
        }

        [HttpPost]
        public async Task<IActionResult> SaveNewEuroSwift([FromBody] EuroSwiftPostDto dto)
        {
            var response = await _IEuroSwiftBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.EuroSwiftID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateEuroSwift([FromBody] EuroSwiftPutDto dto)
        {
            var response = await _IEuroSwiftBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEuroSwift([FromRoute] int id)
        {
            var response = await _IEuroSwiftBs.DeleteAsync(id);
            return SendResponse(response);
        }

    }
}
