using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.BankaKartı;
using Banka.Model.Dtos.DolarHesap;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.DataAccess.Interfaces;

namespace Banka.Business.Implementations
{
    public class DolarHesapBs : IDolarHesapBs
    {
        private readonly IDolarHesapRepository _repo;
        private readonly IMapper _mapper;
        public DolarHesapBs(IDolarHesapRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public async Task<ApiResponse<NoData>> DeleteAsync(int id)
        {
            if (id <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var DolarHesap = await _repo.GetByIdAsync(id);
            if (DolarHesap != null)
            {
                await _repo.DeleteAsync(DolarHesap);
                return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
            }
            throw new NotFoundException("Silinecek olan içerik bulunamadı.");
        }
    

        public async Task<ApiResponse<List<DolarHesapGetDto>>> GetByDolarVarlikAsync(decimal DolarVarlik, params string[] includeList)
        {
            var bankakartı = await _repo.GetAllAsync(includeList: includeList);
            if (bankakartı != null && bankakartı.Count > 0)
            {
                var returnList = _mapper.Map<List<DolarHesapGetDto>>(bankakartı);
                return ApiResponse<List<DolarHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<DolarHesapGetDto>>> GetByHesapIbanAsync(string HesapIban, params string[] includeList)
        {
            var DolarHesap = await _repo.GetByHesapIbanAsync(HesapIban);
            if (DolarHesap != null && DolarHesap.Count > 0)
            {
                var returnList = _mapper.Map<List<DolarHesapGetDto>>(DolarHesap);
                return ApiResponse<List<DolarHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<DolarHesapGetDto>>> GetByHesapTarihiAsync(DateTime HesapTarihi, params string[] includeList)
        {
            var DolarHesap = await _repo.GetByHesapTarihiAsync(HesapTarihi);
            if (DolarHesap != null && DolarHesap.Count > 0)
            {
                var returnList = _mapper.Map<List<DolarHesapGetDto>>(DolarHesap);
                return ApiResponse<List<DolarHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<DolarHesapGetDto>> GetByIdAsync(int DolarHesapID, params string[] includeList)
        {
            if (DolarHesapID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByIdAsync(DolarHesapID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<DolarHesapGetDto>(bankakartı);
                return ApiResponse<DolarHesapGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<DolarHesapGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<DolarHesapGetDto>(bankakartı);
                return ApiResponse<DolarHesapGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }
              
        public async Task<ApiResponse<List<DolarHesapGetDto>>> GetDolarHesapAsync(params string[] includeList)
        {
            var dolarhesap = await _repo.GetAllAsync(includeList: includeList);
            if (dolarhesap != null && dolarhesap.Count > 0)
            {
                var returnList = _mapper.Map<List<DolarHesapGetDto>>(dolarhesap);
                return ApiResponse<List<DolarHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<DolarHesapGetDto>> InsertAsync(DolarHesapPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var dolarhesap = _mapper.Map<DolarHesap>(dto);
            var insertedbanka = await _repo.InsertAsync(dolarhesap);
            var retCat = _mapper.Map<DolarHesapGetDto>(insertedbanka);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<DolarHesapGetDto>.Success(StatusCodes.Status201Created, retCat);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(DolarHesapPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var dolarhesap = _mapper.Map<DolarHesap>(dto);
            await _repo.UpdateAsync(dolarhesap);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
