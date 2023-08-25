namespace BankaMVC.Models
{
  public class AccessTokenItem2
  {
    public List<string> Claims { get; set; }
    public string Token { get; set; }
    public DateTime Expiration { get; set; }
  }
}
