using Banka.Model.Dtos.DolarSwift;
using Banka.Model.Dtos.Doviz;
using Banka.Model.Dtos.EFT;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IEFTBs
    {
        Task<ApiResponse<EFTGetDto>> GetByIdAsync(int EFTID, params string[] includeList);
        Task<ApiResponse<EFTGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<EFTGetDto>>> GetEFTAsync(params string[] includeList);
        Task<ApiResponse<List<EFTGetDto>>> GetByBankaIDAsync(int BankaID, params string[] includeList);
        Task<ApiResponse<List<EFTGetDto>>> GetByDigerBankaIDAsync(int DigerBankaID, params string[] includeList);
        Task<ApiResponse<List<EFTGetDto>>> GetByGidenIbanAsync(string GidenIban, params string[] includeList);
        Task<ApiResponse<List<EFTGetDto>>> GetByAlanIbanAsync(string AlanIban, params string[] includeList);
        Task<ApiResponse<List<EFTGetDto>>> GetByMiktarAsync(decimal Miktar, params string[] includeList);
        Task<ApiResponse<List<EFTGetDto>>> GetByİslemTarihiAsync(DateTime İslemTarihi, params string[] includeList);
        Task<ApiResponse<List<EFTGetDto>>> GetByAciklamaAsync(string Aciklama, params string[] includeList);

        Task<ApiResponse<EFT>> InsertAsync(EFTPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(EFTPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
