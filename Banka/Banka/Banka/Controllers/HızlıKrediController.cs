using Banka.Business.Interfaces;
using Banka.Model.Dtos.HizliKredi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/HizliKredi")]
    [ApiController]
    public class HizliKrediController : BaseController
    {
        private readonly IHizliKrediBs _IHizliKrediBs;
        public HizliKrediController(IHizliKrediBs HizliKredi)
        {
            _IHizliKrediBs = HizliKredi;
        }


        [HttpGet]
        public async Task<IActionResult> GetHizliKrediAsync()
        {
            var response = await _IHizliKrediBs.GetHizliKrediAsync();
            return SendResponse(response);
        }

        [HttpGet("GetByMusteriIDAsync")]
        public async Task<IActionResult> GetByMusteriIDAsync([FromQuery] int MusteriID)
        {
            var response = await _IHizliKrediBs.GetByMusteriIDAsync(MusteriID);
            return SendResponse(response);
        }



        [HttpGet("GetByAktarılacakİbanAsync")]
        public async Task<IActionResult> GetByAktarılacakİbanAsync([FromQuery] string Aktarılacakİban)
        {
            var response = await _IHizliKrediBs.GetByAktarılacakİbanAsync(Aktarılacakİban);
            return SendResponse(response);
        }
        [HttpGet("GetByKrediMiktarAsync")]
        public async Task<IActionResult> GetByKrediMiktarAsync([FromQuery] decimal KrediMiktar)
        {
            var response = await _IHizliKrediBs.GetByKrediMiktarAsync(KrediMiktar);
            return SendResponse(response);
        }
        [HttpGet("GetByKrediFaizAsync")]
        public async Task<IActionResult> GetByKrediFaizAsync([FromQuery] decimal KrediFaiz)
        {
            var response = await _IHizliKrediBs.GetByKrediFaizAsync(KrediFaiz);
            return SendResponse(response);
        }
        [HttpGet("GetByKrediÇekimTarihiAsync")]
        public async Task<IActionResult> GetByKrediÇekimTarihiAsync([FromQuery] DateTime KrediÇekimTarihi)
        {
            var response = await _IHizliKrediBs.GetByKrediÇekimTarihiAsync(KrediÇekimTarihi);
            return SendResponse(response);
        }
        [HttpGet("GetByKrediTaksitSayısıAsync")]
        public async Task<IActionResult> GetByKrediTaksitSayısıAsync([FromQuery] int KrediTaksitSayısı)
        {
            var response = await _IHizliKrediBs.GetByKrediTaksitSayısıAsync(KrediTaksitSayısı);
            return SendResponse(response);
        }
        [HttpGet("GetByKrediSonOdemeTarihAsync")]
        public async Task<IActionResult> GetByKrediSonOdemeTarihAsync([FromQuery] DateTime KrediSonOdemeTarih)
        {
            var response = await _IHizliKrediBs.GetByKrediSonOdemeTarihAsync(KrediSonOdemeTarih);
            return SendResponse(response);
        }
        [HttpGet("GetByKrediSonodemeTutarAsync")]
        public async Task<IActionResult> GetByKrediSonodemeTutarAsync([FromQuery] decimal KrediSonodemeTutar)
        {
            var response = await _IHizliKrediBs.GetByKrediSonodemeTutarAsync(KrediSonodemeTutar);
            return SendResponse(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IHizliKrediBs.GetByIdAsync(id);
            return SendResponse(response);
        }



        [HttpPost]
        public async Task<IActionResult> SaveNewHizliKredi([FromBody] HizliKrediPostDto dto)
        {
            var response = await _IHizliKrediBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.HizliKrediID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateHizliKredi([FromBody] HizliKrediPutDto dto)
        {
            var response = await _IHizliKrediBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHizliKredi([FromRoute] int id)
        {
            var response = await _IHizliKrediBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
