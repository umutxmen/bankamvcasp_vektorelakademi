using Banka.Model.Dtos.SanalKart;
using Banka.Model.Dtos.SterlinSwift;
using Banka.Model.Dtos.TLHavale;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface ITLHavaleBs
    {
        Task<ApiResponse<TLHavaleGetDto>> GetByIdAsync(int HavaleID, params string[] includeList);

        Task<ApiResponse<TLHavaleGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);
        Task<ApiResponse<List<TLHavaleGetDto>>> GetTLHavaleAsync(params string[] includeList);

        Task<ApiResponse<List<TLHavaleGetDto>>> GetByGidenHesapIbanAsync(string GidenHesapIban, params string[] includeList);
        Task<ApiResponse<List<TLHavaleGetDto>>> GetByAlanHesapIbanAsync(string AlanHesapIban, params string[] includeList);
        Task<ApiResponse<List<TLHavaleGetDto>>> GetByİslemTarihAsync(DateTime İslemTarih, params string[] includeList);
        Task<ApiResponse<List<TLHavaleGetDto>>> GetByMiktarAsync(decimal Miktar, params string[] includeList);
        Task<ApiResponse<List<TLHavaleGetDto>>> GetByAciklamaAsync(string Aciklama, params string[] includeList);
       


        Task<ApiResponse<TLHavale>> InsertAsync(TLHavalePostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(TLHavalePutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
