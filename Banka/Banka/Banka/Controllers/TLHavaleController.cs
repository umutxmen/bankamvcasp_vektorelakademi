using Banka.Business.Interfaces;
using Banka.Model.Dtos.TLHavale;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/tlhavale")]
    [ApiController]
    public class TLHavaleController : BaseController
    {
        private readonly ITLHavaleBs _ITLHavaleBs;
        public TLHavaleController(ITLHavaleBs TLHavale)
        {
            _ITLHavaleBs = TLHavale;
        }


        [HttpGet]
        public async Task<IActionResult> GetTLHavaleAsync()
        {
            var response = await _ITLHavaleBs.GetTLHavaleAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _ITLHavaleBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByGidenHesapIbanAsync")]
        public async Task<IActionResult> GetByGidenHesapIbanAsync([FromQuery] string GidenHesapIban)
        {
            var response = await _ITLHavaleBs.GetByGidenHesapIbanAsync(GidenHesapIban);
            return SendResponse(response);
        }
        [HttpGet("GetByAlanHesapIbanAsync")]
        public async Task<IActionResult> GetByAlanHesapIbanAsync([FromQuery] string AlanHesapIban)
        {
            var response = await _ITLHavaleBs.GetByAlanHesapIbanAsync(AlanHesapIban);
            return SendResponse(response);
        }
        [HttpGet("GetByİslemTarihAsync")]
        public async Task<IActionResult> GetByİslemTarihAsync([FromQuery] DateTime İslemTarih)
        {
            var response = await _ITLHavaleBs.GetByİslemTarihAsync(İslemTarih);
            return SendResponse(response);
        }
        [HttpGet("GetByMiktarAsync")]
        public async Task<IActionResult> GetByMiktarAsync([FromQuery] decimal Miktar)
        {
            var response = await _ITLHavaleBs.GetByMiktarAsync(Miktar);
            return SendResponse(response);
        }
        [HttpGet("GetByAciklamaAsync")]
        public async Task<IActionResult> GetByAciklamaAsync([FromQuery] string Aciklama)
        {
            var response = await _ITLHavaleBs.GetByAciklamaAsync(Aciklama);
            return SendResponse(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _ITLHavaleBs.GetByIdAsync(id);
            return SendResponse(response);
        }



        [HttpPost]
        public async Task<IActionResult> SaveNewTLHavale([FromBody] TLHavalePostDto dto)
        {
            var response = await _ITLHavaleBs.InsertAsync(dto);
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
        public async Task<IActionResult> UpdateTLHavale([FromBody] TLHavalePutDto dto)
        {
            var response = await _ITLHavaleBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTLHavale([FromRoute] int id)
        {
            var response = await _ITLHavaleBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
