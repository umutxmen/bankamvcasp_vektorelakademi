using Banka.Business.Interfaces;
using Banka.Model.Dtos.VadesizTLHesap;
using Banka.Model.Dtos.VergiBorcuode;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/vergiborcuode")]
    [ApiController]
    public class VergiBorcuodeController : BaseController
    {
        private readonly IVergiBorcuOdeBs _IVergiBorcuOdeBs;
        public VergiBorcuodeController(IVergiBorcuOdeBs VergiBorcuOde)
        {
            _IVergiBorcuOdeBs = VergiBorcuOde;
        }


        [HttpGet]
        public async Task<IActionResult> GetVergiBorcuodeAsync()
        {
            var response = await _IVergiBorcuOdeBs.GetVergiBorcuOdeAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _IVergiBorcuOdeBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByverginoAsync")]
        public async Task<IActionResult> GetByverginoAsync([FromQuery] string vergino)
        {
            var response = await _IVergiBorcuOdeBs.GetByverginoAsync(vergino);
            return SendResponse(response);
        }
        [HttpGet("GetByMusteriTCNoAsync")]
        public async Task<IActionResult> GetByMusteriTCNoAsync([FromQuery] string MusteriTCNo)
        {
            var response = await _IVergiBorcuOdeBs.GetByMusteriTCNoAsync(MusteriTCNo);
            return SendResponse(response);
        }
        [HttpGet("GetByGondericiIBANAsync")]
        public async Task<IActionResult> GetByGondericiIBANAsync([FromQuery] string GondericiIBAN)
        {
            var response = await _IVergiBorcuOdeBs.GetByGondericiIBANAsync(GondericiIBAN);
            return SendResponse(response);
        }
        [HttpGet("GetByGondericiADAsync")]
        public async Task<IActionResult> GetByGondericiADAsync([FromQuery] string GondericiAD)
        {
            var response = await _IVergiBorcuOdeBs.GetByGondericiADAsync(GondericiAD);
            return SendResponse(response);
        }
        [HttpGet("GetByGondericiSoyadAsync")]
        public async Task<IActionResult> GetByGondericiSoyadAsync([FromQuery] string GondericiSoyad)
        {
            var response = await _IVergiBorcuOdeBs.GetByGondericiSoyadAsync(GondericiSoyad);
            return SendResponse(response);
        }
        [HttpGet("GetByAciklamaAsync")]
        public async Task<IActionResult> GetByAciklamaAsync([FromQuery] string Aciklama)
        {
            var response = await _IVergiBorcuOdeBs.GetByAciklamaAsync(Aciklama);
            return SendResponse(response);
        }
        [HttpGet("GetByOdemeTarihAsync")]
        public async Task<IActionResult> GetByOdemeTarihAsync([FromQuery] DateTime OdemeTarih)
        {
            var response = await _IVergiBorcuOdeBs.GetByOdemeTarihAsync(OdemeTarih);
            return SendResponse(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IVergiBorcuOdeBs.GetByIdAsync(id);
            return SendResponse(response);
        }



        [HttpPost]
        public async Task<IActionResult> SaveNewVergiBorcuode([FromBody] VergiBorcuOdePostDto dto)
        {
            var response = await _IVergiBorcuOdeBs.InsertAsync(dto);
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
        public async Task<IActionResult> UpdateVergiBorcuode([FromBody] VergiBorcuOdePutDto dto)
        {
            var response = await _IVergiBorcuOdeBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVergiBorcuode([FromRoute] int id)
        {
            var response = await _IVergiBorcuOdeBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
