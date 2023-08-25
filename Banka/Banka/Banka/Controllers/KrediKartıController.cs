using Banka.Business.Interfaces;
using Banka.Model.Dtos.KrediKartı;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KrediKartıController : BaseController
    {

        private readonly IKrediKartıBs _IKrediKartıBs;
        public KrediKartıController(IKrediKartıBs KrediKartı)
        {
            _IKrediKartıBs = KrediKartı;
        }


        [HttpGet]
        public async Task<IActionResult> GetKrediKartıAsync()
        {
            var response = await _IKrediKartıBs.GetKrediKartıAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _IKrediKartıBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByBaglıİbanAsync")]
        public async Task<IActionResult> GetByBaglıİbanAsync([FromQuery] string Baglıİban)
        {
            var response = await _IKrediKartıBs.GetByBaglıİbanAsync(Baglıİban);
            return SendResponse(response);
        }
        [HttpGet("GetByKartNoAsync")]
        public async Task<IActionResult> GetByKartNoAsync([FromQuery] string KartNo)
        {
            var response = await _IKrediKartıBs.GetByKartNoAsync(KartNo);
            return SendResponse(response);
        }
        [HttpGet("GetByKartkullanımAyAsync")]
        public async Task<IActionResult> GetByKartkullanımAyAsync([FromQuery] int KartkullanımAy)
        {
            var response = await _IKrediKartıBs.GetByKartkullanımAyAsync(KartkullanımAy);
            return SendResponse(response);
        }
        [HttpGet("GetByKartkullanımYılAsync")]
        public async Task<IActionResult> GetByKartkullanımYılAsync([FromQuery] int KartkullanımYıl)
        {
            var response = await _IKrediKartıBs.GetByKartkullanımYılAsync(KartkullanımYıl);
            return SendResponse(response);
        }
        [HttpGet("GetByKartCVCNoAsync")]
        public async Task<IActionResult> GetByKartCVCNoAsync([FromQuery] int KartCVCNo)
        {
            var response = await _IKrediKartıBs.GetByKartCVCNoAsync(KartCVCNo);
            return SendResponse(response);
        }
        [HttpGet("GetByKartSahipAdAsync")]
        public async Task<IActionResult> GetByKartSahipAdAsync([FromQuery] string KartSahipAd)
        {
            var response = await _IKrediKartıBs.GetByKartSahipAdAsync(KartSahipAd);
            return SendResponse(response);
        }
        [HttpGet("GetByKartSahipSoyadAsync")]
        public async Task<IActionResult> GetByKartSahipSoyadAsync([FromQuery] string KartSahipSoyad)
        {
            var response = await _IKrediKartıBs.GetByKartSahipSoyadAsync(KartSahipSoyad);
            return SendResponse(response);
        }
        [HttpGet("GetByKartTeknolojisiAsync")]
        public async Task<IActionResult> GetByKartTeknolojisiAsync([FromQuery] string KartTeknolojisi)
        {
            var response = await _IKrediKartıBs.GetByKartTeknolojisiAsync(KartTeknolojisi);
            return SendResponse(response);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IKrediKartıBs.GetByIdAsync(id);
            return SendResponse(response);
        }



        [HttpPost]
        public async Task<IActionResult> SaveNewKrediKartı([FromBody] KrediKartıPostDto dto)
        {
            var response = await _IKrediKartıBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.KrediKartıID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateKrediKartı([FromBody] KrediKartıPutDto dto)
        {
            var response = await _IKrediKartıBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKrediKartı([FromRoute] int id)
        {
            var response = await _IKrediKartıBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
