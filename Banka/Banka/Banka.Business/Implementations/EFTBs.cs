using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.BankaKartı;
using Banka.Model.Dtos.DolarSwift;
using Banka.Model.Dtos.Doviz;
using Banka.Model.Dtos.EFT;
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
    public class EFTBs : IEFTBs
    {
        private readonly IEFTRepository _repo;
        private readonly IMapper _mapper;
        public EFTBs(IEFTRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<EFTGetDto>>> GetByAlanIbanAsync(string AlanIban, params string[] includeList)
        {
            var eft = await _repo.GetByAlanIbanAsync(AlanIban);
            if (eft != null && eft.Count > 0)
            {
                var returnList = _mapper.Map<List<EFTGetDto>>(eft);
                return ApiResponse<List<EFTGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<EFTGetDto>>> GetByAciklamaAsync(string Aciklama, params string[] includeList)
        {

            var eft = await _repo.GetByAciklamaAsync(Aciklama);
            if (eft != null && eft.Count > 0)
            {
                var returnList = _mapper.Map<List<EFTGetDto>>(eft);
                return ApiResponse<List<EFTGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<EFTGetDto>>> GetByBankaIDAsync(int BankaID, params string[] includeList)
        {
            var eft = await _repo.GetByBankaIDAsync(BankaID);
            if (eft != null && eft.Count > 0)
            {
                var returnList = _mapper.Map<List<EFTGetDto>>(eft);
                return ApiResponse<List<EFTGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<EFTGetDto>>> GetByDigerBankaIDAsync(int DigerBankaID, params string[] includeList)
        {
            var eft = await _repo.GetByDigerBankaIDAsync(DigerBankaID);
            if (eft != null && eft.Count > 0)
            {
                var returnList = _mapper.Map<List<EFTGetDto>>(eft);
                return ApiResponse<List<EFTGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<EFTGetDto>>> GetByGidenIbanAsync(string GidenIban, params string[] includeList)
        {
            var eft = await _repo.GetByGidenIbanAsync(GidenIban);
            if (eft != null && eft.Count > 0)
            {
                var returnList = _mapper.Map<List<EFTGetDto>>(eft);
                return ApiResponse<List<EFTGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<EFTGetDto>> GetByIdAsync(int EFTID, params string[] includeList)
        {
            if (EFTID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(EFTID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<EFTGetDto>(bankabilgi);
                return ApiResponse<EFTGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<EFTGetDto>>> GetByMiktarAsync(decimal Miktar, params string[] includeList)
        {
            var eft = await _repo.GetByMiktarAsync(Miktar);
            if (eft != null && eft.Count > 0)
            {
                var returnList = _mapper.Map<List<EFTGetDto>>(eft);
                return ApiResponse<List<EFTGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<EFTGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<EFTGetDto>(bankakartı);
                return ApiResponse<EFTGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<EFTGetDto>>> GetByİslemTarihiAsync(DateTime İslemTarihi, params string[] includeList)
        {
            var eft = await _repo.GetByİslemTarihiAsync(İslemTarihi);
            if (eft != null && eft.Count > 0)
            {
                var returnList = _mapper.Map<List<EFTGetDto>>(eft);
                return ApiResponse<List<EFTGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<EFTGetDto>>> GetEFTAsync(params string[] includeList)
        {
            var doviz = await _repo.GetAllAsync(includeList: includeList);
            if (doviz != null && doviz.Count > 0)
            {
                var returnList = _mapper.Map<List<EFTGetDto>>(doviz);
                return ApiResponse<List<EFTGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<EFT>> InsertAsync(EFTPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<EFT>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<EFT>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(EFTPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<EFT>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
