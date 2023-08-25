using Banka.Business.Interfaces;
using Banka.Model.Dtos.BankaBilgi;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/bankabilgi")]
    [ApiController]
    public class BankaBilgiController : BaseController
    {
        private readonly IBankaBilgiBs _bankabilgiBS;
        public BankaBilgiController(IBankaBilgiBs bankabilgiBS)
        {
            _bankabilgiBS = bankabilgiBS;
        }

     
        [HttpGet]
        public async Task<IActionResult> GetBankaBilgi()
        {
            var response = await _bankabilgiBS.GetBankaBilgiAsync();
            return SendResponse(response);
        }

   
        [HttpGet("getByBankaSubeNoAsync")]
        public async Task<IActionResult> GetByBankaSubeNoAsync([FromQuery] string BankaSubeNo)
        {
            var response = await _bankabilgiBS.GetByBankaSubeNoAsync(BankaSubeNo);
            return SendResponse(response);
        }

    
        [HttpGet("getByBankaSehirAsync")]
        public async Task<IActionResult> GetByBankaSehirAsync([FromQuery] string BankaSehir)
        {
            var response = await _bankabilgiBS.GetByBankaSehirAsync(BankaSehir);
            return SendResponse(response);
        }

 
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _bankabilgiBS.GetByIdAsync(id);
            return SendResponse(response);
        }

        [HttpGet("getByBankaİlceAsync")]
        public async Task<IActionResult> GetByBankaİlceAsync([FromQuery] string Bankaİlce)
        {
            var response = await _bankabilgiBS.GetByBankaİlceAsync(Bankaİlce);
            return SendResponse(response);
        }

   
        [HttpGet("getByBankaAdresAsync")]
        public async Task<IActionResult> GetByBankaAdresAsync([FromQuery] string BankaAdres)
        {
            var response = await _bankabilgiBS.GetByBankaAdresAsync(BankaAdres);
            return SendResponse(response);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SaveNewBankaBilgi([FromBody] BankaBilgiPostDto dto)
        {
            var response = await _bankabilgiBS.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.BankaId }, response.Data);
            }
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> UpdateBankaBilgi([FromBody] BankaBilgiPutDto dto)
        {
            var response = await _bankabilgiBS.UpdateAsync(dto);
            return SendResponse(response);
        }
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBankaBilgi([FromRoute] int id)
        {
            var response = await _bankabilgiBS.DeleteAsync(id);
            return SendResponse(response);
        }

    }
}
