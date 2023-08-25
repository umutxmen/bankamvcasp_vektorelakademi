using Banka.Business.Interfaces;
using Banka.Model.Dtos.SterlinHesap;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/sterlinhesap")]
    [ApiController]
    public class SterlinHesapController : BaseController
    {
        private readonly ISterlinHesapBs _ISterlinHesapBs;
        public SterlinHesapController(ISterlinHesapBs SterlinHesap)
        {
            _ISterlinHesapBs = SterlinHesap;
        }


        [HttpGet]
        public async Task<IActionResult> GetSterlinHesapAsync()
        {
            var response = await _ISterlinHesapBs.GetSterlinHesapAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _ISterlinHesapBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetBySterlinVarlikAsync")]
        public async Task<IActionResult> GetBySterlinVarlikAsync([FromQuery] decimal SterlinVarlik)
        {
            var response = await _ISterlinHesapBs.GetBySterlinVarlikAsync(SterlinVarlik);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapTarihAsync")]
        public async Task<IActionResult> GetByHesapTarihAsync([FromQuery] DateTime HesapTarih)
        {
            var response = await _ISterlinHesapBs.GetByHesapTarihAsync(HesapTarih);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapIbanAsync")]
        public async Task<IActionResult> GetByHesapIbanAsync([FromQuery] string HesapIban)
        {
            var response = await _ISterlinHesapBs.GetByHesapIbanAsync(HesapIban);
            return SendResponse(response);
        }
     

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _ISterlinHesapBs.GetByIdAsync(id);
            return SendResponse(response);
        }



        [HttpPost]
        public async Task<IActionResult> SaveNewSterlinHesap([FromBody] SterlinHesapPostDto dto)
        {
            var response = await _ISterlinHesapBs.InsertAsync(dto);
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
        public async Task<IActionResult> UpdateSterlinHesap([FromBody] SterlinHesapPutDto dto)
        {
            var response = await _ISterlinHesapBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSterlinHesap([FromRoute] int id)
        {
            var response = await _ISterlinHesapBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
