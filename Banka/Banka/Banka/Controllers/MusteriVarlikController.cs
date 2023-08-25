using Banka.Business.Implementations;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.MusteriVarlik;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS.WebAPI.Controllers;

namespace Banka.WebApi.Controllers
{
    [Route("api/Musterivarlik")]
    [ApiController]
    public class MusteriVarlikController : BaseController
    {
        private readonly IMusteriVarlikBs _IMusteriVarlikBs;
        public MusteriVarlikController(IMusteriVarlikBs MusteriVarlik)
        {
            _IMusteriVarlikBs = MusteriVarlik;
        }

        #region SWAGGER DOC
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<List<MusteriVarlikGetDto>>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpGet]
        public async Task<IActionResult> GetMusteriVarlik()
        {
            var response = await _IMusteriVarlikBs.GetMusteriVarlikAsync("MusteriData");
            return SendResponse(response);
        }

        [HttpGet("GetByBankaIdAsync")]
        public async Task<IActionResult> GetByBankaIdAsync([FromQuery] int BankaId)
        {
            var response = await _IMusteriVarlikBs.GetByBankaIdAsync(BankaId);
            return SendResponse(response);
        }


      

        [HttpGet("GetByMusteriDataIDAsync")]
        public async Task<IActionResult> GetByMusteriDataIDAsync([FromQuery] int MusteriDataID)
        {
            var response = await _IMusteriVarlikBs.GetByMusteriDataIDAsync(MusteriDataID);
            return SendResponse(response);
        }

        [HttpGet("GetByHesapTLVadesizAsync")]
        public async Task<IActionResult> GetByHesapTLVadesizAsync([FromQuery] bool HesapTLVadesiz)
        {
            var response = await _IMusteriVarlikBs.GetByHesapTLVadesizAsync(HesapTLVadesiz);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapTLVadeliAsync")]
        public async Task<IActionResult> GetByHesapTLVadeliAsync([FromQuery] bool HesapTLVadeli)
        {
            var response = await _IMusteriVarlikBs.GetByHesapTLVadeliAsync(HesapTLVadeli);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapEuroVadesizAsync")]
        public async Task<IActionResult> GetByHesapEuroVadesizAsync([FromQuery] bool HesapEuroVadesiz)
        {
            var response = await _IMusteriVarlikBs.GetByHesapEuroVadesizAsync(HesapEuroVadesiz);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapSterlinVadesizAsync")]
        public async Task<IActionResult> GetByHesapSterlinVadesizAsync([FromQuery] bool HesapSterlinVadesiz)
        {
            var response = await _IMusteriVarlikBs.GetByHesapSterlinVadesizAsync(HesapSterlinVadesiz);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapDolarVadesizAsync")]
        public async Task<IActionResult> GetByHesapDolarVadesizAsync([FromQuery] bool HesapDolarVadesiz)
        {
            var response = await _IMusteriVarlikBs.GetByHesapDolarVadesizAsync(HesapDolarVadesiz);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapAltinVadesizAsync")]
        public async Task<IActionResult> GetByHesapAltinVadesizAsync([FromQuery] bool HesapAltinVadesiz)
        {
            var response = await _IMusteriVarlikBs.GetByHesapAltinVadesizAsync(HesapAltinVadesiz);
            return SendResponse(response);
        }
        [HttpGet("GetByHesapGümüsVadesizAsync")]
        public async Task<IActionResult> GetByHesapGümüsVadesizAsync([FromQuery] bool HesapGümüsVadesiz)
        {
            var response = await _IMusteriVarlikBs.GetByHesapGümüsVadesizAsync(HesapGümüsVadesiz);
            return SendResponse(response);
        }
        [HttpGet("GetByVadesizTLHesapIDAsync")]
        public async Task<IActionResult> GetByVadesizTLHesapIDAsync([FromQuery] int VadesizTLHesapID)
        {
            var response = await _IMusteriVarlikBs.GetByVadesizTLHesapIDAsync(VadesizTLHesapID);
            return SendResponse(response);
        }
        [HttpGet("GetByVadeliTLHesapIDAsync")]
        public async Task<IActionResult> GetByVadeliTLHesapIDAsync([FromQuery] int VadeliTLHesapID)
        {
            var response = await _IMusteriVarlikBs.GetByVadeliTLHesapIDAsync(VadeliTLHesapID);
            return SendResponse(response);
        }
        [HttpGet("GetByDolarHesapIDAsync")]
        public async Task<IActionResult> GetByDolarHesapIDAsync([FromQuery] int DolarHesapID)
        {
            var response = await _IMusteriVarlikBs.GetByDolarHesapIDAsync(DolarHesapID);
            return SendResponse(response);
        }
     
        [HttpGet("GetByEuroHesapIDAsync")]
        public async Task<IActionResult> GetByEuroHesapIDAsync([FromQuery] int EuroHesapID)
        {
            var response = await _IMusteriVarlikBs.GetByEuroHesapIDAsync(EuroHesapID);
            return SendResponse(response);
        }
        [HttpGet("GetBySterlinHesapIDAsync")]
        public async Task<IActionResult> GetBySterlinHesapIDAsync([FromQuery] int SterlinHesapID)
        {
            var response = await _IMusteriVarlikBs.GetBySterlinHesapIDAsync(SterlinHesapID);
            return SendResponse(response);
        }
        [HttpGet("GetByKurKorumalıTLHesapIDAsync")]
        public async Task<IActionResult> GetByKurKorumalıTLHesapIDAsync([FromQuery] int KurKorumalıTLHesapID)
        {
            var response = await _IMusteriVarlikBs.GetByKurKorumalıTLHesapIDAsync(KurKorumalıTLHesapID);
            return SendResponse(response);
        }
        [HttpGet("GetByAltinHesapIDAsync")]
        public async Task<IActionResult> GetByAltinHesapIDAsync([FromQuery] int AltinHesapID)
        {
            var response = await _IMusteriVarlikBs.GetByAltinHesapIDAsync(AltinHesapID);
            return SendResponse(response);
        }
        [HttpGet("GetByGümüsHesapIDAsync")]
        public async Task<IActionResult> GetByGümüsHesapIDAsync([FromQuery] int GümüsHesapID)
        {
            var response = await _IMusteriVarlikBs.GetByGümüsHesapIDAsync(GümüsHesapID);
            return SendResponse(response);
        }
        [HttpGet("GetByBankaKartlarIDAsync")]
        public async Task<IActionResult> GetByBankaKartlarIDAsync([FromQuery] int BankaKartlarID)
        {
            var response = await _IMusteriVarlikBs.GetByBankaKartlarIDAsync(BankaKartlarID);
            return SendResponse(response);
        }
        [HttpGet("GetByKrediKartlarIDAsync")]
        public async Task<IActionResult> GetByKrediKartlarIDAsync([FromQuery] int KrediKartlarID)
        {
            var response = await _IMusteriVarlikBs.GetByKrediKartlarIDAsync(KrediKartlarID);
            return SendResponse(response);
        }
        [HttpGet("GetByIbanlarIDAsync")]
        public async Task<IActionResult> GetByIbanlarIDAsync([FromQuery] int IbanlarID)
        {
            var response = await _IMusteriVarlikBs.GetByIbanlarIDAsync(IbanlarID);
            return SendResponse(response);
        }
       

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _IMusteriVarlikBs.GetMusteriVarlikByIdAsync(id,"MusteriData");
            return SendResponse(response);
        }



        [HttpPost]
        public async Task<IActionResult> SaveNewMusteriVarlik([FromBody] MusteriVarlikPostDto dto)
        {
            var response = await _IMusteriVarlikBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return SendResponse(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.MusteriVarlikID }, response.Data);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateMusteriVarlik([FromBody] MusteriVarlikPutDto dto)
        {
            var response = await _IMusteriVarlikBs.UpdateAsync(dto);
            return SendResponse(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusteriVarlik([FromRoute] int id)
        {
            var response = await _IMusteriVarlikBs.DeleteAsync(id);
            return SendResponse(response);
        }
    }
}
