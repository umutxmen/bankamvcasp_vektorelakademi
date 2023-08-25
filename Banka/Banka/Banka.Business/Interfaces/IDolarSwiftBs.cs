using Banka.Model.Dtos.DolarHesap;
using Banka.Model.Dtos.DolarSwift;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IDolarSwiftBs
    {
        Task<ApiResponse<DolarSwiftGetDto>> GetByIdAsync(int DolarSwiftID, params string[] includeList);
        Task<ApiResponse<DolarSwiftGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<DolarSwiftGetDto>>> GetDolarSwiftAsync(params string[] includeList);
        Task<ApiResponse<List<DolarSwiftGetDto>>> GetByGidenHesapIbanAsync(string GidenHesapIban, params string[] includeList);
        Task<ApiResponse<List<DolarSwiftGetDto>>> GetByAlanHesapIbanAsync(string AlanHesapIban, params string[] includeList);
        Task<ApiResponse<List<DolarSwiftGetDto>>> GetBySwiftTarihiAsync(DateTime SwiftTarihi, params string[] includeList);
        Task<ApiResponse<List<DolarSwiftGetDto>>> GetByMiktarAsync(decimal Miktar, params string[] includeList);
        Task<ApiResponse<List<DolarSwiftGetDto>>> GetBySwiftKoduAsync(int SwiftKodu, params string[] includeList);
        Task<ApiResponse<List<DolarSwiftGetDto>>> GetByAciklamaAsync(string Aciklama, params string[] includeList);

        Task<ApiResponse<DolarSwift>> InsertAsync(DolarSwiftPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(DolarSwiftPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
