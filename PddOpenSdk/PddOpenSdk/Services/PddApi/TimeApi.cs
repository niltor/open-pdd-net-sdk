using PddOpenSdk.Models.Request.Time;
using PddOpenSdk.Models.Response.Time;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class TimeApi : PddCommonApi
    {
        /// <summary>
        /// 获取拼多多系统时间
        /// </summary>
        public async Task<GetTimeResponseModel> GetTimeAsync(GetTimeRequestModel getTime)
        {
            var result = await PostAsync<GetTimeRequestModel, GetTimeResponseModel>("pdd.time.get", getTime);
            return result;
        }
        /// <summary>
        /// 图片切割接口
        /// </summary>
        public async Task<ImageUtilDivideBase64ResponseModel> ImageUtilDivideBase64Async(ImageUtilDivideBase64RequestModel imageUtilDivideBase64)
        {
            var result = await PostAsync<ImageUtilDivideBase64RequestModel, ImageUtilDivideBase64ResponseModel>("pdd.util.divide.base64.image", imageUtilDivideBase64);
            return result;
        }
        /// <summary>
        /// 自动切图接口
        /// </summary>
        public async Task<ImageUtilDivideResponseModel> ImageUtilDivideAsync(ImageUtilDivideRequestModel imageUtilDivide)
        {
            var result = await PostAsync<ImageUtilDivideRequestModel, ImageUtilDivideResponseModel>("pdd.util.divide.image", imageUtilDivide);
            return result;
        }

    }
}
