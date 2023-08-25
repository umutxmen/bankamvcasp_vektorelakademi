using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.Harcama;
using Banka.Model.Dtos.HizliKredi;
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
    public class HizliKrediBs : IHizliKrediBs
    {
        private readonly IHizliKrediRepository _repo;
        private readonly IMapper _mapper;
        public HizliKrediBs(IHizliKrediRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<HizliKrediGetDto>>> GetByAktarılacakİbanAsync(string Aktarılacakİban, params string[] includeList)
        {
            var HizliKredi = await _repo.GetByAktarılacakİbanAsync(Aktarılacakİban);
            if (HizliKredi != null && HizliKredi.Count > 0)
            {
                var returnList = _mapper.Map<List<HizliKrediGetDto>>(HizliKredi);
                return ApiResponse<List<HizliKrediGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<HizliKrediGetDto>> GetByIdAsync(int HizliKrediID, params string[] includeList)
        {
            if (HizliKrediID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(HizliKrediID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<HizliKrediGetDto>(bankabilgi);
                return ApiResponse<HizliKrediGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<HizliKrediGetDto>>> GetByKrediFaizAsync(decimal KrediFaiz, params string[] includeList)
        {
            var HizliKredi = await _repo.GetByKrediFaizAsync(KrediFaiz);
            if (HizliKredi != null && HizliKredi.Count > 0)
            {
                var returnList = _mapper.Map<List<HizliKrediGetDto>>(HizliKredi);
                return ApiResponse<List<HizliKrediGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<HizliKrediGetDto>>> GetByKrediMiktarAsync(decimal KrediMiktar, params string[] includeList)
        {
            var HizliKredi = await _repo.GetByKrediMiktarAsync(KrediMiktar);
            if (HizliKredi != null && HizliKredi.Count > 0)
            {
                var returnList = _mapper.Map<List<HizliKrediGetDto>>(HizliKredi);
                return ApiResponse<List<HizliKrediGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<HizliKrediGetDto>>> GetByKrediSonOdemeTarihAsync(DateTime KrediSonOdemeTarih, params string[] includeList)
        {
            var HizliKredi = await _repo.GetByKrediSonOdemeTarihAsync(KrediSonOdemeTarih);
            if (HizliKredi != null && HizliKredi.Count > 0)
            {
                var returnList = _mapper.Map<List<HizliKrediGetDto>>(HizliKredi);
                return ApiResponse<List<HizliKrediGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<HizliKrediGetDto>>> GetByKrediSonodemeTutarAsync(decimal KrediSonodemeTutar, params string[] includeList)
        {
            var HizliKredi = await _repo.GetByKrediSonodemeTutarAsync(KrediSonodemeTutar);
            if (HizliKredi != null && HizliKredi.Count > 0)
            {
                var returnList = _mapper.Map<List<HizliKrediGetDto>>(HizliKredi);
                return ApiResponse<List<HizliKrediGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<HizliKrediGetDto>>> GetByKrediTaksitSayısıAsync(int KrediTaksitSayısı, params string[] includeList)
        {
            var HizliKredi = await _repo.GetByKrediTaksitSayısıAsync(KrediTaksitSayısı);
            if (HizliKredi != null && HizliKredi.Count > 0)
            {
                var returnList = _mapper.Map<List<HizliKrediGetDto>>(HizliKredi);
                return ApiResponse<List<HizliKrediGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<HizliKrediGetDto>>> GetByKrediÇekimTarihiAsync(DateTime KrediÇekimTarihi, params string[] includeList)
        {
            var HizliKredi = await _repo.GetByKrediÇekimTarihiAsync(KrediÇekimTarihi);
            if (HizliKredi != null && HizliKredi.Count > 0)
            {
                var returnList = _mapper.Map<List<HizliKrediGetDto>>(HizliKredi);
                return ApiResponse<List<HizliKrediGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<HizliKrediGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<HizliKrediGetDto>(bankakartı);
                return ApiResponse<HizliKrediGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<HizliKrediGetDto>>> GetHizliKrediAsync(params string[] includeList)
        {
            var HizliKredi = await _repo.GetAllAsync(includeList: includeList);
            if (HizliKredi != null && HizliKredi.Count > 0)
            {
                var returnList = _mapper.Map<List<HizliKrediGetDto>>(HizliKredi);
                return ApiResponse<List<HizliKrediGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<HizliKredi>> InsertAsync(HizliKrediPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<HizliKredi>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<HizliKredi>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(HizliKrediPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<HizliKredi>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
