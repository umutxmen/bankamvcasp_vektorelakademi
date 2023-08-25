using Banka.Model.Dtos.NakitAvans;
using Banka.Model.Dtos.SanalKart;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface ISanalKartBs
    {
        Task<ApiResponse<SanalKartGetDto>> GetByIdAsync(int SanalKartID, params string[] includeList);

        Task<ApiResponse<SanalKartGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<SanalKartGetDto>>> GetSanalKartAsync(params string[] includeList);
        Task<ApiResponse<List<SanalKartGetDto>>> GetByBagliKrediKartIDAsync(int BagliKrediKartID, params string[] includeList);
        Task<ApiResponse<List<SanalKartGetDto>>> GetByKartNoAsync(string KartNo, params string[] includeList);
        Task<ApiResponse<List<SanalKartGetDto>>> GetByKartKullanımAyAsync(int KartKullanımAy, params string[] includeList);
        Task<ApiResponse<List<SanalKartGetDto>>> GetByKartKullanumYılAsync(int KartKullanumYıl, params string[] includeList);
        Task<ApiResponse<List<SanalKartGetDto>>> GetByKartCVCNoAsync(int KartCVCNo, params string[] includeList);
        Task<ApiResponse<List<SanalKartGetDto>>> GetByKartSahipAdAsync(string KartSahipAd, params string[] includeList);
        Task<ApiResponse<List<SanalKartGetDto>>> GetByKartSahipSoyadAsync(string KartSahipSoyad, params string[] includeList);
        Task<ApiResponse<List<SanalKartGetDto>>> GetByKartTeknolojisiAsync(string KartTeknolojisi, params string[] includeList);



        Task<ApiResponse<SanalKart>> InsertAsync(SanalKartPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(SanalKartPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
