using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class SendVoucherPhysicalGoodsResponseModel : PddResponseModel
    {
        /// <summary>
        /// 0-失败，1-成功
        /// </summary>
        [JsonProperty("is_success")]
        public object IsSuccess { get; set; }

    }
}
