using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.Business.Profiles;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.BankaKartı;
using Banka.Model.Dtos.Faturaode;
using Banka.Model.Dtos.GümüsHesap;
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
    public class GümüsHesapBs : IGümüsHesapBs
    {
        private readonly IGümüsHesapRepository _repo;
        private readonly IMapper _mapper;
        public GümüsHesapBs(IGümüsHesapRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<GümüsHesapGetDto>>> GetByGümüsVarlikGramAsync(decimal GümüsVarlikGram, params string[] includeList)
        {
            var gümüs = await _repo.GetByGümüsVarlikGramAsync(GümüsVarlikGram, includeList);
            if (gümüs != null && gümüs.Count > 0)
            {
                var returnList = _mapper.Map<List<GümüsHesapGetDto>>(gümüs);
                return ApiResponse<List<GümüsHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<GümüsHesapGetDto>>> GetByHesapTarihAsync(DateTime HesapTarih, params string[] includeList)
        {
            var gümüs = await _repo.GetByHesapTarihAsync(HesapTarih, includeList);
            if (gümüs != null && gümüs.Count > 0)
            {
                var returnList = _mapper.Map<List<GümüsHesapGetDto>>(gümüs);
                return ApiResponse<List<GümüsHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<GümüsHesapGetDto>> GetByIdAsync(int GümüsHesapID, params string[] includeList)
        {
            if (GümüsHesapID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(GümüsHesapID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<GümüsHesapGetDto>(bankabilgi);
                return ApiResponse<GümüsHesapGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<GümüsHesapGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {

            var gümüs = await _repo.GetByMusteriIDAsync(MusteriID, includeList);
            if (gümüs != null && gümüs.Count > 0)
            {
                var returnList = _mapper.Map<List<GümüsHesapGetDto>>(gümüs);
                return ApiResponse<GümüsHesapGetDto>.Success(StatusCodes.Status200OK);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<GümüsHesapGetDto>>> GetGümüsHesapAsync(params string[] includeList)
        {

            var GümüsHesap = await _repo.GetAllAsync(includeList: includeList);
            if (GümüsHesap != null && GümüsHesap.Count > 0)
            {
                var returnList = _mapper.Map<List<GümüsHesapGetDto>>(GümüsHesap);
                return ApiResponse<List<GümüsHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<Model.Entities.GümüsHesap>> InsertAsync(GümüsHesapPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<GümüsHesap>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<GümüsHesap>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(GümüsHesapPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<GümüsHesap>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
