using Banka.Business.Interfaces;
using Banka.Model.Dtos.SanalKart;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/sanalkart")]
    [ApiController]
    public class SanalKartController : BaseController
    {
        private readonly ISanalKartBs _ISanalKartBs;
        public SanalKartController(ISanalKartBs SanalKart)
        {
            _ISanalKartBs = SanalKart;
        }


        [HttpGet]
        public async Task<IActionResult> GetSanalKartAsync()
        {
            var response = await _ISanalKartBs.GetSanalKartAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _ISanalKartBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByBagliKrediKartIDAsync")]
        public async Task<IActionResult> GetByBagliKrediKartIDAsync([FromQuery] int BagliKrediKartID)
        {
            var response = await _ISanalKartBs.GetByBagliKrediKartIDAsync(BagliKrediKartID);
            return SendResponse(response);
        }
        [HttpGet("GetByKartNoAsync")]
        public async Task<IActionResult> GetByKartNoAsync([FromQuery] string KartNo)
        {
            var response = await _ISanalKartBs.GetByKartNoAsync(KartNo);
            return SendResponse(response);
        }
        [HttpGet("GetByKartKullanımAyAsync")]
        public async Task<IActionResult> GetByKartKullanımAyAsync([FromQuery] int KartKullanımAy)
        {
            var response = await _ISanalKartBs.GetByKartKullanımAyAsync(KartKullanımAy);
            return SendResponse(response);
        }
        [HttpGet("GetByKartKullanumYılAsync")]
        public async Task<IActionResult> GetByKartKullanumYılAsync([FromQuery] int KartKullanumYıl)
        {
            var response = await _ISanalKartBs.GetByKartKullanumYılAsync(KartKullanumYıl);
            return SendResponse(response);
        }
        [HttpGet("GetByKartCVCNoAsync")]
        public async Task<IActionResult> GetByKartCVCNoAsync([FromQuery] int KartCVCNo)
        {
            var response = await _ISanalKartBs.GetByKartCVCNoAsync(KartCVCNo);
            return SendResponse(response);
        }
        [HttpGet("GetByKartSahipAdAsync")]
        public async Task<IActionResult> GetByKartSahipAdAsync([FromQuery] string KartSahipAd)
        {
            var response = await _ISanalKartBs.GetByKartSahipAdAsync(KartSahipAd);
            return SendResponse(response);
        }
        [HttpGet("GetByKartSahipSoyadAsync")]
        public async Task<IActionResult> GetByKartSahipSoyadAsync([FromQuery] string KartSahipSoyad)
        {
            var response = await _ISanalKartBs.GetByKartSahipSoyadAsync(KartSahipSoyad);
            return SendResponse(response);
        }
        [HttpGet("GetByKartTeknolojisiAsync")]
        public async Task<IActionResult> GetByKartTeknolojisiAsync([FromQuery] string KartTeknolojisi)
        {
            var response = await _ISanalKartBs.GetByKartTeknolojisiAsync(KartTeknolojisi);
            return SendResponse(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _ISanalKartBs.GetByIdAsync(id);
            return SendResponse(response);
        }



        [HttpPost]
        public async Task<IActionResult> SaveNewSanalKart([FromBody] SanalKartPostDto dto)
        {
            var response = await _ISanalKartBs.InsertAsync(dto);
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
        public async Task<IActionResult> UpdateSanalKart([FromBody] SanalKartPutDto dto)
        {
            var response = await _ISanalKartBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSanalKart([FromRoute] int id)
        {
            var response = await _ISanalKartBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
