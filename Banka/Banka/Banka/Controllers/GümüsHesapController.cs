using Banka.Business.Interfaces;
using Banka.Model.Dtos.Faturaode;
using Banka.Model.Dtos.GümüsHesap;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/gümüshesap")]
    [ApiController]
    public class GümüsHesapController : BaseController
    {
        private readonly IGümüsHesapBs _IGümüsHesapBs;
        public GümüsHesapController(IGümüsHesapBs GümüsHesap)
        {
            _IGümüsHesapBs = GümüsHesap;
        }


        [HttpGet]
        public async Task<IActionResult> GetGümüsHesapAsync()
        {
            var response = await _IGümüsHesapBs.GetGümüsHesapAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _IGümüsHesapBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByGümüsVarlikGramAsync")]
        public async Task<IActionResult> GetByGümüsVarlikGramAsync([FromQuery] decimal GümüsVarlikGram)
        {
            var response = await _IGümüsHesapBs.GetByGümüsVarlikGramAsync(GümüsVarlikGram);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapTarihAsync")]
        public async Task<IActionResult> GetByHesapTarihAsync([FromQuery] DateTime HesapTarih)
        {
            var response = await _IGümüsHesapBs.GetByHesapTarihAsync(HesapTarih);
            return SendResponse(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IGümüsHesapBs.GetByIdAsync(id);
            return SendResponse(response);
        }

       

        [HttpPost]
        public async Task<IActionResult> SaveNewGümüsHesap([FromBody] GümüsHesapPostDto dto)
        {
            var response = await _IGümüsHesapBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.GümüsHesapID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateGümüsHesap([FromBody] GümüsHesapPutDto dto)
        {
            var response = await _IGümüsHesapBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGümüsHesap([FromRoute] int id)
        {
            var response = await _IGümüsHesapBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
