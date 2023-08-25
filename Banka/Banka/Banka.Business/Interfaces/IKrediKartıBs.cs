using Banka.Model.Dtos.KartaParaAktar;
using Banka.Model.Dtos.Kartlar;
using Banka.Model.Dtos.KrediKartı;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IKrediKartıBs
    {
        Task<ApiResponse<KrediKartıGetDto>> GetByIdAsync(int KrediKartıID, params string[] includeList);

        Task<ApiResponse<KrediKartıGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<KrediKartıGetDto>>> GetKrediKartıAsync(params string[] includeList);
        Task<ApiResponse<List<KrediKartıGetDto>>> GetByBaglıİbanAsync(string Baglıİban, params string[] includeList);
        Task<ApiResponse<List<KrediKartıGetDto>>> GetByKartNoAsync(string KartNo, params string[] includeList);
        Task<ApiResponse<List<KrediKartıGetDto>>> GetByKartkullanımAyAsync(int KartkullanımAy, params string[] includeList);
        Task<ApiResponse<List<KrediKartıGetDto>>> GetByKartkullanımYılAsync(int KartkullanımYıl, params string[] includeList);
        Task<ApiResponse<List<KrediKartıGetDto>>> GetByKartCVCNoAsync(int KartCVCNo, params string[] includeList);
        Task<ApiResponse<List<KrediKartıGetDto>>> GetByKartSahipAdAsync(string KartSahipAd, params string[] includeList);
        Task<ApiResponse<List<KrediKartıGetDto>>> GetByKartSahipSoyadAsync(string KartSahipSoyad, params string[] includeList);
        Task<ApiResponse<List<KrediKartıGetDto>>> GetByKartTeknolojisiAsync(string KartTeknolojisi, params string[] includeList);



        Task<ApiResponse<KrediKartı>> InsertAsync(KrediKartıPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(KrediKartıPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
