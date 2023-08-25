using Banka.Business.Implementations;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.DolarHesap;
using Banka.Model.Dtos.DolarSwift;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/dolarswift")]
    [ApiController]
    public class DolarSwiftController : BaseController
    {
        private readonly IDolarSwiftBs _IDolarSwiftBs;
        public DolarSwiftController(IDolarSwiftBs DolarSwift)
        {
            _IDolarSwiftBs = DolarSwift;
        }


        [HttpGet]
        public async Task<IActionResult> GetDolarSwiftAsync()
        {
            var response = await _IDolarSwiftBs.GetDolarSwiftAsync();
            return SendResponse(response);
        }


        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _IDolarSwiftBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }


        [HttpGet("GetByGidenHesapIbanAsync")]
        public async Task<IActionResult> GetByGidenHesapIbanAsync([FromQuery] string GidenHesapIban)
        {
            var response = await _IDolarSwiftBs.GetByGidenHesapIbanAsync(GidenHesapIban);
            return SendResponse(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IDolarSwiftBs.GetByIdAsync(id);
            return SendResponse(response);
        }

        [HttpGet("GetByAlanHesapIbanAsync")]
        public async Task<IActionResult> GetByAlanHesapIbanAsync([FromQuery] string AlanHesapIban)
        {
            var response = await _IDolarSwiftBs.GetByAlanHesapIbanAsync(AlanHesapIban);
            return SendResponse(response);
        }


        [HttpGet("GetBySwiftTarihiAsync")]
        public async Task<IActionResult> GetBySwiftTarihiAsync([FromQuery] DateTime SwiftTarihi)
        {
            var response = await _IDolarSwiftBs.GetBySwiftTarihiAsync(SwiftTarihi);
            return SendResponse(response);
        }
        [HttpGet("GetByMiktarAsync")]
        public async Task<IActionResult> GetByMiktarAsync([FromQuery] decimal Miktar)
        {
            var response = await _IDolarSwiftBs.GetByMiktarAsync(Miktar);
            return SendResponse(response);
        }
        [HttpGet("GetBySwiftKoduAsync")]
        public async Task<IActionResult> GetBySwiftKoduAsync([FromQuery] int SwiftKodu)
        {
            var response = await _IDolarSwiftBs.GetBySwiftKoduAsync(SwiftKodu);
            return SendResponse(response);
        }

        [HttpGet("GetByAciklamaAsync")]
        public async Task<IActionResult> GetByAciklamaAsync([FromQuery] string Aciklama)
        {
            var response = await _IDolarSwiftBs.GetByAciklamaAsync(Aciklama);
            return SendResponse(response);
        }

        [HttpPost]
        public async Task<IActionResult> SaveNewDolarSwift([FromBody] DolarSwiftPostDto dto)
        {
            var response = await _IDolarSwiftBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.DolarSwiftID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateDolarSwift([FromBody] DolarSwiftPutDto dto)
        {
            var response = await _IDolarSwiftBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDolarSwift([FromRoute] int id)
        {
            var response = await _IDolarSwiftBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
