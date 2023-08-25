using Banka.Business.Interfaces;
using Banka.Model.Dtos.VadeliTLHesap;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/vadelitlhesap")]
    [ApiController]
    public class VadeliTLHesapController : BaseController
    {
        private readonly IVadeliTLHesapBs _IVadeliTLHesapBs;
        public VadeliTLHesapController(IVadeliTLHesapBs VadeliTLHesap)
        {
            _IVadeliTLHesapBs = VadeliTLHesap;
        }


        [HttpGet]
        public async Task<IActionResult> GetVadeliTLHesapAsync()
        {
            var response = await _IVadeliTLHesapBs.GetVadeliTLHesapAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _IVadeliTLHesapBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByVarlıkAsync")]
        public async Task<IActionResult> GetByVarlıkAsync([FromQuery] decimal Varlık)
        {
            var response = await _IVadeliTLHesapBs.GetByVarlıkAsync(Varlık);
            return SendResponse(response);
        }
        [HttpGet("GetByVadeBasTarihiAsync")]
        public async Task<IActionResult> GetByVadeBasTarihiAsync([FromQuery] DateTime VadeBasTarihi)
        {
            var response = await _IVadeliTLHesapBs.GetByVadeBasTarihiAsync(VadeBasTarihi);
            return SendResponse(response);
        }
        [HttpGet("GetByVadeBitisTarihiAsync")]
        public async Task<IActionResult> GetByVadeBitisTarihiAsync([FromQuery] DateTime VadeBitisTarihi)
        {
            var response = await _IVadeliTLHesapBs.GetByVadeBitisTarihiAsync(VadeBitisTarihi);
            return SendResponse(response);
        }
        [HttpGet("GetByVadeliFaizoranAsync")]
        public async Task<IActionResult> GetByVadeliFaizoranAsync([FromQuery] int VadeliFaizoran)
        {
            var response = await _IVadeliTLHesapBs.GetByVadeliFaizoranAsync(VadeliFaizoran);
            return SendResponse(response);
        }
        [HttpGet("GetByVadeSonuMiktarAsync")]
        public async Task<IActionResult> GetByVadeSonuMiktarAsync([FromQuery] decimal VadeSonuMiktar)
        {
            var response = await _IVadeliTLHesapBs.GetByVadeSonuMiktarAsync(VadeSonuMiktar);
            return SendResponse(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IVadeliTLHesapBs.GetByIdAsync(id);
            return SendResponse(response);
        }



        [HttpPost]
        public async Task<IActionResult> SaveNewVadeliTLHesap([FromBody] VadeliTLHesapPostDto dto)
        {
            var response = await _IVadeliTLHesapBs.InsertAsync(dto);
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
        public async Task<IActionResult> UpdateVadeliTLHesap([FromBody] VadeliTLHesapPutDto dto)
        {
            var response = await _IVadeliTLHesapBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVadeliTLHesap([FromRoute] int id)
        {
            var response = await _IVadeliTLHesapBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
