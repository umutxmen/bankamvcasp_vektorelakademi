using Banka.Model.Dtos.VadesizTLHesap;
using Banka.Model.Dtos.VergiBorcuode;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IVergiBorcuOdeBs
    {
        Task<ApiResponse<VergiBorcuOdeGetDto>> GetByIdAsync(int VergiOdeİslemID, params string[] includeList);

        Task<ApiResponse<VergiBorcuOdeGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<VergiBorcuOdeGetDto>>> GetVergiBorcuOdeAsync(params string[] includeList);


        Task<ApiResponse<List<VergiBorcuOdeGetDto>>> GetByverginoAsync(string vergino, params string[] includeList);
        Task<ApiResponse<List<VergiBorcuOdeGetDto>>> GetByMusteriTCNoAsync(string MusteriTCNo, params string[] includeList);
        Task<ApiResponse<List<VergiBorcuOdeGetDto>>> GetByGondericiIBANAsync(string GondericiIBAN, params string[] includeList);
        Task<ApiResponse<List<VergiBorcuOdeGetDto>>> GetByGondericiADAsync(string GondericiAD, params string[] includeList);
        Task<ApiResponse<List<VergiBorcuOdeGetDto>>> GetByGondericiSoyadAsync(string GondericiSoyad, params string[] includeList);
        Task<ApiResponse<List<VergiBorcuOdeGetDto>>> GetByAciklamaAsync(string Aciklama, params string[] includeList);
        Task<ApiResponse<List<VergiBorcuOdeGetDto>>> GetByOdemeTarihAsync(DateTime OdemeTarih, params string[] includeList);


        Task<ApiResponse<VergiBorcuOde>> InsertAsync(VergiBorcuOdePostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(VergiBorcuOdePutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
