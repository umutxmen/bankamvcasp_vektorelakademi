using Banka.Model.Dtos.TLHavale;
using Banka.Model.Dtos.VadeliTLHesap;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IVadeliTLHesapBs
    {
        Task<ApiResponse<VadeliTLHesapGetDto>> GetByIdAsync(int VadeliTLHesapID, params string[] includeList);

        Task<ApiResponse<VadeliTLHesapGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<VadeliTLHesapGetDto>>> GetVadeliTLHesapAsync(params string[] includeList);
        Task<ApiResponse<List<VadeliTLHesapGetDto>>> GetByVarlıkAsync(decimal Varlık, params string[] includeList);
        Task<ApiResponse<List<VadeliTLHesapGetDto>>> GetByVadeBasTarihiAsync(DateTime VadeBasTarihi, params string[] includeList);
        Task<ApiResponse<List<VadeliTLHesapGetDto>>> GetByVadeBitisTarihiAsync(DateTime VadeBitisTarihi, params string[] includeList);
        Task<ApiResponse<List<VadeliTLHesapGetDto>>> GetByVadeliFaizoranAsync(int VadeliFaizoran, params string[] includeList);
        Task<ApiResponse<List<VadeliTLHesapGetDto>>> GetByVadeSonuMiktarAsync(decimal Aciklama, params string[] includeList);



        Task<ApiResponse<VadeliTLHesap>> InsertAsync(VadeliTLHesapPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(VadeliTLHesapPutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);
    }
}
