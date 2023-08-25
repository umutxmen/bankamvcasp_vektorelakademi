using Banka.Business.Interfaces;
using Banka.Model.Dtos.MusteriData;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/musteridata")]
    [ApiController]
    public class MusteriDataController : BaseController
    {
        private readonly IMusteriDataBs _IMusteriDataBs;
        public MusteriDataController(IMusteriDataBs MusteriData)
        {
            _IMusteriDataBs = MusteriData;
        }

        #region SWAGGER DOC
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<List<MusteriDataGetDto>>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpGet]
        public async Task<IActionResult> GetMusteriData()
        {
            var response = await _IMusteriDataBs.GetMusteriDataAsync("MusteriVarlik");
            return SendResponse(response);
        }


        [HttpGet("ad")]
        public async Task<IActionResult> GetByMusteriADAsync([FromQuery] string MusteriAD)
        {
            var response = await _IMusteriDataBs.GetByMusteriADAsync(MusteriAD);
            return SendResponse(response);
        }
        [HttpGet("soyad")]
        public async Task<IActionResult> GetByMusteriSoYADAsync([FromQuery] string MusteriSoYAD)
        {
            var response = await _IMusteriDataBs.GetByMusteriSoYADAsync(MusteriSoYAD);
            return SendResponse(response);
        }
        [HttpGet("GetByMusteriTCAsync")]
        public async Task<IActionResult> GetByMusteriTCAsync([FromQuery] string MusteriTC)
        {
            var response = await _IMusteriDataBs.GetByMusteriTCAsync(MusteriTC);
            return SendResponse(response);
        }
        [HttpGet("GetByMusteriTELAsync")]
        public async Task<IActionResult> GetByMusteriTELAsync([FromQuery] string MusteriTEL)
        {
            var response = await _IMusteriDataBs.GetByMusteriTELAsync(MusteriTEL);
            return SendResponse(response);
        }
        [HttpGet("GetByMusteriMeslekAsync")]
        public async Task<IActionResult> GetByMusteriMeslekAsync([FromQuery] string MusteriMeslek)
        {
            var response = await _IMusteriDataBs.GetByMusteriMeslekAsync(MusteriMeslek);
            return SendResponse(response);
        }
        [HttpGet("GetByMusteriAdresAsync")]
        public async Task<IActionResult> GetByMusteriAdresAsync([FromQuery] string MusteriAdres)
        {
            var response = await _IMusteriDataBs.GetByMusteriAdresAsync(MusteriAdres);
            return SendResponse(response);
        }
        [HttpGet("GetByMusteriEmailAsync")]
        public async Task<IActionResult> GetByMusteriEmailAsync([FromQuery] string MusteriEmail)
        {
            var response = await _IMusteriDataBs.GetByMusteriEmailAsync(MusteriEmail);
            return SendResponse(response);
        }
        [HttpGet("GetByMusteriAnneliksoyadAsync")]
        public async Task<IActionResult> GetByMusteriAnneliksoyadAsync([FromQuery] string MusteriAnneliksoyad)
        {
            var response = await _IMusteriDataBs.GetByMusteriAnneliksoyadAsync(MusteriAnneliksoyad);
            return SendResponse(response);
        }
        //[HttpGet("GetByMusteriVarlikIDAsync")]
      //  public async Task<IActionResult> GetByMusteriVarlikIDAsync([FromQuery] int MusteriVarlikID)
       // {
       //     var response = await _IMusteriDataBs.GetByMusteriVarlikIDAsync(MusteriVarlikID);
        //    return SendResponse(response);
       // }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IMusteriDataBs.GetMusteriDataByIdAsync(id, "MusteriVarlik");
            return SendResponse(response);
        }



        [HttpPost]
        public async Task<IActionResult> SaveNewMusteriData([FromBody] MusteriDataPostDto dto)
        {
            var response = await _IMusteriDataBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.MusteriDataID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateMusteriData([FromBody] MusteriDataPutDto dto)
        {
            var response = await _IMusteriDataBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusteriData([FromRoute] int id)
        {
            var response = await _IMusteriDataBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
