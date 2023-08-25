using Banka.Business.Interfaces;
using Banka.Model.Dtos.DolarSwift;
using Banka.Model.Dtos.Doviz;
using Banka.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/doviz")]
    [ApiController]
    public class DovizController :  BaseController
    {

        private readonly IDovizBs _IDovizBs;
        public DovizController(IDovizBs Doviz)
        {
            _IDovizBs = Doviz;
        }


        [HttpGet]
        public async Task<IActionResult> GetDovizAsync()
        {
            var response = await _IDovizBs.GetDovizAsync();
            return SendResponse(response);
        }


     


        [HttpGet("GetByDovizAdıAsync")]
        public async Task<IActionResult> GetByDovizAdıAsync([FromQuery] string GidenHesapIban)
        {
            var response = await _IDovizBs.GetByDovizAdıAsync(GidenHesapIban);
            return SendResponse(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IDovizBs.GetByIdAsync(id);
            return SendResponse(response);
        }

        [HttpGet("GetByAlanHesapIbanAsync")]
        public async Task<IActionResult> GetByGüncelKurAlımAsync([FromQuery] decimal GüncelKurAlım)
        {
            var response = await _IDovizBs.GetByGüncelKurAlımAsync(GüncelKurAlım);
            return SendResponse(response);
        }


        [HttpGet("GetByGüncelKurSatımAsync")]
        public async Task<IActionResult> GetByGüncelKurSatımAsync([FromQuery] decimal GüncelKurSatım)
        {
            var response = await _IDovizBs.GetByGüncelKurSatımAsync(GüncelKurSatım);
            return SendResponse(response);
        }
       

        [HttpPost]
        public async Task<IActionResult> SaveNewDoviz([FromBody] DovizPostDto dto)
        {
            var response = await _IDovizBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.DovizID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateDoviz([FromBody] DovizPutDto dto)
        {
            var response = await _IDovizBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDovizt([FromRoute] int id)
        {
            var response = await _IDovizBs.DeleteAsync(id);
            return SendResponse(response);
        }







    }
    }
