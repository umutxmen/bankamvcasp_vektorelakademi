using Banka.Model.Dtos.Doviz;
using Banka.Model.Dtos.EuroHesap;
using Banka.Model.Dtos.EuroSwift;
using Banka.Model.Dtos.Faturaode;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Interfaces
{
    public interface IFaturaOdeBs
    {
        Task<ApiResponse<FaturaOdeGetDto>> GetByIdAsync(int FaturaYatırİslemID, params string[] includeList);
        Task<ApiResponse<FaturaOdeGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList);

        Task<ApiResponse<List<FaturaOdeGetDto>>> GetFaturaOdeAsync(params string[] includeList);
        Task<ApiResponse<List<FaturaOdeGetDto>>> GetByfaturanoAsync(string faturano, params string[] includeList);
        Task<ApiResponse<List<FaturaOdeGetDto>>> GetByGonderenİbanAsync(string Gonderenİban, params string[] includeList);
        Task<ApiResponse<List<FaturaOdeGetDto>>> GetByodenecekMiktarAsync(decimal odenecekMiktar, params string[] includeList);
        Task<ApiResponse<List<FaturaOdeGetDto>>> GetByOdemeTarihAsync(DateTime OdemeTarih, params string[] includeList);
        Task<ApiResponse<List<FaturaOdeGetDto>>> GetByAciklamaAsync(string Aciklama, params string[] includeList);

        Task<ApiResponse<FaturaOde>> InsertAsync(FaturaOdePostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(FaturaOdePutDto dto);
        Task<ApiResponse<NoData>> DeleteAsync(int id);


    }
}
