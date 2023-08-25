using Infrastructure.DataAccess.Interfaces;
using Banka.Model.Entities;

namespace Banka.DataAccess.Interfaces
{
  public interface IAdminUserRepository : IBaseRepository<AdminUser>
  {
        Task<AdminUser> GetByIdAsync(int BankaId, params string[] includeList);

        Task<AdminUser> GetByUserNameAndPasswordAsync(string userName,string password, params string[] includeList);
  }
}
