using Banka.Model.Dtos.KurKorumalıHesap;
using Banka.Model.Dtos.NakitAvans;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface INakitAvansBs
    {
        Task<ApiResponse<NakitAvansGetDto>> GetByIdAsync(int NakitAvansID, params string[] includeList);

        Task<ApiResponse<NakitAvansGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<NakitAvansGetDto>>> GetNakitAvansAsync(params string[] includeList);
        Task<ApiResponse<List<NakitAvansGetDto>>> GetByAktarılanİbanAsync(int Aktarılanİban, params string[] includeList);
        Task<ApiResponse<List<NakitAvansGetDto>>> GetBySonOdemeTarihiAsync(DateTime SonOdemeTarihi, params string[] includeList);
        Task<ApiResponse<List<NakitAvansGetDto>>> GetByAvansMiktarıAsync(decimal HeAvansMiktarısapAcimTarihi, params string[] includeList);
        Task<ApiResponse<List<NakitAvansGetDto>>> GetByFaizoranıAsync(decimal Faizoranı, params string[] includeList);
        Task<ApiResponse<List<NakitAvansGetDto>>> GetByodenecekMiktarAsync(decimal odenecekMiktar, params string[] includeList);
     


        Task<ApiResponse<NakitAvans>> InsertAsync(NakitAvansPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(NakitAvansPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
