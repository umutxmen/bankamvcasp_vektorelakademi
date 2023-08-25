using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Implementations.EFCore.Repositories;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.Doviz;
using Banka.Model.Dtos.EuroHesap;
using Banka.Model.Dtos.EuroSwift;
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
    public class EuroSwiftBs : IEuroSwiftBs
    {
        private readonly IEuroSwiftRepository _repo;
        private readonly IMapper _mapper;
        public EuroSwiftBs(IEuroSwiftRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<EuroSwiftGetDto>>> GetByAlanHesapIbanAsync(string AlanHesapIban, params string[] includeList)
        {
            var EuroHesap = await _repo.GetByAlanHesapIbanAsync(AlanHesapIban);
            if (EuroHesap != null && EuroHesap.Count > 0)
            {
                var returnList = _mapper.Map<List<EuroSwiftGetDto>>(EuroHesap);
                return ApiResponse<List<EuroSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<EuroSwiftGetDto>>> GetByAciklamaAsync(string Aciklama, params string[] includeList)
        {

            var EuroHesap = await _repo.GetByAciklamaAsync(Aciklama);
            if (EuroHesap != null && EuroHesap.Count > 0)
            {
                var returnList = _mapper.Map<List<EuroSwiftGetDto>>(EuroHesap);
                return ApiResponse<List<EuroSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<EuroSwiftGetDto>>> GetByGidenHesapIbanAsync(string GidenHesapIban, params string[] includeList)
        {

            var EuroHesap = await _repo.GetByGidenHesapIbanAsync(GidenHesapIban);
            if (EuroHesap != null && EuroHesap.Count > 0)
            {
                var returnList = _mapper.Map<List<EuroSwiftGetDto>>(EuroHesap);
                return ApiResponse<List<EuroSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<EuroSwiftGetDto>> GetByIdAsync(int EuroSwiftID, params string[] includeList)
        {
            if (EuroSwiftID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(EuroSwiftID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<EuroSwiftGetDto>(bankabilgi);
                return ApiResponse<EuroSwiftGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<EuroSwiftGetDto>>> GetByMiktarAsync(int Miktar, params string[] includeList)
        {

            var EuroHesap = await _repo.GetByMiktarAsync(Miktar);
            if (EuroHesap != null && EuroHesap.Count > 0)
            {
                var returnList = _mapper.Map<List<EuroSwiftGetDto>>(EuroHesap);
                return ApiResponse<List<EuroSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<EuroSwiftGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<EuroSwiftGetDto>(bankakartı);
                return ApiResponse<EuroSwiftGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<EuroSwiftGetDto>>> GetBySwiftKoduAsync(int SwiftKodu, params string[] includeList)
        {

            var EuroHesap = await _repo.GetBySwiftKoduAsync(SwiftKodu);
            if (EuroHesap != null && EuroHesap.Count > 0)
            {
                var returnList = _mapper.Map<List<EuroSwiftGetDto>>(EuroHesap);
                return ApiResponse<List<EuroSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<EuroSwiftGetDto>>> GetBySwiftTarihiAsync(DateTime SwiftTarihi, params string[] includeList)
        {

            var EuroHesap = await _repo.GetBySwiftTarihiAsync(SwiftTarihi);
            if (EuroHesap != null && EuroHesap.Count > 0)
            {
                var returnList = _mapper.Map<List<EuroSwiftGetDto>>(EuroHesap);
                return ApiResponse<List<EuroSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<EuroSwiftGetDto>>> GetEuroSwiftAsync(params string[] includeList)
        {

            var EuroSwift = await _repo.GetAllAsync(includeList: includeList);
            if (EuroSwift != null && EuroSwift.Count > 0)
            {
                var returnList = _mapper.Map<List<EuroSwiftGetDto>>(EuroSwift);
                return ApiResponse<List<EuroSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<EuroSwift>> InsertAsync(EuroSwiftPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<EuroSwift>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<EuroSwift>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(EuroSwiftPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<EuroSwift>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
