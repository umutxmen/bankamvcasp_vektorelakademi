using Banka.Business.Interfaces;
using Banka.Model.Dtos.VadesizTLHesap;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/vadesiztlhesap")]
    [ApiController]
    public class VadesizTLHesapController : BaseController
    {
        private readonly IVadesizTLHesapBs _IVadesizTLHesapBs;
        public VadesizTLHesapController(IVadesizTLHesapBs VadesizTLHesap)
        {
            _IVadesizTLHesapBs = VadesizTLHesap;
        }


        [HttpGet]
        public async Task<IActionResult> GetTLVadesizTLHesapAsync()
        {
            var response = await _IVadesizTLHesapBs.GetTLVadesizTLHesapAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _IVadesizTLHesapBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByHesapTutarAsync")]
        public async Task<IActionResult> GetByHesapTutarAsync([FromQuery] decimal HesapTutar)
        {
            var response = await _IVadesizTLHesapBs.GetByHesapTutarAsync(HesapTutar);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapAcilmaTarihAsync")]
        public async Task<IActionResult> GetByHesapAcilmaTarihAsync([FromQuery] DateTime HesapAcilmaTarih)
        {
            var response = await _IVadesizTLHesapBs.GetByHesapAcilmaTarihAsync(HesapAcilmaTarih);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapIBANAsync")]
        public async Task<IActionResult> GetByHesapIBANAsync([FromQuery] string HesapIBAN)
        {
            var response = await _IVadesizTLHesapBs.GetByHesapIBANAsync(HesapIBAN);
            return SendResponse(response);
        }
      

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IVadesizTLHesapBs.GetByIdAsync(id);
            return SendResponse(response);
        }



        [HttpPost]
        public async Task<IActionResult> SaveNewVadesizTLHesap([FromBody] VadesizTLHesapPostDto dto)
        {
            var response = await _IVadesizTLHesapBs.InsertAsync(dto);
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
        public async Task<IActionResult> UpdateVadesizTLHesap([FromBody] VadesizTLHesapPutDto dto)
        {
            var response = await _IVadesizTLHesapBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVadesizTLHesap([FromRoute] int id)
        {
            var response = await _IVadesizTLHesapBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
