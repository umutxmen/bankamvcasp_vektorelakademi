using Banka.Business.Interfaces;
using Banka.Model.Dtos.Kartlar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/kartlar")]
    [ApiController]
    public class KartlarController : BaseController
    {
        private readonly IKartlarBs _IKartlarBs;
        public KartlarController(IKartlarBs Kartlar)
        {
            _IKartlarBs = Kartlar;
        }


        [HttpGet]
        public async Task<IActionResult> GetKartlarAsync()
        {
            var response = await _IKartlarBs.GetKartlarAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _IKartlarBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByKrediKartıIDAsync")]
        public async Task<IActionResult> GetByKrediKartıIDAsync([FromQuery] int KrediKartıID)
        {
            var response = await _IKartlarBs.GetByKrediKartıIDAsync(KrediKartıID);
            return SendResponse(response);
        }
        [HttpGet("GetByKrediKartı2IDAsync")]
        public async Task<IActionResult> GetByKrediKartı2IDAsync([FromQuery] int KrediKartı2ID)
        {
            var response = await _IKartlarBs.GetByKrediKartı2IDAsync(KrediKartı2ID);
            return SendResponse(response);
        }
        [HttpGet("GetByKrediKartı3IDAsync")]
        public async Task<IActionResult> GetByKrediKartı3IDAsync([FromQuery] int KrediKartı3ID)
        {
            var response = await _IKartlarBs.GetByKrediKartı3IDAsync(KrediKartı3ID);
            return SendResponse(response);
        }
        [HttpGet("GetByBankaKartıIDAsync")]
        public async Task<IActionResult> GetByBankaKartıIDAsync([FromQuery] int BankaKartıID)
        {
            var response = await _IKartlarBs.GetByBankaKartıIDAsync(BankaKartıID);
            return SendResponse(response);
        }
        [HttpGet("GetByBankaKartı2IDAsync")]
        public async Task<IActionResult> GetByBankaKartı2IDAsync([FromQuery] int BankaKartı2ID)
        {
            var response = await _IKartlarBs.GetByBankaKartı2IDAsync(BankaKartı2ID);
            return SendResponse(response);
        }
        [HttpGet("GetByBankaKartı3IDAsync")]
        public async Task<IActionResult> GetByBankaKartı3IDAsync([FromQuery] int BankaKartı3ID)
        {
            var response = await _IKartlarBs.GetByBankaKartı3IDAsync(BankaKartı3ID);
            return SendResponse(response);
        }
        [HttpGet("GetBySanalKartIDAsync")]
        public async Task<IActionResult> GetBySanalKartIDAsync([FromQuery] int SanalKartID)
        {
            var response = await _IKartlarBs.GetBySanalKartIDAsync(SanalKartID);
            return SendResponse(response);
        }
        [HttpGet("GetBySanalKart2IDAsync")]
        public async Task<IActionResult> GetBySanalKart2IDAsync([FromQuery] int SanalKart2ID)
        {
            var response = await _IKartlarBs.GetBySanalKart2IDAsync(SanalKart2ID);
            return SendResponse(response);
        }
        [HttpGet("GetBySanalKart3IDAsync")]
        public async Task<IActionResult> GetBySanalKart3IDAsync([FromQuery] int SanalKart3ID)
        {
            var response = await _IKartlarBs.GetBySanalKart3IDAsync(SanalKart3ID);
            return SendResponse(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IKartlarBs.GetByIDAsync(id);
            return SendResponse(response);
        }



        [HttpPost]
        public async Task<IActionResult> SaveNewKartlar([FromBody] KartlarPostDto dto)
        {
            var response = await _IKartlarBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.KartlarID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateKartlar([FromBody] KartlarPutDto dto)
        {
            var response = await _IKartlarBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKartlar([FromRoute] int id)
        {
            var response = await _IKartlarBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
