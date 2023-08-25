using Banka.Business.Interfaces;
using Banka.Model.Dtos.NakitAvans;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/nakitavans")]
    [ApiController]
    public class NakitAvansController : BaseController
    {
        private readonly INakitAvansBs _INakitAvansBs;
        public NakitAvansController(INakitAvansBs NakitAvans)
        {
            _INakitAvansBs = NakitAvans;
        }


        [HttpGet]
        public async Task<IActionResult> GetNakitAvansAsync()
        {
            var response = await _INakitAvansBs.GetNakitAvansAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _INakitAvansBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByAktarılanİbanAsync")]
        public async Task<IActionResult> GetByAktarılanİbanAsync([FromQuery] int Aktarılanİban)
        {
            var response = await _INakitAvansBs.GetByAktarılanİbanAsync(Aktarılanİban);
            return SendResponse(response);
        }
        [HttpGet("GetBySonOdemeTarihiAsync")]
        public async Task<IActionResult> GetBySonOdemeTarihiAsync([FromQuery] DateTime SonOdemeTarihi)
        {
            var response = await _INakitAvansBs.GetBySonOdemeTarihiAsync(SonOdemeTarihi);
            return SendResponse(response);
        }
        [HttpGet("GetByAvansMiktarıAsync")]
        public async Task<IActionResult> GetByAvansMiktarıAsync([FromQuery] decimal AvansMiktarı)
        {
            var response = await _INakitAvansBs.GetByAvansMiktarıAsync(AvansMiktarı);
            return SendResponse(response);
        }
        [HttpGet("GetByFaizoranıAsync")]
        public async Task<IActionResult> GetByFaizoranıAsync([FromQuery] decimal Faizoranı)
        {
            var response = await _INakitAvansBs.GetByFaizoranıAsync(Faizoranı);
            return SendResponse(response);
        }
        [HttpGet("GetByodenecekMiktarAsync")]
        public async Task<IActionResult> GetByodenecekMiktarAsync([FromQuery] decimal odenecekMiktar)
        {
            var response = await _INakitAvansBs.GetByodenecekMiktarAsync(odenecekMiktar);
            return SendResponse(response);
        }
      

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _INakitAvansBs.GetByIdAsync(id);
            return SendResponse(response);
        }



        [HttpPost]
        public async Task<IActionResult> SaveNewNakitAvans([FromBody] NakitAvansPostDto dto)
        {
            var response = await _INakitAvansBs.InsertAsync(dto);
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
        public async Task<IActionResult> UpdateNakitAvans([FromBody] NakitAvansPutDto dto)
        {
            var response = await _INakitAvansBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNakitAvans([FromRoute] int id)
        {
            var response = await _INakitAvansBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
