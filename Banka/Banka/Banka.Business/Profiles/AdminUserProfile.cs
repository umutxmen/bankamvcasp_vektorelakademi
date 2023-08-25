using AutoMapper;
using Banka.Model.Dtos.AdminUser;
using Banka.Model.Entities;

namespace Banka.Business.Profiles
{
  public class AdminUserProfile : Profile
  {
    public AdminUserProfile()
    {
      CreateMap<AdminUser, AdminUserGetDto>();
    }
  }
}
