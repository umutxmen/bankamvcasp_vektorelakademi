using Banka.Model.Dtos.BankaBilgi;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IBankaBilgiBs
    {
        Task<ApiResponse<BankaBilgiGetDto>> GetByIdAsync(int BankaId, params string[] includeList);

        Task<ApiResponse<List<BankaBilgiGetDto>>> GetBankaBilgiAsync(params string[] includeList);
        Task<ApiResponse<List<BankaBilgiGetDto>>> GetByBankaSubeNoAsync(string BankaSubeNo, params string[] includeList);
        Task<ApiResponse<List<BankaBilgiGetDto>>> GetByBankaSehirAsync(string BankaSehir, params string[] includeList);
        Task<ApiResponse<List<BankaBilgiGetDto>>> GetByBankaİlceAsync(string Bankaİlce, params string[] includeList);
        Task<ApiResponse<List<BankaBilgiGetDto>>> GetByBankaAdresAsync(string BankaAdres, params string[] includeList);
        Task<ApiResponse<List<BankaBilgiGetDto>>> GetByBankaTelAsync(string BankaTel, params string[] includeList);
        Task<ApiResponse<BankaBilgi>> InsertAsync(BankaBilgiPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(BankaBilgiPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);



    }
}
