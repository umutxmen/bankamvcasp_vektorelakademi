using Banka.Business.Implementations;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.Doviz;
using Banka.Model.Dtos.EFT;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/eft")]
    [ApiController]
    public class EFTController : BaseController
    {
        private readonly IEFTBs _IEFTBs;
        public EFTController(IEFTBs EFT)
        {
            _IEFTBs = EFT;
        }


        [HttpGet]
        public async Task<IActionResult> GetEFTAsync()
        {
            var response = await _IEFTBs.GetEFTAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _IEFTBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByBankaIDAsync")]
        public async Task<IActionResult> GetByBankaIDAsync([FromQuery] int DigerBankaID)
        {
            var response = await _IEFTBs.GetByBankaIDAsync(DigerBankaID);
            return SendResponse(response);
        }
        [HttpGet("GetByDigerBankaIDAsync")]
        public async Task<IActionResult> GetByDigerBankaIDAsync([FromQuery] int DigerBankaID)
        {
            var response = await _IEFTBs.GetByDigerBankaIDAsync(DigerBankaID);
            return SendResponse(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IEFTBs.GetByIdAsync(id);
            return SendResponse(response);
        }

        [HttpGet("GetByGidenIbanAsync")]
        public async Task<IActionResult> GetByGidenIbanAsync([FromQuery] string GidenIban)
        {
            var response = await _IEFTBs.GetByGidenIbanAsync(GidenIban);
            return SendResponse(response);
        }


        [HttpGet("GetByAlanIbanAsync")]
        public async Task<IActionResult> GetByAlanIbanAsync([FromQuery] string AlanIban)
        {
            var response = await _IEFTBs.GetByAlanIbanAsync(AlanIban);
            return SendResponse(response);
        }
        [HttpGet("GetByMiktarAsync")]
        public async Task<IActionResult> GetByMiktarAsync([FromQuery] decimal Miktar)
        {
            var response = await _IEFTBs.GetByMiktarAsync(Miktar);
            return SendResponse(response);
        }
        [HttpGet("GetByİslemTarihiAsync")]
        public async Task<IActionResult> GetByİslemTarihiAsync([FromQuery] DateTime İslemTarihi)
        {
            var response = await _IEFTBs.GetByİslemTarihiAsync(İslemTarihi);
            return SendResponse(response);
        }
        [HttpGet("GetByAciklamaAsync")]
        public async Task<IActionResult> GetByAciklamaAsync([FromQuery] string Aciklama)
        {
            var response = await _IEFTBs.GetByAciklamaAsync(Aciklama);
            return SendResponse(response);
        }


        [HttpPost]
        public async Task<IActionResult> SaveNewEFT([FromBody] EFTPostDto dto)
        {
            var response = await _IEFTBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.EFTID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateEFT([FromBody] EFTPutDto dto)
        {
            var response = await _IEFTBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEFT([FromRoute] int id)
        {
            var response = await _IEFTBs.DeleteAsync(id);
            return SendResponse(response);
        }


    }
}
