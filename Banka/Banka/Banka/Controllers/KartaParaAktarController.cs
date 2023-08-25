using Banka.Business.Interfaces;
using Banka.Model.Dtos.KartaParaAktar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/kartaparakaktar")]
    [ApiController]
    public class KartaParaAktarController : BaseController
    {
        private readonly IKartaParaAktarBs _IKartaParaAktarBs;
        public KartaParaAktarController(IKartaParaAktarBs KartaParaAktar)
        {
            _IKartaParaAktarBs = KartaParaAktar;
        }


        [HttpGet]
        public async Task<IActionResult> GetKartaParaAktarAsync()
        {
            var response = await _IKartaParaAktarBs.GetKartaParaAktarAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _IKartaParaAktarBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByAktarılacakKartIDAsync")]
        public async Task<IActionResult> GetByAktarılacakKartIDAsync([FromQuery] int AktarılacakKartID)
        {
            var response = await _IKartaParaAktarBs.GetByAktarılacakKartIDAsync(AktarılacakKartID);
            return SendResponse(response);
        }
        [HttpGet("GetByVarlıkHesabıAsync")]
        public async Task<IActionResult> GetByVarlıkHesabıAsync([FromQuery] int VarlıkHesabı)
        {
            var response = await _IKartaParaAktarBs.GetByVarlıkHesabıAsync(VarlıkHesabı);
            return SendResponse(response);
        }
        [HttpGet("GetByMiktarAsync")]
        public async Task<IActionResult> GetByMiktarAsync([FromQuery] decimal Miktar)
        {
            var response = await _IKartaParaAktarBs.GetByMiktarAsync(Miktar);
            return SendResponse(response);
        }
        [HttpGet("GetByİslemTarihiAsync")]
        public async Task<IActionResult> GetByİslemTarihiAsync([FromQuery] DateTime İslemTarihi)
        {
            var response = await _IKartaParaAktarBs.GetByİslemTarihiAsync(İslemTarihi);
            return SendResponse(response);
        }
     

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IKartaParaAktarBs.GetByIdAsync(id);
            return SendResponse(response);
        }



        [HttpPost]
        public async Task<IActionResult> SaveNewKartaParaAktar([FromBody] KartaParaAktarPostDto dto)
        {
            var response = await _IKartaParaAktarBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.KartaParaİslemID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateKartaParaAktar([FromBody] KartaParaAktarPutDto dto)
        {
            var response = await _IKartaParaAktarBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKartaParaAktar([FromRoute] int id)
        {
            var response = await _IKartaParaAktarBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
