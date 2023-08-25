using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Infrastructure.Utilities.ApiResponses
{
    public class ApiResponse<T>
    {
        public T Data { get; set; }

       // [JsonIgnore] // Bu sınıf nesnesi oluşturulup bir json a convert edildiğinde bu property seriliaze edilip json içeriğine alınmayacak
        public int StatusCode { get; set; }
        public List<string> ErrorMessages { get; set; }

        public static ApiResponse<T> Success(int statusCode, T data) // Başarılı bir yanıt oluşturur ve veri ile birlikte doner.
        {
            return new ApiResponse<T>
            {
                StatusCode = statusCode,
                Data = data
            };
        }

        public static ApiResponse<T> Success(int statusCode) // Başarılı bir yanıt oluşturur.
        {
            return new ApiResponse<T>
            {
                StatusCode = statusCode
            };
        }

        public static ApiResponse<T> Fail(int statusCode, List<string> errorMessages) // Başarısız bir yanıt oluşturur ve hata ile birlikte doner.
        {
            return new ApiResponse<T>
            {
                StatusCode = statusCode,
                ErrorMessages = errorMessages
            };
        }

        public static ApiResponse<T> Fail(int statusCode, string errorMessage) // Başarısız bir yanıt oluşturur ve hata mesajı ile birlikte doner.
        {
            return new ApiResponse<T>
            {
                StatusCode = statusCode,
                ErrorMessages = new List<string> { errorMessage }
            };
        }
    }
}
