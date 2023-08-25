using Infrastructure.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banka.Model.Entities
{
  public class AdminUser : IEntity
  {
    public int Id { get; set; }
        public string? Fullname { get; set; }
        public string Email { get; set; }
       public string UserName { get; set; }
       public string Password { get; set; }
        public bool? IsActive { get; set; }
  }
}
