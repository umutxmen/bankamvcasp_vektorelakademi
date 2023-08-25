using Infrastructure.DataAccess.Implementations.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banka.DataAccess.Implementations.EFCore.Contexts;
using Banka.DataAccess.Interfaces;
using Banka.Model.Entities;
using System.Linq.Expressions;
using System.Xml.Linq;


namespace Banka.DataAccess.EFCore.Repositories
{
  public class AdminUserRepository : BaseRepository<AdminUser, BankaContext>, IAdminUserRepository
  {
        public async Task<AdminUser> GetByIdAsync(int GirisID, params string[] includeList)
        {
            return await GetAsync(prd => prd.Id == GirisID, includeList);
        }

        public async Task<AdminUser> GetByUserNameAndPasswordAsync(string userName, string password,params string[] includeList)
    {
      return await GetAsync(x => x.UserName == userName && x.Password == password && x.IsActive.Value,includeList);
    }
  }
}
