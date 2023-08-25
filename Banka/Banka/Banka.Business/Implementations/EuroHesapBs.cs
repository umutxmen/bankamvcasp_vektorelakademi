using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Implementations.EFCore.Repositories;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.Doviz;
using Banka.Model.Dtos.EFT;
using Banka.Model.Dtos.EuroHesap;
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
    internal class EuroHesapBs : IEuroHesapBs
    {
        private readonly IEuroHesapRepository _repo;
        private readonly IMapper _mapper;
        public EuroHesapBs(IEuroHesapRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<EuroHesapGetDto>>> GetByEuroVarlikAsync(decimal EuroVarlik, params string[] includeList)
        {

            var EuroHesap = await _repo.GetByEuroVarlikAsync(EuroVarlik);
            if (EuroHesap != null && EuroHesap.Count > 0)
            {
                var returnList = _mapper.Map<List<EuroHesapGetDto>>(EuroHesap);
                return ApiResponse<List<EuroHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<EuroHesapGetDto>>> GetByHesapIbanAsync(string HesapIban, params string[] includeList)
        {
            var EuroHesa = await _repo.GetByHesapIbanAsync(HesapIban);
            if (EuroHesa != null && EuroHesa.Count > 0)
            {
                var returnList = _mapper.Map<List<EuroHesapGetDto>>(EuroHesa);
                return ApiResponse<List<EuroHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<EuroHesapGetDto>>> GetByHesapTarihAsync(DateTime HesapTarih, params string[] includeList)
        {
            var EuroHesap = await _repo.GetByHesapTarihAsync(HesapTarih);
            if (EuroHesap != null && EuroHesap.Count > 0)
            {
                var returnList = _mapper.Map<List<EuroHesapGetDto>>(EuroHesap);
                return ApiResponse<List<EuroHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<EuroHesapGetDto>> GetByIdAsync(int EuroHesapID, params string[] includeList)
        {
            if (EuroHesapID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(EuroHesapID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<EuroHesapGetDto>(bankabilgi);
                return ApiResponse<EuroHesapGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<EuroHesapGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<EuroHesapGetDto>(bankakartı);
                return ApiResponse<EuroHesapGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<EuroHesapGetDto>>> GetEuroHesapAsync(params string[] includeList)
        {
            var EuroHesap = await _repo.GetAllAsync(includeList: includeList);
            if (EuroHesap != null && EuroHesap.Count > 0)
            {
                var returnList = _mapper.Map<List<EuroHesapGetDto>>(EuroHesap);
                return ApiResponse<List<EuroHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<EuroHesap>> InsertAsync(EuroHesapPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<EuroHesap>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<EuroHesap>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(EuroHesapPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<EuroHesap>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
