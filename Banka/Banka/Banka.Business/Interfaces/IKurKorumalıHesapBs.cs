using Banka.Model.Dtos.KrediKartı;
using Banka.Model.Dtos.KurKorumalıHesap;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IKurKorumalıHesapBs
    {
        Task<ApiResponse<KurKorumalıHesapGetDto>> GetByIdAsync(int KurKorumaliHesapId, params string[] includeList);

        Task<ApiResponse<KurKorumalıHesapGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<KurKorumalıHesapGetDto>>> GetKurKorumalıHesapAsync(params string[] includeList);
        Task<ApiResponse<List<KurKorumalıHesapGetDto>>> GetByVarlikTLAsync(decimal VarlikTL, params string[] includeList);
        Task<ApiResponse<List<KurKorumalıHesapGetDto>>> GetByDovizIDAsync(int DovizID, params string[] includeList);
        Task<ApiResponse<List<KurKorumalıHesapGetDto>>> GetByHesapAcimTarihiAsync(DateTime HesapAcimTarihi, params string[] includeList);
        Task<ApiResponse<List<KurKorumalıHesapGetDto>>> GetByHesapAcimKuruAsync(decimal HesapAcimKuru, params string[] includeList);
        Task<ApiResponse<List<KurKorumalıHesapGetDto>>> GetByHesapKapanmaTarihiAsync(DateTime HesapKapanmaTarihi, params string[] includeList);
        Task<ApiResponse<List<KurKorumalıHesapGetDto>>> GetByHesapKapanmaKuruAsync(decimal HesapKapanmaKuru, params string[] includeList);
        Task<ApiResponse<List<KurKorumalıHesapGetDto>>> GetByHesapFaizoranAsync(int HesapFaizoran, params string[] includeList);



        Task<ApiResponse<KurKorumalıHesap>> InsertAsync(KurKorumalıHesapPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(KurKorumalıHesapPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
