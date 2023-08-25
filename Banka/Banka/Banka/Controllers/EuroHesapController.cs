using Banka.Business.Interfaces;
using Banka.Model.Dtos.EFT;
using Banka.Model.Dtos.EuroHesap;
using Banka.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/eurohesap")]
    [ApiController]
    public class EuroHesapController : BaseController
    {
        private readonly IEuroHesapBs _IEuroHesapBs;
        public EuroHesapController(IEuroHesapBs EuroHesap)
        {
            _IEuroHesapBs = EuroHesap;
        }


        [HttpGet]
        public async Task<IActionResult> GetEuroSwiftAsync()
        {
            var response = await _IEuroHesapBs.GetEuroHesapAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _IEuroHesapBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByEuroVarlikAsync")]
        public async Task<IActionResult> GetByEuroVarlikAsync([FromQuery] decimal EuroVarlik)
        {
            var response = await _IEuroHesapBs.GetByEuroVarlikAsync(EuroVarlik);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapTarihAsync")]
        public async Task<IActionResult> GetByHesapTarihAsync([FromQuery] DateTime HesapTarih)
        {
            var response = await _IEuroHesapBs.GetByHesapTarihAsync(HesapTarih);
            return SendResponse(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IEuroHesapBs.GetByIdAsync(id);
            return SendResponse(response);
        }

        [HttpGet("GetByHesapIbanAsync")]
        public async Task<IActionResult> GetByHesapIbanAsync([FromQuery] string HesapIban)
        {
            var response = await _IEuroHesapBs.GetByHesapIbanAsync(HesapIban);
            return SendResponse(response);
        }


        

        [HttpPost]
        public async Task<IActionResult> SaveNeEuroHesap([FromBody] EuroHesapPostDto dto)
        {
            var response = await _IEuroHesapBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.EuroHesapID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateEFT([FromBody] EuroHesapPutDto dto)
        {
            var response = await _IEuroHesapBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEFT([FromRoute] int id)
        {
            var response = await _IEuroHesapBs.DeleteAsync(id);
            return SendResponse(response);
        }

    }
}
