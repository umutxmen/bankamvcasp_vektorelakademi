using AutoMapper;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.BankaBilgi;
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
    public class BankaBilgiBs : IBankaBilgiBs
    {
        private readonly IBankaBilgiRepository _repo;
        private readonly IMapper _mapper;
        public BankaBilgiBs(IBankaBilgiRepository repo, IMapper mapper)
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

        public async Task<ApiResponse<List<BankaBilgiGetDto>>> GetBankaBilgiAsync(params string[] includeList)
        {
            var bankabilgi = await _repo.GetAllAsync(includeList: includeList);
            if (bankabilgi != null && bankabilgi.Count > 0)
            {
                var returnList = _mapper.Map<List<BankaBilgiGetDto>>(bankabilgi);
                return ApiResponse<List<BankaBilgiGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<BankaBilgiGetDto>>> GetByBankaAdresAsync(string BankaAdres, params string[] includeList)
        {
            var bankabilgi = await _repo.GetByBankaAdresAsync(BankaAdres,includeList);
            if (bankabilgi != null && bankabilgi.Count > 0)
            {
                var returnList = _mapper.Map<List<BankaBilgiGetDto>>(bankabilgi);
                return ApiResponse<List<BankaBilgiGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<BankaBilgiGetDto>>> GetByBankaSehirAsync(string BankaSehir, params string[] includeList)
        {
            var bankabilgi = await _repo.GetByBankaSehirAsync(BankaSehir, includeList);
            if (bankabilgi != null && bankabilgi.Count > 0)
            {
                var returnList = _mapper.Map<List<BankaBilgiGetDto>>(bankabilgi);
                return ApiResponse<List<BankaBilgiGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<BankaBilgiGetDto>>> GetByBankaSubeNoAsync(string BankaSubeNo, params string[] includeList)
        {
            var bankabilgi = await _repo.GetByBankaSubeNoAsync(BankaSubeNo, includeList);
            if (bankabilgi != null && bankabilgi.Count > 0)
            {
                var returnList = _mapper.Map<List<BankaBilgiGetDto>>(bankabilgi);
                return ApiResponse<List<BankaBilgiGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<BankaBilgiGetDto>>> GetByBankaTelAsync(string BankaTel, params string[] includeList)
        {
            var bankabilgi = await _repo.GetByBankaTelAsync(BankaTel, includeList);
            if (bankabilgi != null && bankabilgi.Count > 0)
            {
                var returnList = _mapper.Map<List<BankaBilgiGetDto>>(bankabilgi);
                return ApiResponse<List<BankaBilgiGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<List<BankaBilgiGetDto>>> GetByBankaİlceAsync(string Bankaİlce, params string[] includeList)
        {
            var bankabilgi = await _repo.GetByBankaİlceAsync(Bankaİlce, includeList);
            if (bankabilgi != null && bankabilgi.Count > 0)
            {
                var returnList = _mapper.Map<List<BankaBilgiGetDto>>(bankabilgi);
                return ApiResponse<List<BankaBilgiGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<BankaBilgiGetDto>> GetByIdAsync(int BankaId, params string[] includeList)
        {
            if (BankaId <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(BankaId);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<BankaBilgiGetDto>(bankabilgi);
                return ApiResponse<BankaBilgiGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<BankaBilgi>> InsertAsync(BankaBilgiPostDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }
            dto.BankaSehir = dto.BankaSehir.Trim();
            dto.Bankaİlce = dto.Bankaİlce.Trim();
            if (dto.BankaSehir.Length < 2 || dto.Bankaİlce.Length < 2)
            {
                throw new BadRequestException("Kaydedilecek verinin BankaSehir ve Bankaİlce en az 2 karakter olmalıdır.");
            }

            var bankabilgi = _mapper.Map<BankaBilgi>(dto);
            var insertedbanka = await _repo.InsertAsync(bankabilgi);

            // Başarılı bir cevap dondürür ve oluşturulan müşteriyi içeren veriyi içerir.
            return ApiResponse<BankaBilgi>.Success(StatusCodes.Status201Created, insertedbanka);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(BankaBilgiPutDto dto)
        {
            if (dto == null)
            {
                throw new BadRequestException("Kaydedilecek müşteri bilgisi bulunamadı.");
            }
            dto.BankaSehir = dto.BankaSehir.Trim();
            dto.Bankaİlce = dto.Bankaİlce.Trim();
            if (dto.BankaSehir.Length < 2 || dto.Bankaİlce.Length < 2)
            {
                throw new BadRequestException("Kaydedilecek verinin BankaSehir ve Bankaİlce en az 2 karakter olmalıdır.");
            }
            var employee = _mapper.Map<BankaBilgi>(dto);
            await _repo.UpdateAsync(employee);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }
    }
}
