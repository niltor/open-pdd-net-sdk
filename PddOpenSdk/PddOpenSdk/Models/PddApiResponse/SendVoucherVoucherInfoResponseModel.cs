using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class SendVoucherVoucherInfoResponseModel : PddResponseModel
    {
        /// <summary>
        /// 0-失败，1-成功
        /// </summary>
        [JsonProperty("is_sucess")]
        public object IsSucess { get; set; }

    }
}
