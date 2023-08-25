using Banka.Model.Dtos.SterlinHesap;
using Banka.Model.Dtos.SterlinSwift;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface ISterlinSwiftBs
    {
        Task<ApiResponse<SterlinSwiftGetDto>> GetByIdAsync(int SterlinSwiftID, params string[] includeList);

        Task<ApiResponse<SterlinSwiftGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<SterlinSwiftGetDto>>> GetSterlinSwiftAsync(params string[] includeList);
        Task<ApiResponse<List<SterlinSwiftGetDto>>> GetByGidenHesapIbanAsync(string GidenHesapIban, params string[] includeList);
        Task<ApiResponse<List<SterlinSwiftGetDto>>> GetByAlanHesapIbanAsync(string AlanHesapIban, params string[] includeList);
        Task<ApiResponse<List<SterlinSwiftGetDto>>> GetBySwiftTarihiAsync(DateTime SwiftTarihi, params string[] includeList);
        Task<ApiResponse<List<SterlinSwiftGetDto>>> GetByMiktarAsync(decimal Miktar, params string[] includeList);
        Task<ApiResponse<List<SterlinSwiftGetDto>>> GetBySwiftKoduAsync(int SwiftKodu, params string[] includeList);
        Task<ApiResponse<List<SterlinSwiftGetDto>>> GetByAciklamaAsync(string Aciklama, params string[] includeList);



        Task<ApiResponse<SterlinSwift>> InsertAsync(SterlinSwiftPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(SterlinSwiftPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
