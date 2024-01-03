using OnlineShop.Infrastructure.Const;
using OnlineShop.Infrastructure.Utilities;

namespace OnlineShop.Application.Responses
{
    public class BaseCommandResponse
    {
        public object Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }

        public ApiResultStatusCode StatusCode { get; set; }



        public BaseCommandResponse()
        {
            IsSuccess = true;
            Message = DefaultConst.Success;
            StatusCode = ApiResultStatusCode.Success;
        }


        public void Success(object data = null , string message = null, List<string> errors = null)
        {
            IsSuccess = true;
            Message = message ?? DefaultConst.Success;
            Errors = errors;
            Data = data;
            StatusCode = ApiResultStatusCode.Success;


        }


        public void Failure(object data = null , string message = null , List<string> errors = null)
        {
            IsSuccess = false;
            Message = message ?? DefaultConst.Failure;
            Errors = errors;
            Data = data;
            StatusCode = ApiResultStatusCode.ServerError;

        }

    }
}
