using Banka.Business.Implementations;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.EuroSwift;
using Banka.Model.Dtos.Faturaode;
using Banka.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/faturaode")]
    [ApiController]
    public class FaturaOdeController : BaseController
    {
        private readonly IFaturaOdeBs _IFaturaOdeBs;
        public FaturaOdeController(IFaturaOdeBs Faturaode)
        {
            _IFaturaOdeBs = Faturaode;
        }


        [HttpGet]
        public async Task<IActionResult> GetFaturaOdeAsync()
        {
            var response = await _IFaturaOdeBs.GetFaturaOdeAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _IFaturaOdeBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByfaturanoAsync")]
        public async Task<IActionResult> GetByfaturanoAsync([FromQuery] string faturano)
        {
            var response = await _IFaturaOdeBs.GetByfaturanoAsync(faturano);
            return SendResponse(response);
        }
        [HttpGet("GetByGonderenİbanAsync")]
        public async Task<IActionResult> GetByGonderenİbanAsync([FromQuery] string Gonderenİban)
        {
            var response = await _IFaturaOdeBs.GetByGonderenİbanAsync(Gonderenİban);
            return SendResponse(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IFaturaOdeBs.GetByIdAsync(id);
            return SendResponse(response);
        }

        [HttpGet("GetByodenecekMiktarAsync")]
        public async Task<IActionResult> GetByodenecekMiktarAsync([FromQuery] decimal odenecekMiktar)
        {
            var response = await _IFaturaOdeBs.GetByodenecekMiktarAsync(odenecekMiktar);
            return SendResponse(response);
        }

        [HttpGet("GetByOdemeTarihAsync")]
        public async Task<IActionResult> GetByOdemeTarihAsync([FromQuery] DateTime OdemeTarih)
        {
            var response = await _IFaturaOdeBs.GetByOdemeTarihAsync(OdemeTarih);
            return SendResponse(response);
        }

      

        [HttpGet("GetByAciklamaAsync")]
        public async Task<IActionResult> GetByAciklamaAsync([FromQuery] string Aciklama)
        {
            var response = await _IFaturaOdeBs.GetByAciklamaAsync(Aciklama);
            return SendResponse(response);
        }

        [HttpPost]
        public async Task<IActionResult> SaveNewFaturaode([FromBody] FaturaOdePostDto dto)
        {
            var response = await _IFaturaOdeBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.FaturaYatırİslemID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateFaturaode([FromBody] FaturaOdePutDto dto)
        {
            var response = await _IFaturaOdeBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFaturaOde([FromRoute] int id)
        {
            var response = await _IFaturaOdeBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
