using Banka.Model.Dtos.BankaBilgi;
using Banka.Model.Dtos.DolarHesap;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IDolarHesapBs
    {
        Task<ApiResponse<DolarHesapGetDto>> GetByIdAsync(int DolarHesapID, params string[] includeList);
        Task<ApiResponse<DolarHesapGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<DolarHesapGetDto>>> GetDolarHesapAsync(params string[] includeList);
        Task<ApiResponse<List<DolarHesapGetDto>>> GetByDolarVarlikAsync(decimal DolarVarlik, params string[] includeList);
        Task<ApiResponse<List<DolarHesapGetDto>>> GetByHesapTarihiAsync(DateTime HesapTarihi, params string[] includeList);
        Task<ApiResponse<List<DolarHesapGetDto>>> GetByHesapIbanAsync(string HesapIban, params string[] includeList);
     
        Task<ApiResponse<DolarHesapGetDto>> InsertAsync(DolarHesapPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(DolarHesapPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
