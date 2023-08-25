using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.HizliKredi;
using Banka.Model.Dtos.KartaParaAktar;
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
    public class KartaParaAktarBs : IKartaParaAktarBs
    {
        private readonly IKartaParaAktarRepository _repo;
        private readonly IMapper _mapper;
        public KartaParaAktarBs(IKartaParaAktarRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<KartaParaAktarGetDto>>> GetByAktarılacakKartIDAsync(int AktarılacakKartID, params string[] includeList)
        {
            var KartaParaAkta = await _repo.GetByAktarılacakKartIDAsync(AktarılacakKartID);
            if (KartaParaAkta != null && KartaParaAkta.Count > 0)
            {
                var returnList = _mapper.Map<List<KartaParaAktarGetDto>>(KartaParaAkta);
                return ApiResponse<List<KartaParaAktarGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<KartaParaAktarGetDto>> GetByIdAsync(int KartaParaİslemID, params string[] includeList)
        {
            if (KartaParaİslemID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(KartaParaİslemID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<KartaParaAktarGetDto>(bankabilgi);
                return ApiResponse<KartaParaAktarGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KartaParaAktarGetDto>>> GetByMiktarAsync(decimal Miktar, params string[] includeList)
        {
            var KartaParaAkta = await _repo.GetByMiktarAsync(Miktar);
            if (KartaParaAkta != null && KartaParaAkta.Count > 0)
            {
                var returnList = _mapper.Map<List<KartaParaAktarGetDto>>(KartaParaAkta);
                return ApiResponse<List<KartaParaAktarGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<KartaParaAktarGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<KartaParaAktarGetDto>(bankakartı);
                return ApiResponse<KartaParaAktarGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KartaParaAktarGetDto>>> GetByVarlıkHesabıAsync(int VarlıkHesabı, params string[] includeList)
        {
            var KartaParaAkta = await _repo.GetByVarlıkHesabıAsync(VarlıkHesabı);
            if (KartaParaAkta != null && KartaParaAkta.Count > 0)
            {
                var returnList = _mapper.Map<List<KartaParaAktarGetDto>>(KartaParaAkta);
                return ApiResponse<List<KartaParaAktarGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KartaParaAktarGetDto>>> GetByİslemTarihiAsync(DateTime İslemTarihi, params string[] includeList)
        {
            var KartaParaAkta = await _repo.GetByİslemTarihiAsync(İslemTarihi);
            if (KartaParaAkta != null && KartaParaAkta.Count > 0)
            {
                var returnList = _mapper.Map<List<KartaParaAktarGetDto>>(KartaParaAkta);
                return ApiResponse<List<KartaParaAktarGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<KartaParaAktarGetDto>>> GetKartaParaAktarAsync(params string[] includeList)
        {
            var KartaParaAktar = await _repo.GetAllAsync(includeList: includeList);
            if (KartaParaAktar != null && KartaParaAktar.Count > 0)
            {
                var returnList = _mapper.Map<List<KartaParaAktarGetDto>>(KartaParaAktar);
                return ApiResponse<List<KartaParaAktarGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<KartaParaAktar>> InsertAsync(KartaParaAktarPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<KartaParaAktar>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<KartaParaAktar>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(KartaParaAktarPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<KartaParaAktar>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
