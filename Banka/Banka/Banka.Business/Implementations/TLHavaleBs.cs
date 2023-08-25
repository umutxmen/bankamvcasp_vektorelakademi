using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.SterlinSwift;
using Banka.Model.Dtos.TLHavale;
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
    public class TLHavaleBs : ITLHavaleBs
    {
        private readonly ITLHavaleRepository _repo;
        private readonly IMapper _mapper;
        public TLHavaleBs(ITLHavaleRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<TLHavaleGetDto>>> GetByAlanHesapIbanAsync(string AlanHesapIban, params string[] includeList)
        {
            var tlhavale = await _repo.GetByAlanHesapIbanAsync(AlanHesapIban);
            if (tlhavale != null && tlhavale.Count > 0)
            {
                var returnList = _mapper.Map<List<TLHavaleGetDto>>(tlhavale);
                return ApiResponse<List<TLHavaleGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<TLHavaleGetDto>>> GetByAciklamaAsync(string Aciklama, params string[] includeList)
        {
            var tlhavale = await _repo.GetByAciklamaAsync(Aciklama);
            if (tlhavale != null && tlhavale.Count > 0)
            {
                var returnList = _mapper.Map<List<TLHavaleGetDto>>(tlhavale);
                return ApiResponse<List<TLHavaleGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<TLHavaleGetDto>>> GetByGidenHesapIbanAsync(string GidenHesapIban, params string[] includeList)
        {
            var tlhavale = await _repo.GetByGidenHesapIbanAsync(GidenHesapIban);
            if (tlhavale != null && tlhavale.Count > 0)
            {
                var returnList = _mapper.Map<List<TLHavaleGetDto>>(tlhavale);
                return ApiResponse<List<TLHavaleGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<TLHavaleGetDto>> GetByIdAsync(int HavaleID, params string[] includeList)
        {
            if (HavaleID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(HavaleID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<TLHavaleGetDto>(bankabilgi);
                return ApiResponse<TLHavaleGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<TLHavaleGetDto>>> GetByMiktarAsync(decimal Miktar, params string[] includeList)
        {
            var tlhavale = await _repo.GetByMiktarAsync(Miktar);
            if (tlhavale != null && tlhavale.Count > 0)
            {
                var returnList = _mapper.Map<List<TLHavaleGetDto>>(tlhavale);
                return ApiResponse<List<TLHavaleGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<TLHavaleGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<TLHavaleGetDto>(bankakartı);
                return ApiResponse<TLHavaleGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<TLHavaleGetDto>>> GetByİslemTarihAsync(DateTime İslemTarih, params string[] includeList)
        {
            var tlhavale = await _repo.GetByİslemTarihAsync(İslemTarih);
            if (tlhavale != null && tlhavale.Count > 0)
            {
                var returnList = _mapper.Map<List<TLHavaleGetDto>>(tlhavale);
                return ApiResponse<List<TLHavaleGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<TLHavaleGetDto>>> GetTLHavaleAsync(params string[] includeList)
        {
            var Havale = await _repo.GetAllAsync(includeList: includeList);
            if (Havale != null && Havale.Count > 0)
            {
                var returnList = _mapper.Map<List<TLHavaleGetDto>>(Havale);
                return ApiResponse<List<TLHavaleGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<TLHavale>> InsertAsync(TLHavalePostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<TLHavale>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<TLHavale>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(TLHavalePutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<TLHavale>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
