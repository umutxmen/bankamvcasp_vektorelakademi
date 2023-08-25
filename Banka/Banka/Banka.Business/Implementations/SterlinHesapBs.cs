using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.SanalKart;
using Banka.Model.Dtos.SterlinHesap;
using Banka.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Implementations
{
    public class SterlinHesapBs : ISterlinHesapBs
    {
        private readonly ISterlinHesapRepository _repo;
        private readonly IMapper _mapper;
        public SterlinHesapBs(ISterlinHesapRepository repo, IMapper mapper)
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
            var bankabilgi = await _repo.GetByIdAsync(id);
            if (bankabilgi != null)
            {
                await _repo.DeleteAsync(bankabilgi);
                return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
            }
            throw new NotFoundException("Silinecek olan içerik bulunamadı.");
        }

        public async Task<ApiResponse<List<SterlinHesapGetDto>>> GetByHesapIbanAsync(string HesapIban, params string[] includeList)
        {
            var sterlinhesap = await _repo.GetByHesapIbanAsync(HesapIban);
            if (sterlinhesap != null && sterlinhesap.Count > 0)
            {
                var returnList = _mapper.Map<List<SterlinHesapGetDto>>(sterlinhesap);
                return ApiResponse<List<SterlinHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SterlinHesapGetDto>>> GetByHesapTarihAsync(DateTime HesapTarih, params string[] includeList)
        {
            var sterlinhesap = await _repo.GetByHesapTarihAsync(HesapTarih);
            if (sterlinhesap != null && sterlinhesap.Count > 0)
            {
                var returnList = _mapper.Map<List<SterlinHesapGetDto>>(sterlinhesap);
                return ApiResponse<List<SterlinHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<SterlinHesapGetDto>> GetByIdAsync(int SterlinHesapId, params string[] includeList)
        {

            if (SterlinHesapId <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(SterlinHesapId);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<SterlinHesapGetDto>(bankabilgi);
                return ApiResponse<SterlinHesapGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<SterlinHesapGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<SterlinHesapGetDto>(bankakartı);
                return ApiResponse<SterlinHesapGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SterlinHesapGetDto>>> GetBySterlinVarlikAsync(decimal SterlinVarlik, params string[] includeList)
        {
            var sterlinhesap = await _repo.GetBySterlinVarlikAsync(SterlinVarlik);
            if (sterlinhesap != null && sterlinhesap.Count > 0)
            {
                var returnList = _mapper.Map<List<SterlinHesapGetDto>>(sterlinhesap);
                return ApiResponse<List<SterlinHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SterlinHesapGetDto>>> GetSterlinHesapAsync(params string[] includeList)
        {
            var SanalKart = await _repo.GetAllAsync(includeList: includeList);
            if (SanalKart != null && SanalKart.Count > 0)
            {
                var returnList = _mapper.Map<List<SterlinHesapGetDto>>(SanalKart);
                return ApiResponse<List<SterlinHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<SterlinHesap>> InsertAsync(SterlinHesapPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<SterlinHesap>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<SterlinHesap>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(SterlinHesapPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<SterlinHesap>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
