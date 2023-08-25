using Banka.Business.Interfaces;
using Banka.Model.Dtos.BankaKartı;
using Banka.Model.Dtos.DolarHesap;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/dolarhesap")]
    [ApiController]
    public class DolarHesapController : BaseController
    {
        private readonly IDolarHesapBs _IDolarHesapBs;
        public DolarHesapController(IDolarHesapBs DolarHesap)
        {
            _IDolarHesapBs = DolarHesap;
        }


        [HttpGet]
        public async Task<IActionResult> GetDolarHesap()
        {
            var response = await _IDolarHesapBs.GetDolarHesapAsync();
            return SendResponse(response);
        }


        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _IDolarHesapBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }


        [HttpGet("GetByDolarVarlikAsync")]
        public async Task<IActionResult> GetByDolarVarlikAsync([FromQuery] decimal DolarVarlik)
        {
            var response = await _IDolarHesapBs.GetByDolarVarlikAsync(DolarVarlik);
            return SendResponse(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IDolarHesapBs.GetByIdAsync(id);
            return SendResponse(response);
        }

        [HttpGet("GetByHesapTarihiAsync")]
        public async Task<IActionResult> GetByHesapTarihiAsync([FromQuery] DateTime HesapTarihi)
        {
            var response = await _IDolarHesapBs.GetByHesapTarihiAsync(HesapTarihi);
            return SendResponse(response);
        }


        [HttpGet("GetByHesapIbanAsync")]
        public async Task<IActionResult> GetByHesapAsync([FromQuery] string HesapIban)
        {
            var response = await _IDolarHesapBs.GetByHesapIbanAsync(HesapIban);
            return SendResponse(response);
        }
     
        [HttpPost]
        public async Task<IActionResult> SaveNewDolarHesap([FromBody] DolarHesapPostDto dto)
        {
            var response = await _IDolarHesapBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.DolarHesapID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateDolarHesap([FromBody] DolarHesapPutDto dto)
        {
            var response = await _IDolarHesapBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBankaBilgi([FromRoute] int id)
        {
            var response = await _IDolarHesapBs.DeleteAsync(id);
            return SendResponse(response);
        }

    }
}
