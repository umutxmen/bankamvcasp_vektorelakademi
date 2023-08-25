using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.BankaKartı;
using Banka.Model.Dtos.DolarHesap;
using Banka.Model.Dtos.DolarSwift;
using Banka.Model.Dtos.Doviz;
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
    public class DolarSwiftBs : IDolarSwiftBs
    {
        private readonly IDolarSwiftRepository _repo;
        private readonly IMapper _mapper;
        public DolarSwiftBs(IDolarSwiftRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<DolarSwiftGetDto>>> GetByAlanHesapIbanAsync(string AlanHesapIban, params string[] includeList)
        {
            var DolarSwift = await _repo.GetByAlanHesapIbanAsync(AlanHesapIban);
            if (DolarSwift != null && DolarSwift.Count > 0)
            {
                var returnList = _mapper.Map<List<DolarSwiftGetDto>>(DolarSwift);
                return ApiResponse<List<DolarSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<DolarSwiftGetDto>>> GetByAciklamaAsync(string Aciklama, params string[] includeList)
        {
            var DolarSwift = await _repo.GetByAciklamaAsync(Aciklama);
            if (DolarSwift != null && DolarSwift.Count > 0)
            {
                var returnList = _mapper.Map<List<DolarSwiftGetDto>>(DolarSwift);
                return ApiResponse<List<DolarSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<DolarSwiftGetDto>>> GetByGidenHesapIbanAsync(string GidenHesapIban, params string[] includeList)
        {
            var DolarSwift = await _repo.GetByGidenHesapIbanAsync(GidenHesapIban);
            if (DolarSwift != null && DolarSwift.Count > 0)
            {
                var returnList = _mapper.Map<List<DolarSwiftGetDto>>(DolarSwift);
                return ApiResponse<List<DolarSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<DolarSwiftGetDto>> GetByIdAsync(int DolarSwiftID, params string[] includeList)
        {
            if (DolarSwiftID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByIdAsync(DolarSwiftID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<DolarSwiftGetDto>(bankakartı);
                return ApiResponse<DolarSwiftGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<DolarSwiftGetDto>>> GetByMiktarAsync(decimal Miktar, params string[] includeList)
        {
            var DolarSwift = await _repo.GetByMiktarAsync(Miktar);
            if (DolarSwift != null && DolarSwift.Count > 0)
            {
                var returnList = _mapper.Map<List<DolarSwiftGetDto>>(DolarSwift);
                return ApiResponse<List<DolarSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<DolarSwiftGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<DolarSwiftGetDto>(bankakartı);
                return ApiResponse<DolarSwiftGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<DolarSwiftGetDto>>> GetBySwiftKoduAsync(int SwiftKodu, params string[] includeList)
        {
            var DolarSwift = await _repo.GetBySwiftKoduAsync(SwiftKodu);
            if (DolarSwift != null && DolarSwift.Count > 0)
            {
                var returnList = _mapper.Map<List<DolarSwiftGetDto>>(DolarSwift);
                return ApiResponse<List<DolarSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<DolarSwiftGetDto>>> GetBySwiftTarihiAsync(DateTime SwiftTarihi, params string[] includeList)
        {
            var DolarSwift = await _repo.GetBySwiftTarihiAsync(SwiftTarihi);
            if (DolarSwift != null && DolarSwift.Count > 0)
            {
                var returnList = _mapper.Map<List<DolarSwiftGetDto>>(DolarSwift);
                return ApiResponse<List<DolarSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<DolarSwiftGetDto>>> GetDolarSwiftAsync(params string[] includeList)
        {
            var dolarhesap = await _repo.GetAllAsync(includeList: includeList);
            if (dolarhesap != null && dolarhesap.Count > 0)
            {
                var returnList = _mapper.Map<List<DolarSwiftGetDto>>(dolarhesap);
                return ApiResponse<List<DolarSwiftGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<DolarSwift>> InsertAsync(DolarSwiftPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var dolarhesap = _mapper.Map<DolarSwift>(dto);
            var insertedbanka = await _repo.InsertAsync(dolarhesap);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<DolarSwift>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(DolarSwiftPutDto dto)
        {

            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var dolarhesap = _mapper.Map<DolarSwift>(dto);
            await _repo.UpdateAsync(dolarhesap);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
