using AutoMapper;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using Banka.Business.CustomExceptions;
using Banka.Business.Interfaces;
using Banka.DataAccess.Interfaces;
using Banka.Model.Dtos.AdminUser;
using Banka.Model.Dtos.BankaBilgi;

namespace Banka.Business.Implementations
{
  public class AdminUserBs : IAdminUserBs
  {
    private readonly IAdminUserRepository _repo;
    private readonly IMapper _mapper;
    public AdminUserBs(IAdminUserRepository repo, IMapper mapper)
    {
      _mapper = mapper;
      _repo = repo;
    }

        public async Task<ApiResponse<AdminUserGetDto>> GetByIdAsync(int GirisID, params string[] includeList)
        {
            if (GirisID <= 0)
            {
                throw new BadRequestException("Id değeri 0'dan büyük olmalıdır.");
            }
            var bankabilgi = await _repo.GetByIdAsync(GirisID);
            if (bankabilgi != null)
            {
                var dto = _mapper.Map<AdminUserGetDto>(bankabilgi);
                return ApiResponse<AdminUserGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");
        }

        public async Task<ApiResponse<AdminUserGetDto>> LogIn(string userName, string password, params string[] includeList)
    {
      userName = userName.Trim();
      if (string.IsNullOrEmpty(userName))
      {
        throw new BadRequestException("Kullanıcı Adı Boş Bırakılamaz.");
      }

      if (userName.Length <= 2)
      {
        throw new BadRequestException("Kullanıcı Adı en az 3 karakter olmalıdır.");
      }

      password = password.Trim();
      if (string.IsNullOrEmpty(password))
      {
        throw new BadRequestException("Şifre Boş Bırakılamaz.");
      }

      var adminUser = await _repo.GetByUserNameAndPasswordAsync(userName,password, includeList);

      if (adminUser != null)
      {
        var dto = _mapper.Map<AdminUserGetDto>(adminUser);
        return ApiResponse<AdminUserGetDto>.Success(StatusCodes.Status200OK, dto);
      }
      throw new NotFoundException("İçerik Bulunamadı.");
    }
  }
}
