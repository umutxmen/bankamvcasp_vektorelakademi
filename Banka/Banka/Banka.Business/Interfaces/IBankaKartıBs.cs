using Banka.Model.Dtos.BankaBilgi;
using Banka.Model.Dtos.BankaKartı;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IBankaKartiBs
    {
        Task<ApiResponse<BankaKartiGetDto>> GetBankaKartByIDAsync(int id, params string[] includeList);
        Task<ApiResponse<BankaKartiGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<BankaKartiGetDto>>> GetBankaKartiAsync(params string[] includeList);
        Task<ApiResponse<List<BankaKartiGetDto>>> GetByBagliIbanAsync(string Baglıİban, params string[] includeList);
        Task<ApiResponse<List<BankaKartiGetDto>>> GetByKartNoAsync(string KartNo, params string[] includeList);
        Task<ApiResponse<List<BankaKartiGetDto>>> GetByKartSonKullanimAyAsync(int KartSonKullanımAy, params string[] includeList);
        Task<ApiResponse<List<BankaKartiGetDto>>> GetByKartSonKullanimYilAsync(int KartSonKullanımYıl, params string[] includeList);
        Task<ApiResponse<List<BankaKartiGetDto>>> GetByKartSahipAdAsync(string KartSahipAd, params string[] includeList);
        Task<ApiResponse<List<BankaKartiGetDto>>> GetByKartSahipSoyadAsync(string KartSahipSoyad, params string[] includeList);
        Task<ApiResponse<List<BankaKartiGetDto>>> GetByKartTeknolojisiAsync(string KartTeknolojisi, params string[] includeList);
        Task<ApiResponse<BankaKarti>> InsertAsync(BankaKartiPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(BankaKartiPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
