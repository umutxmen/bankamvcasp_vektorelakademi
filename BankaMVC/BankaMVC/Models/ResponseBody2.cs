namespace BankaMVC.Models
{
  public class ResponseBody2<T>
  {
    public T Data { get; set; }
    public List<string> ErrorMessages { get; set; }
    public int StatusCode { get; set; }
  }
}
