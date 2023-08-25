using Banka.Business.Interfaces;
using Banka.Model.Dtos.KurKorumalıHesap;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/kurkorumalıhesap")]
    [ApiController]
    public class KurKorumalıHesapController : BaseController
    {
        private readonly IKurKorumalıHesapBs _IKurKorumalıHesapBs;
        public KurKorumalıHesapController(IKurKorumalıHesapBs KurKorumalıHesap)
        {
            _IKurKorumalıHesapBs = KurKorumalıHesap;
        }


        [HttpGet]
        public async Task<IActionResult> GetKurKorumalıHesapAsync()
        {
            var response = await _IKurKorumalıHesapBs.GetKurKorumalıHesapAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _IKurKorumalıHesapBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByVarlikTLAsync")]
        public async Task<IActionResult> GetByVarlikTLAsync([FromQuery] decimal VarlikTL)
        {
            var response = await _IKurKorumalıHesapBs.GetByVarlikTLAsync(VarlikTL);
            return SendResponse(response);
        }
        [HttpGet("GetByDovizIDAsync")]
        public async Task<IActionResult> GetByDovizIDAsync([FromQuery] int DovizID)
        {
            var response = await _IKurKorumalıHesapBs.GetByDovizIDAsync(DovizID);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapAcimTarihiAsync")]
        public async Task<IActionResult> GetByHesapAcimTarihiAsync([FromQuery] DateTime HesapAcimTarihi)
        {
            var response = await _IKurKorumalıHesapBs.GetByHesapAcimTarihiAsync(HesapAcimTarihi);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapAcimKuruAsync")]
        public async Task<IActionResult> GetByHesapAcimKuruAsync([FromQuery] decimal HesapAcimKuru)
        {
            var response = await _IKurKorumalıHesapBs.GetByHesapAcimKuruAsync(HesapAcimKuru);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapKapanmaTarihiAsync")]
        public async Task<IActionResult> GetByHesapKapanmaTarihiAsync([FromQuery] DateTime HesapKapanmaTarihi)
        {
            var response = await _IKurKorumalıHesapBs.GetByHesapKapanmaTarihiAsync(HesapKapanmaTarihi);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapKapanmaKuruAsync")]
        public async Task<IActionResult> GetByHesapKapanmaKuruAsync([FromQuery] decimal HesapKapanmaKuru)
        {
            var response = await _IKurKorumalıHesapBs.GetByHesapKapanmaKuruAsync(HesapKapanmaKuru);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapFaizoranAsync")]
        public async Task<IActionResult> GetByHesapFaizoranAsync([FromQuery] int HesapFaizoran)
        {
            var response = await _IKurKorumalıHesapBs.GetByHesapFaizoranAsync(HesapFaizoran);
            return SendResponse(response);
        }
  

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IKurKorumalıHesapBs.GetByIdAsync(id);
            return SendResponse(response);
        }



        [HttpPost]
        public async Task<IActionResult> SaveNewKurKorumalıHesap([FromBody] KurKorumalıHesapPostDto dto)
        {
            var response = await _IKurKorumalıHesapBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.KurKorumaliHesapId }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateKurKorumalıHesap([FromBody] KurKorumalıHesapPutDto dto)
        {
            var response = await _IKurKorumalıHesapBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKurKorumalıHesap([FromRoute] int id)
        {
            var response = await _IKurKorumalıHesapBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
