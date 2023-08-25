using Banka.Model.Dtos.Doviz;
using Banka.Model.Dtos.EuroHesap;
using Banka.Model.Dtos.EuroSwift;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IEuroSwiftBs
    {
        Task<ApiResponse<EuroSwiftGetDto>> GetByIdAsync(int EuroSwiftID, params string[] includeList);
        Task<ApiResponse<EuroSwiftGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<EuroSwiftGetDto>>> GetEuroSwiftAsync(params string[] includeList);
        Task<ApiResponse<List<EuroSwiftGetDto>>> GetByGidenHesapIbanAsync(string GidenHesapIban, params string[] includeList);
        Task<ApiResponse<List<EuroSwiftGetDto>>> GetByAlanHesapIbanAsync(string AlanHesapIban, params string[] includeList);
        Task<ApiResponse<List<EuroSwiftGetDto>>> GetBySwiftTarihiAsync(DateTime SwiftTarihi, params string[] includeList);
        Task<ApiResponse<List<EuroSwiftGetDto>>> GetByMiktarAsync(int Miktar, params string[] includeList);
        Task<ApiResponse<List<EuroSwiftGetDto>>> GetBySwiftKoduAsync(int SwiftKodu, params string[] includeList);
        Task<ApiResponse<List<EuroSwiftGetDto>>> GetByAciklamaAsync(string Aciklama, params string[] includeList);

        Task<ApiResponse<EuroSwift>> InsertAsync(EuroSwiftPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(EuroSwiftPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
