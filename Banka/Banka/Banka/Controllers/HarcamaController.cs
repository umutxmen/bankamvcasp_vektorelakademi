using Banka.Business.Interfaces;
using Banka.Model.Dtos.GümüsHesap;
using Banka.Model.Dtos.Harcama;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/harcama")]
    [ApiController]
    public class HarcamaController : BaseController
    {
        private readonly IHarcamaBs _IHarcamaBs;
        public HarcamaController(IHarcamaBs Harcama)
        {
            _IHarcamaBs = Harcama;
        }


        [HttpGet]
        public async Task<IActionResult> GetHarcamaAsync()
        {
            var response = await _IHarcamaBs.GetHarcamaAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _IHarcamaBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByHarcananKartIDAsync")]
        public async Task<IActionResult> GetByHarcananKartIDAsync([FromQuery] int HarcananKartID)
        {
            var response = await _IHarcamaBs.GetByHarcananKartIDAsync(HarcananKartID);
            return SendResponse(response);
        }
        [HttpGet("GetByHarcananMiktarAsync")]
        public async Task<IActionResult> GetByHarcananMiktarAsync([FromQuery] decimal HarcananMiktar)
        {
            var response = await _IHarcamaBs.GetByHarcananMiktarAsync(HarcananMiktar);
            return SendResponse(response);
        }
        [HttpGet("GetByTaksitMiktarıAsync")]
        public async Task<IActionResult> GetByTaksitMiktarıAsync([FromQuery] int TaksitMiktarı)
        {
            var response = await _IHarcamaBs.GetByTaksitMiktarıAsync(TaksitMiktarı);
            return SendResponse(response);
        }
        [HttpGet("GetByHarcamaTarihiAsync")]
        public async Task<IActionResult> GetByHarcamaTarihiAsync([FromQuery] DateTime HarcamaTarihi)
        {
            var response = await _IHarcamaBs.GetByHarcamaTarihiAsync(HarcamaTarihi);
            return SendResponse(response);
        }
        [HttpGet("GetBySatıcıKoduAsync")]
        public async Task<IActionResult> GetBySatıcıKoduAsync([FromQuery] string SatıcıKodu)
        {
            var response = await _IHarcamaBs.GetBySatıcıKoduAsync(SatıcıKodu);
            return SendResponse(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IHarcamaBs.GetHarcamaByIdAsync(id);
            return SendResponse(response);
        }



        [HttpPost]
        public async Task<IActionResult> SaveNewHarcama([FromBody] HarcamaPostDto dto)
        {
            var response = await _IHarcamaBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.HarcamaID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateHarcama([FromBody] HarcamaPutDto dto)
        {
            var response = await _IHarcamaBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHarcama([FromRoute] int id)
        {
            var response = await _IHarcamaBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
