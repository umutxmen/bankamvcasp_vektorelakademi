using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.SterlinHesap;
using Banka.Model.Dtos.SterlinSwift;
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
    public class SterlinSwiftBs : ISterlinSwiftBs
    {
        private readonly ISterlinSwiftRepository _repo;
        private readonly IMapper _mapper;
        public SterlinSwiftBs(ISterlinSwiftRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<SterlinSwiftGetDto>>> GetByAlanHesapIbanAsync(string AlanHesapIban, params string[] includeList)
        {
            var sterlinswift = await _repo.GetByAlanHesapIbanAsync(AlanHesapIban);
            if (sterlinswift != null && sterlinswift.Count > 0)
            {
                var returnList = _mapper.Map<List<SterlinSwiftGetDto>>(sterlinswift);
                return ApiResponse<List<SterlinSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SterlinSwiftGetDto>>> GetByAciklamaAsync(string Aciklama, params string[] includeList)
        {
            var sterlinswift = await _repo.GetByAciklamaAsync(Aciklama);
            if (sterlinswift != null && sterlinswift.Count > 0)
            {
                var returnList = _mapper.Map<List<SterlinSwiftGetDto>>(sterlinswift);
                return ApiResponse<List<SterlinSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SterlinSwiftGetDto>>> GetByGidenHesapIbanAsync(string GidenHesapIban, params string[] includeList)
        {
            var sterlinswift = await _repo.GetByGidenHesapIbanAsync(GidenHesapIban);
            if (sterlinswift != null && sterlinswift.Count > 0)
            {
                var returnList = _mapper.Map<List<SterlinSwiftGetDto>>(sterlinswift);
                return ApiResponse<List<SterlinSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<SterlinSwiftGetDto>> GetByIdAsync(int SterlinSwiftID, params string[] includeList)
        {
            if (SterlinSwiftID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(SterlinSwiftID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<SterlinSwiftGetDto>(bankabilgi);
                return ApiResponse<SterlinSwiftGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SterlinSwiftGetDto>>> GetByMiktarAsync(decimal Miktar, params string[] includeList)
        {
            var sterlinswift = await _repo.GetByMiktarAsync(Miktar);
            if (sterlinswift != null && sterlinswift.Count > 0)
            {
                var returnList = _mapper.Map<List<SterlinSwiftGetDto>>(sterlinswift);
                return ApiResponse<List<SterlinSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<SterlinSwiftGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<SterlinSwiftGetDto>(bankakartı);
                return ApiResponse<SterlinSwiftGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SterlinSwiftGetDto>>> GetBySwiftKoduAsync(int SwiftKodu, params string[] includeList)
        {
            var sterlinswift = await _repo.GetBySwiftKoduAsync(SwiftKodu);
            if (sterlinswift != null && sterlinswift.Count > 0)
            {
                var returnList = _mapper.Map<List<SterlinSwiftGetDto>>(sterlinswift);
                return ApiResponse<List<SterlinSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SterlinSwiftGetDto>>> GetBySwiftTarihiAsync(DateTime SwiftTarihi, params string[] includeList)
        {
            var sterlinswift = await _repo.GetBySwiftTarihiAsync(SwiftTarihi);
            if (sterlinswift != null && sterlinswift.Count > 0)
            {
                var returnList = _mapper.Map<List<SterlinSwiftGetDto>>(sterlinswift);
                return ApiResponse<List<SterlinSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<SterlinSwiftGetDto>>> GetSterlinSwiftAsync(params string[] includeList)
        {

            var SanalKart = await _repo.GetAllAsync(includeList: includeList);
            if (SanalKart != null && SanalKart.Count > 0)
            {
                var returnList = _mapper.Map<List<SterlinSwiftGetDto>>(SanalKart);
                return ApiResponse<List<SterlinSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<SterlinSwift>> InsertAsync(SterlinSwiftPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<SterlinSwift>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<SterlinSwift>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(SterlinSwiftPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<SterlinSwift>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
