using System.Text.Json;
using WebApplication1.Models.UserModels;

namespace WebApplication1.Models.Error
{
    public class ErrorModels
    {
        public enum ErrorCodes
        {
            StatusOK = 200,
            StatusBadRequest = 400,
            // 其他错误码...
        }
    }
}
