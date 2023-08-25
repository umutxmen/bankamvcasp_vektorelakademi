using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.TLHavale;
using Banka.Model.Dtos.VadeliTLHesap;
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
    public class VadeliTLHesapBs : IVadeliTLHesapBs
    {
        private readonly IVadeliTLHesapRepository _repo;
        private readonly IMapper _mapper;
        public VadeliTLHesapBs(IVadeliTLHesapRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<VadeliTLHesapGetDto>> GetByIdAsync(int VadeliTLHesapID, params string[] includeList)
        {
            if (VadeliTLHesapID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(VadeliTLHesapID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<VadeliTLHesapGetDto>(bankabilgi);
                return ApiResponse<VadeliTLHesapGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<VadeliTLHesapGetDto>> GetByMusteriIDAsync(int MusteriID, params string[] includeList)
        {
            if (MusteriID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankakartı = await _repo.GetByMusteriIDAsync(MusteriID);
            if (bankakartı != null)
            {
                var dto = _mapper.Map<VadeliTLHesapGetDto>(bankakartı);
                return ApiResponse<VadeliTLHesapGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<VadeliTLHesapGetDto>>> GetByVadeBasTarihiAsync(DateTime VadeBasTarihi, params string[] includeList)
        {
            var vadelitl = await _repo.GetByVadeBasTarihiAsync(VadeBasTarihi);
            if (vadelitl != null && vadelitl.Count > 0)
            {
                var returnList = _mapper.Map<List<VadeliTLHesapGetDto>>(vadelitl);
                return ApiResponse<List<VadeliTLHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<VadeliTLHesapGetDto>>> GetByVadeBitisTarihiAsync(DateTime VadeBitisTarihi, params string[] includeList)
        {
            var vadelitl = await _repo.GetByVadeBitisTarihiAsync(VadeBitisTarihi);
            if (vadelitl != null && vadelitl.Count > 0)
            {
                var returnList = _mapper.Map<List<VadeliTLHesapGetDto>>(vadelitl);
                return ApiResponse<List<VadeliTLHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<VadeliTLHesapGetDto>>> GetByVadeliFaizoranAsync(int VadeliFaizoran, params string[] includeList)
        {
            var vadelitl = await _repo.GetByVadeliFaizoranAsync(VadeliFaizoran);
            if (vadelitl != null && vadelitl.Count > 0)
            {
                var returnList = _mapper.Map<List<VadeliTLHesapGetDto>>(vadelitl);
                return ApiResponse<List<VadeliTLHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<VadeliTLHesapGetDto>>> GetByVadeSonuMiktarAsync(decimal Aciklama, params string[] includeList)
        {
            var vadelitl = await _repo.GetByVadeSonuMiktarAsync(Aciklama);
            if (vadelitl != null && vadelitl.Count > 0)
            {
                var returnList = _mapper.Map<List<VadeliTLHesapGetDto>>(vadelitl);
                return ApiResponse<List<VadeliTLHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<VadeliTLHesapGetDto>>> GetByVarlıkAsync(decimal Varlık, params string[] includeList)
        {
            var vadelitl = await _repo.GetByVarlıkAsync(Varlık);
            if (vadelitl != null && vadelitl.Count > 0)
            {
                var returnList = _mapper.Map<List<VadeliTLHesapGetDto>>(vadelitl);
                return ApiResponse<List<VadeliTLHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<VadeliTLHesapGetDto>>> GetVadeliTLHesapAsync(params string[] includeList)
        {
            var Havale = await _repo.GetAllAsync(includeList: includeList);
            if (Havale != null && Havale.Count > 0)
            {
                var returnList = _mapper.Map<List<VadeliTLHesapGetDto>>(Havale);
                return ApiResponse<List<VadeliTLHesapGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<VadeliTLHesap>> InsertAsync(VadeliTLHesapPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var bankakartı = _mapper.Map<VadeliTLHesap>(dto);
            var insertedbanka = await _repo.InsertAsync(bankakartı);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<VadeliTLHesap>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(VadeliTLHesapPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }


            var eft = _mapper.Map<VadeliTLHesap>(dto);
            await _repo.UpdateAsync(eft);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
