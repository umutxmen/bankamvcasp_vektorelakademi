using Infrastructure.Utilities.ApiResponses;
using Banka.Model.Dtos.AdminUser;
using Banka.Model.Dtos.BankaBilgi;

namespace Banka.Business.Interfaces
{
  public interface IAdminUserBs
  {
        Task<ApiResponse<AdminUserGetDto>> GetByIdAsync(int GirisID, params string[] includeList);

        Task<ApiResponse<AdminUserGetDto>> LogIn(string userName,string password, params string[] includeList);
  }
}
