using Banka.Model.Dtos.KartaParaAktar;
using Banka.Model.Dtos.Kartlar;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IKartlarBs
    {
        Task<ApiResponse<KartlarGetDto>> GetByIDAsync(int kartlarID, params string[] includeList);
        Task<ApiResponse<KartlarGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<KartlarGetDto>>> GetKartlarAsync(params string[] includeList);
        Task<ApiResponse<List<KartlarGetDto>>> GetByKrediKartıIDAsync(int KrediKartıID, params string[] includeList);
        Task<ApiResponse<List<KartlarGetDto>>> GetByKrediKartı2IDAsync(int KrediKartı2ID, params string[] includeList);
        Task<ApiResponse<List<KartlarGetDto>>> GetByKrediKartı3IDAsync(int KrediKartı3ID, params string[] includeList);
        Task<ApiResponse<List<KartlarGetDto>>> GetByBankaKartıIDAsync(int BankaKartıID, params string[] includeList);
        Task<ApiResponse<List<KartlarGetDto>>> GetByBankaKartı2IDAsync(int BankaKartı2ID, params string[] includeList);
        Task<ApiResponse<List<KartlarGetDto>>> GetByBankaKartı3IDAsync(int BankaKartı3ID, params string[] includeList);
        Task<ApiResponse<List<KartlarGetDto>>> GetBySanalKartIDAsync(int SanalKartID, params string[] includeList);
        Task<ApiResponse<List<KartlarGetDto>>> GetBySanalKart2IDAsync(int SanalKart2ID, params string[] includeList);
        Task<ApiResponse<List<KartlarGetDto>>> GetBySanalKart3IDAsync(int SanalKart3ID, params string[] includeList);
     


        Task<ApiResponse<Kartlar>> InsertAsync(KartlarPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(KartlarPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
