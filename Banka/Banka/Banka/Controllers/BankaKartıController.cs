using Banka.Business.Interfaces;
using Banka.Model.Dtos.BankaBilgi;
using Banka.Model.Dtos.BankaKartı;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/bankakartı")]
    [ApiController]
    public class BankaKartıController : BaseController
    {
        private readonly IBankaKartiBs _IBankaKartiBs;
        public BankaKartıController(IBankaKartiBs bankabilgiBS)
        {
            _IBankaKartiBs = bankabilgiBS;
        }


        [HttpGet]
        public async Task<IActionResult> GetBankaKartı()
        {
            var response = await _IBankaKartiBs.GetBankaKartiAsync();
            return SendResponse(response);
        }


        [HttpGet("GetByBaglıİbanAsync")]
        public async Task<IActionResult> GetByBaglıİbanAsync([FromQuery] string Baglıİban)
        {
            var response = await _IBankaKartiBs.GetByBagliIbanAsync(Baglıİban);
            return SendResponse(response);
        }


        [HttpGet("GetByKartNoAsync")]
        public async Task<IActionResult> GetByKartNoAsync([FromQuery] string KartNo)
        {
            var response = await _IBankaKartiBs.GetByKartNoAsync(KartNo);
            return SendResponse(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IBankaKartiBs.GetBankaKartByIDAsync(id);
            return SendResponse(response);
        }

        [HttpGet("GetByKartSonKullanımAyAsync")]
        public async Task<IActionResult> GetByKartSonKullanımAyAsync([FromQuery] int KartSonKullanımAy)
        {
            var response = await _IBankaKartiBs.GetByKartSonKullanimAyAsync(KartSonKullanımAy);
            return SendResponse(response);
        }


        [HttpGet("GetByKartSonKullanımYılAsync")]
        public async Task<IActionResult> GetByKartSonKullanımYılAsync([FromQuery] int KartSonKullanımYıl)
        {
            var response = await _IBankaKartiBs.GetByKartSonKullanimYilAsync(KartSonKullanımYıl);
            return SendResponse(response);
        }
        [HttpGet("GetByKartSahipAdAsync")]
        public async Task<IActionResult> GetByKartSahipAdAsync([FromQuery] string KartSahipAd)
        {
            var response = await _IBankaKartiBs.GetByKartSahipAdAsync(KartSahipAd);
            return SendResponse(response);
        }
        [HttpGet("GetByKartSahipSoyadAsync")]
        public async Task<IActionResult> GetByKartSahipSoyadAsync([FromQuery] string KartSahipSoyad)
        {
            var response = await _IBankaKartiBs.GetByKartSahipSoyadAsync(KartSahipSoyad);
            return SendResponse(response);
        }
        [HttpGet("GetByKartTeknolojisiAsync")]
        public async Task<IActionResult> GetByKartTeknolojisiAsync([FromQuery] string KartTeknolojisi)
        {
            var response = await _IBankaKartiBs.GetByKartTeknolojisiAsync(KartTeknolojisi);
            return SendResponse(response);
        }

        [HttpPost]
        public async Task<IActionResult> SaveNewBankaBilgi([FromBody] BankaKartiPostDto dto)
        {
            var response = await _IBankaKartiBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.BankaKartID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateBankaBilgi([FromBody] BankaKartiPutDto dto)
        {
            var response = await _IBankaKartiBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBankaBilgi([FromRoute] int id)
        {
            var response = await _IBankaKartiBs.DeleteAsync(id);
            return SendResponse(response);
        }

    }
}
