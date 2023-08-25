﻿namespace BankaMVC.Areas.Admin.HttpApiServices
{
  // Servisle iletişim kurmamızı sağlayacak concrete sınıf için gerçekleştirilmesi gereken api operasyonları
  public interface IHttpApiService
  {
    // api'a get request atılmasını sağlayacak ve oradan dönen response u geri döndürecek
    Task<T> GetData<T>(string endPoint,string token = null);

    // api'a post request atılmasını sağlayacak ve oradan dönen response u geri döndürecek
    Task<T> PostData<T>(string endPoint,string jsonData, string token = null);
    Task<T> PutData<T>(string endPoint,string jsonData, string token = null);

    Task<T> DeleteData<T>(string endPoint, string token = null);

  }
}
